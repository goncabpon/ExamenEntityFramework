using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace ExamenEntityFramework.Pizza
{
    public class PizzaPrice

    {
        public Pizzas pizza;
        public PizzaPrice(Pizzas pizza)
        {
            this.pizza = pizza;
        }
        public decimal TotalPrice
        {
            get
            {
                var profit = Convert.ToDecimal(ConfigurationManager.AppSettings["profit"]);
                var price = (pizza.Ingredients.Sum(c => c.IngPrice) )* profit;
                return price;
            }

        }

        public int Amount
        {
            get
            {
                var amount = pizza.Ingredients.Sum(c => c.IngId);
                if (amount < 1)
                {
                    throw new System.ArgumentException("Amount cannot be lower than one");
                }

                return amount;
            }
        }
    }
}
