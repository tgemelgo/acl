using ACT.ViewModel;

namespace ACT.Services.Interfaces
{
    public interface IConsolidatedDayService : IDisposable
    {
        IEnumerable<VM_ConsolidatedDay> GetReport(DateTime? startDate, DateTime? endDate);
    }
}
