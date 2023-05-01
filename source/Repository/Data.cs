using ACT.Model;
using ACT.Repository.Interfaces;

namespace ACT.Repository
{
    public class Data : IData
    {
        List<Launch> launchs = new();

        public List<Launch> Launches
        {
            get
            {
                return launchs;
            }
            set
            {
                launchs = value;
            }
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
