using ACT.Model;

namespace ACT.Repository.Interfaces
{
    public interface IData : IDisposable
    {
        List<Launch> Launches { get; set; }
    }
}
