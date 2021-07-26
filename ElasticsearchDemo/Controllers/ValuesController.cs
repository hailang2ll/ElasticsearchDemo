using Elasticsearch.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticsearchDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ElasticClient _client;
        public ValuesController(IEsClientProvider clientProvider)
        {
            _client = clientProvider.InitClient();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        [HttpPost("Index")]
        public ProductEntity Index()
        {
            ProductEntity product = new ProductEntity()
            {
                ProductID = 1,
                ProductName = "2进口品牌爱马仕好看时尚22",
                ProductCount = 100,
                ProductImages = "http://www.yuxunwang/images/1.jpg",
                ProductDetail = "爱马仕好看时尚潮流引进进校园碴资料里顶置晨压顶地国弟弟积分困",
                CategoryID = 1,
                BrandID = 1,
                BrandName = "爱马仕",
                CountryName = "美国",
                RetailPrice = 450,
                SortOrder = 1,
            };

            //未指定索引名，失败，要设置默认 setting.DefaultIndex("estest");
            //var res = _client.IndexDocument(product);

            //新增，同ID修改
            var b = _client.Index(product, s => s.Index("estest"));

            //删除
            //var c = _client.Delete(new DocumentPath<ProductEntity>("R4rkrXoBEtfSY3SD8zg2"), s => s.Index("estest"));
            return product;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost("Seaarch")]
        public IReadOnlyCollection<ProductEntity> Seaarch(string type)
        {
            return _client.Search<ProductEntity>(s => s
                .From(0)
                .Size(10)
                .Query(q => q.Match(m => m.Field(f => f.CategoryID).Query(type)))).Documents;
        }
    }
}
