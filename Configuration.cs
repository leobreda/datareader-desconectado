using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDataReader
{
    public static class Configuration
    {
        private static string _connectionString { get; set; }

        static Configuration()
        {
            string config = System.IO.Directory.GetCurrentDirectory();
#if DEBUG
            config = config.Replace(@"bin\Debug\netcoreapp2.0", "");
#endif

            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(config)
            .AddJsonFile("appsettings.json");

            IConfigurationRoot _configurationRoot = builder.Build();

            _connectionString = _configurationRoot["ConnectionStrings:Sql"].ToString();

        }

        public static string ConnectionStringsSql { get { return _connectionString; } }

    }
}
