using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    [ElasticsearchType(IdProperty = "ProductID")]
    public class ProductEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? RetailPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ProductCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? BrandID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductImages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? CategoryID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? SortOrder { get; set; }
    }
}
