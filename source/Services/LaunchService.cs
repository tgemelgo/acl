using ACT.Repository.Interfaces;
using ACT.Services.Interfaces;
using ACT.ViewModel;

namespace ACT.Services
{
    public class LaunchService : ILaunchService
    {
        private readonly IRepositoryLaunch _repositoryLaunch;

        public LaunchService(IRepositoryLaunch repositoryLaunch)
        {
            _repositoryLaunch = repositoryLaunch;
        }

        public void Dispose() => GC.SuppressFinalize(this);

        public void Add(VM_Launch launch)
        {
            _repositoryLaunch.Add(new()
            {
                DateLaunch = launch.DateLaunch,
                Id = launch.Id,
                PayDate = launch.PayDate,
                Supplier = launch.Supplier,
                ValueLauch = launch.ValueLauch,
                ValuePay = launch.ValuePay
            });
        }

        public VM_Launch? Get(Guid id)
        {
            var _launchDB = _repositoryLaunch.GetById(id);
            return _launchDB == null ? null : new VM_Launch()
            {
                DateLaunch = _launchDB.DateLaunch,
                Id = _launchDB.Id,
                ValuePay = _launchDB.ValuePay,
                ValueLauch = _launchDB.ValueLauch,
                PayDate = _launchDB.PayDate,
                Supplier = _launchDB.Supplier
            };
        }

        public IEnumerable<VM_Launch> GetAll()
        {
            return _repositoryLaunch
                        .GetAll()
                        .Select(m => new VM_Launch()
                        {
                            DateLaunch = m.DateLaunch,
                            Id = m.Id,
                            PayDate = m.PayDate,
                            Supplier = m.Supplier,
                            ValueLauch = m.ValueLauch,
                            ValuePay = m.ValuePay
                        });
        }

        public void Remove(Guid id)
        {
            _repositoryLaunch.Remove(id);
        }

        public void Update(VM_Launch launch)
        {
            _repositoryLaunch.Update(new()
            {
                DateLaunch = launch.DateLaunch,
                Id = launch.Id,
                PayDate = launch.PayDate,
                Supplier = launch.Supplier,
                ValueLauch = launch.ValueLauch,
                ValuePay = launch.ValuePay
            });
        }
    }
}
