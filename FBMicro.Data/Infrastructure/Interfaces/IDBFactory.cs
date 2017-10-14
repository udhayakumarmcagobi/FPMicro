using FBMicro.Data.DataProvider;
using System.Threading.Tasks;

namespace FBMicro.Data.Infrastructure
{
    public interface IDBFactory
    {
        FBMicroContext GetContext();
    }
}
