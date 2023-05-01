using ACT.Model;
using ACT.Repository.Interfaces;

namespace ACT.Repository
{
    public class RepositoryLaunch : IRepositoryLaunch
    {
        private readonly IData _data;

        public RepositoryLaunch(IData data)
        {
            _data = data;
        }

        public void Dispose() => GC.SuppressFinalize(this);

        public void Add(Launch launch)
        {
            launch.Id = Guid.NewGuid();
            _data.Launches.Add(launch);
        }

        public IEnumerable<Launch> GetAll()
        {
            return _data.Launches;
        }

        public Launch? GetById(Guid id)
        {
            return _data.Launches.FirstOrDefault(m => m.Id.Equals(id));
        }

        public void Remove(Guid id)
        {
            var _item = _data.Launches.FirstOrDefault(m => m.Id.Equals(id));
            if (_item == null)
                throw new Exception("Item não encontrado para exclusão");

            _data.Launches.Remove(_item);
        }

        public void Update(Launch launch)
        {
            var _item = _data.Launches.FirstOrDefault(m => m.Id.Equals(launch.Id));
            if (_item == null)
                throw new Exception("Item não encontrado para atualização");

            _item.ValueLauch = launch.ValueLauch;
            _item.ValuePay = launch.ValuePay;
            _item.Supplier = launch.Supplier;
            _item.DateLaunch = launch.DateLaunch;
            _item.PayDate = launch.PayDate;
        }
    }
}
