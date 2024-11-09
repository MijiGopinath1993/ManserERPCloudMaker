using Microsoft.Extensions.Configuration;

namespace ERPCloudMaker 
{
    public static class ConfigurationHelper
    {
        public static string GetByName(string configKeyName)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build(); 
            var connectionString = config.GetConnectionString(configKeyName); 
            return connectionString;
        }
    }

}
