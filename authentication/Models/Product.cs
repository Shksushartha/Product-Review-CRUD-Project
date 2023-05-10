using System;
namespace authentication.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string desc { get; set; }
        public float price { get; set; }
        public int? discount { get; set; }
        public float? pAfterD { get; set; }

        public virtual ICollection<Review>? Reviews { get; set; }
    }
    }


