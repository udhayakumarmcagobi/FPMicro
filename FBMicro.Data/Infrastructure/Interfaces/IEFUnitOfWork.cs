using System.Data.Entity;

namespace FBMicro.Data.Infrastructure
{
    public interface IEFUnitOfWork : IUnitOfWork
    {
        DbContext Context { get; }
    }
}
