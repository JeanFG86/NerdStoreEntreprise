using NSE.Core.Data;

namespace NSE.Core.DomainObjects
{
    public interface IRepository<T>: IDisposable where T : Entity
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
