using ActUtlType64Lib;
using fx5_demo.Interfaces;
using fx5_demo.Models;
using System;

namespace fx5_demo.Services
{
    public class ActUtlTypeService : IPLCService
    {
        private ActUtlType64 _plc;
        private bool _isConnected;
        private int _logicalStationNumber;

        public ActUtlTypeService(int logicalStationNumber = 1)
        {
            initPlcSettings(logicalStationNumber);
        }

        private void initPlcSettings(int logicalStationNumber) {
            _plc = new ActUtlType64();
            _logicalStationNumber = logicalStationNumber;
            _plc.ActLogicalStationNumber = _logicalStationNumber;
        }

        public bool Connect()
        {
            if (_isConnected) return true;
            try
            {
                initPlcSettings(1);
                int result = _plc.Open();
                _isConnected = (result == 0);
                return _isConnected;
            }
            catch
            {
                _isConnected = false;
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                _plc.Close();
            }
            finally
            {
                _isConnected = false;
            }
        }

        public bool IsConnected()
        {
            if (!_isConnected) return false;
            
            try
            {
                int value;
                int result = _plc.GetDevice("SB0", out value); // dummy read
                if (result != 0) 
                {
                    _isConnected = false;
                }
                return _isConnected;
            }
            catch
            {
                _isConnected = false;
                return false;
            }
        }

        public PlcData ReadData()
        {
            PlcData data = new PlcData { Timestamp = DateTime.Now, IsConnected = _isConnected };
            if (!_isConnected) return data;

            try
            {
                int temp, count, speed;
                // Örnek adresler: D100=Sıcaklık, D101=Adet, D102=Hız
                int res1 = _plc.GetDevice("D100", out temp);
                int res2 = _plc.GetDevice("D101", out count);
                int res3 = _plc.GetDevice("D102", out speed);

                if (res1 == 0 && res2 == 0 && res3 == 0)
                {
                    data.Temperature = temp;
                    data.ProductionCount = count;
                    data.Speed = speed;
                }
                else
                {
                    _isConnected = false; 
                    data.IsConnected = false;
                }
            }
            catch
            {
                _isConnected = false;
                data.IsConnected = false;
            }

            return data;
        }

        public bool WriteData(string device, int value)
        {
            if (!_isConnected) return false;

            try
            {
                int result = _plc.SetDevice(device, value);
                return result == 0;
            }
            catch
            {
                _isConnected = false;
                return false;
            }
        }
    }
}
