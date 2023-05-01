using ACT.Model;

namespace ACT.Repository.Interfaces
{
    public interface IRepositoryLaunch : IDisposable
    {
        void Add(Launch launch);
        void Update(Launch launch);
        IEnumerable<Launch> GetAll();
        Launch? GetById(Guid id);
        void Remove(Guid id);
    }
}
