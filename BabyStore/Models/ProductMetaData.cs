using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace BabyStore.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product          
    {
    }

    public class ProductMetaData
    {
        [DisplayName("Product Name")]
        public string Name { get; set; }
    }
}