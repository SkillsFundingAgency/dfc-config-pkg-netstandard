namespace DFC.Configuration
{
    public interface IConfigurationCache
    {
            T Get<T>(string key);
            void Set(string key, object value);
    }
}
