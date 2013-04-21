using System.ComponentModel.DataAnnotations;

namespace TestDrivingMVC.Common.Domain {

    public class Product {

        public long Id { get; set; }

        [Display(Name="Product"), Required, StringLength(75)]
        public string Name { get; set; }

        [Display(Name="Price")]
        public decimal UnitPrice { get; set; }

        [Display(Name="Quantity on Hand")]
        public int QuantityOnHand { get; set; }

    }

}