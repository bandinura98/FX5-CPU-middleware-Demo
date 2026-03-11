using fx5_demo.Interfaces;
using fx5_demo.Models;
using System;
using System.IO;

namespace fx5_demo.Services
{
    public class CsvDataLogger : IDataLogger
    {
        private readonly string _filePath;

        public CsvDataLogger(string fileName = "plc_log.csv")
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            _filePath = Path.Combine(appDir, fileName);

            if (!File.Exists(_filePath))
            {
                try
                {
                    File.WriteAllText(_filePath, "Timestamp,Temperature,ProductionCount,Speed,IsConnected\n");
                }
                catch { }
            }
        }

        public void Log(PlcData data)
        {
            try
            {
                string line = string.Format("{0:yyyy-MM-dd HH:mm:ss},{1},{2},{3},{4}\n", data.Timestamp, data.Temperature, data.ProductionCount, data.Speed, data.IsConnected);
                File.AppendAllText(_filePath, line);
            }
            catch
            {
            }
        }
    }
}
