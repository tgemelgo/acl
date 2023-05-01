using ACT.Repository.Interfaces;
using ACT.Services.Interfaces;
using ACT.ViewModel;

namespace ACT.Services
{
    public class ConsolidatedDayService : IConsolidatedDayService
    {
        private readonly IRepositoryConsolidatedDay _consolidatedDay;

        public ConsolidatedDayService(IRepositoryConsolidatedDay consolidatedDay)
        {
            _consolidatedDay = consolidatedDay;
        }

        public void Dispose() => GC.SuppressFinalize(this);

        public IEnumerable<VM_ConsolidatedDay> GetReport(DateTime? startDate, DateTime? endDate)
        {
            if (!startDate.HasValue)
                throw new ArgumentNullException($"startDate");

            if (!endDate.HasValue) 
                throw new ArgumentNullException($"endDate");

            if (startDate > endDate)
                throw new Exception("startDate is greater than endDate");

            return _consolidatedDay.GetValues(startDate.Value, endDate.Value);
        }
    }
}
