using fx5_demo.Models;

namespace fx5_demo.Interfaces
{
    public interface IDataLogger
    {
        void Log(PlcData data);
    }
}
