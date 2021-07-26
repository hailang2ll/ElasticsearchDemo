using Elasticsearch.Contracts;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch.Service
{
    public class EsClientProvider : IEsClientProvider
    {
        private readonly IConfiguration _configuration;
        private ElasticClient _client;
        public EsClientProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ElasticClient InitClient()
        {
            if (_client != null)
            {
                return _client;
            }
            else
            {
                var node = new Uri(_configuration["EsUrl"]);
                var setting = new ConnectionSettings(node);
                //setting.DefaultIndex("estest");

                _client = new ElasticClient(setting);
                return _client;
            }
        }


    }
}
