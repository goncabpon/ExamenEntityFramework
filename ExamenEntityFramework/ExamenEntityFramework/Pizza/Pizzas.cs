using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ExamenEntityFramework.Pizza
{
    public class Pizzas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public ICollection<Ingredients> Ingredients { get; set; }

      
          
          
    }
}
