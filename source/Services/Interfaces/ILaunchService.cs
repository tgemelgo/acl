using ACT.ViewModel;

namespace ACT.Services.Interfaces
{
    public interface ILaunchService : IDisposable
    {
        void Add(VM_Launch launch);
        void Remove(Guid id);
        void Update(VM_Launch launch); 
        IEnumerable<VM_Launch> GetAll();
        VM_Launch? Get(Guid id);
    }
}
