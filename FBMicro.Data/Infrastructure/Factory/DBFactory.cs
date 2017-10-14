using FBMicro.Data.DataProvider;
using System.Threading.Tasks;

namespace FBMicro.Data.Infrastructure
{
    public sealed class DBFactory : Disposable, IDBFactory
    {
        FBMicroContext dbContext;
        public FBMicroContext GetContext()
        {
            return dbContext ?? (dbContext = new FBMicroContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        internal class Instance
        {
            static Instance() { }

            internal static readonly FBMicroContext dbContext = new FBMicroContext();
        }
    }
}
