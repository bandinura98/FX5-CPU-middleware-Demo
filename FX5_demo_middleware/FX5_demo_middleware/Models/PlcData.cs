using System;

namespace fx5_demo.Models
{
    public class PlcData
    {
        public bool IsConnected { get; set; }
        public int Temperature { get; set; } // D100
        public int ProductionCount { get; set; } // D101
        public int Speed { get; set; } // D102
        public DateTime Timestamp { get; set; }

        public PlcData()
        {
            Timestamp = DateTime.Now;
            IsConnected = false;
        }
    }
}
