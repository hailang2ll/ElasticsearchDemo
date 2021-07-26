using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch.Contracts
{
    public interface IEsClientProvider
    {
        ElasticClient InitClient();
    }
}
