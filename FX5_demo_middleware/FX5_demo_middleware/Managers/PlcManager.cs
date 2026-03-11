using fx5_demo.Interfaces;
using fx5_demo.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace fx5_demo.Managers
{
    public class PlcManager
    {
        private readonly IPLCService _plcService;
        private readonly IDataLogger _logger;
        private CancellationTokenSource _cancellationTokenSource;

        private PlcData _latestData;
        private readonly object _dataLock = new object();

        private DateTime _lastLogTime = DateTime.MinValue;
        private DateTime _lastReconnectAttempt = DateTime.MinValue;

        public event Action<PlcData> OnDataUpdated;

        public PlcManager(IPLCService plcService, IDataLogger logger)
        {
            _plcService = plcService;
            _logger = logger;
            _latestData = new PlcData();
        }

        public void Start()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => WorkerLoop(_cancellationTokenSource.Token));
        }

        public void Stop()
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
            _plcService.Disconnect();
        }

        public PlcData GetLatestData()
        {
            lock (_dataLock)
            {
                return _latestData;
            }
        }

        public bool WriteCommand(string device, int value)
        {
            return _plcService.WriteData(device, value);
        }

        private async Task WorkerLoop(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                bool hasError = false;
                try
                {
                    if (!_plcService.IsConnected())
                    {
                        // 5 saniyede bir auto-reconnect dener
                        if ((DateTime.Now - _lastReconnectAttempt).TotalSeconds >= 5)
                        {
                            _plcService.Connect();
                            _lastReconnectAttempt = DateTime.Now;
                        }
                    }

                    PlcData data = _plcService.ReadData();

                    lock (_dataLock)
                    {
                        _latestData = data;
                    }

                    if (OnDataUpdated != null)
                    {
                        OnDataUpdated.Invoke(data);
                    }

                    // Data Logging (Her 60 saniyede bir)
                    if ((DateTime.Now - _lastLogTime).TotalSeconds >= 60)
                    {
                        if (data.IsConnected) // yalnizca bagliyken mantikli veri vardir
                        {
                            _logger.Log(data);
                        }
                        _lastLogTime = DateTime.Now;
                    }

                    // 1 saniyede bir oku ve UI güncelle (Akıcılık için)
                    await Task.Delay(1000, cancellationToken);
                }
                catch (TaskCanceledException)
                {
                    break;
                }
                catch
                {
                    hasError = true;
                }

                if (hasError)
                {
                    try
                    {
                        await Task.Delay(5000, cancellationToken);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
            }
        }
    }
}
