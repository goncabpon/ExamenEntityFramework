using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ExamenEntityFramework.Pizza
{
    public class Ingredients
    {
        [Key]
        public int IngId { get; set; }

        public string IngName { get; set; }
        public decimal IngPrice { get; set; }

        public ICollection<Pizzas> Pizza { get; set; }
    }
}
