using ACT.ViewModel;

namespace ACT.Repository.Interfaces
{
    public interface IRepositoryConsolidatedDay : IDisposable
    {
        IEnumerable<VM_ConsolidatedDay> GetValues(DateTime startDate, DateTime endDate);
    }
}
