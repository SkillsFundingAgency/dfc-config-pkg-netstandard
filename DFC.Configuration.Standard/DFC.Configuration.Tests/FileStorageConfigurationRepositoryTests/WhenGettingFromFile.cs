using DFC.Configuration.FileStorage;
using NUnit.Framework;

namespace DFC.Configuration.Core.Tests.FileStorageConfigurationRepositoryTests
{
    public class WhenGettingFromFile
    {
        private FileStorageConfigurationRepository _configurationRepository;

        [SetUp]
        public void Arrange()
        {
            _configurationRepository = new FileStorageConfigurationRepository();
        }

        [Test]
        public void ThenTheFileIsCorrectlyReadfromTheAppDataFolder()
        {
            //Act
            var config = _configurationRepository.Get("test", "test", "1.0");

            //Assert
            Assert.IsNotNull(config);
        }
    }
}
