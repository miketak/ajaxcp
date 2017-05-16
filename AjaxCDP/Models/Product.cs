using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AjaxCDP.Models
{
    public class Product
    {
        [Display(Name="Product Code")]
        public string ProdCode { get; set; }

        [Display(Name="Product Name")]
        public string ProdName { get; set; }

        [Display(Name="Product Quantity")]
        public int ProdQty { get; set; }
    }
}