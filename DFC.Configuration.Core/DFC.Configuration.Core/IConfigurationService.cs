using System.Threading.Tasks;

namespace DFC.Configuration
{
    public interface IConfigurationService
    {
        T Get<T>();
        Task<T> GetAsync<T>();
    }
}