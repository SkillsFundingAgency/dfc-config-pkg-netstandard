using Microsoft.WindowsAzure.Storage.Table;

namespace DFC.Configuration.AzureTableStorage
{
    internal class ConfigurationItem : TableEntity
    {
        public string Data { get; set; }
    }
}