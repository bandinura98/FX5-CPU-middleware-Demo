using fx5_demo.Models;

namespace fx5_demo.Interfaces
{
    public interface IPLCService
    {
        bool Connect();
        void Disconnect();
        bool IsConnected();
        PlcData ReadData();
        bool WriteData(string device, int value);
    }
}
