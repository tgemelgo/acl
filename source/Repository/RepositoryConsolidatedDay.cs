using ACT.Repository.Interfaces;
using ACT.ViewModel;
namespace ACT.Repository
{
    public class RepositoryConsolidatedDay : IRepositoryConsolidatedDay
    {
        private readonly IData _data;

        public RepositoryConsolidatedDay(IData data)
        {
            _data = data;
        }

        public void Dispose() => GC.SuppressFinalize(this);

        public IEnumerable<VM_ConsolidatedDay> GetValues(DateTime startDate, DateTime endDate)
        {
            return _data.Launches
                            .Where(m => m.DateLaunch >= startDate && m.DateLaunch <= endDate)
                            .GroupBy(m => m.DateLaunch)
                            .Select(m => new VM_ConsolidatedDay() { DateLaunch = m.Key, ValueLauch = m.Sum(p => p.ValueLauch) });
        }
    }
}
