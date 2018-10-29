using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntityFramework.Pizza
{
    public class RepositoryPizza
    {
        public Pizza_Context context;
        public RepositoryPizza(Pizza_Context context)
        {
            this.context = context;
        }

        public Pizzas GetPizza(int Id)
        {
            return context.Pizzas.Find(Id);
        }
        public void AddPizza (Pizzas pizza)
        {
            context.Pizzas.Add(pizza);
        }
        public void DeletePizza(Pizzas pizza)
        {
            context.Pizzas.Remove(pizza);
        }

        public void Save()
        {
            context.SaveChanges();
        }

      
    }
}
