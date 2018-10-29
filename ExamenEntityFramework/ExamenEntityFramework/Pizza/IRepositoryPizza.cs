using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntityFramework.Pizza
{
    interface IRepositoryPizza
    {
        int GetPizza(int Id);
        void AddPizza(Pizzas pizza);
        void DeletePizza(Pizzas pizza);
        void save(); 
    }
}
