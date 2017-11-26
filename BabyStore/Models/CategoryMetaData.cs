using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace BabyStore.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }

    public class CategoryMetaData
    {
        [DisplayName("Category Name")]
        public string Name { get; set; }
    }
}