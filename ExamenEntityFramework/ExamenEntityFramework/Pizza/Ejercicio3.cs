using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntityFramework.Pizza
{
    class Ejercicio3
    {
        public static IEnumerable<Pizzas> Page<Pizzas>(this IEnumerable<Pizzas> source, int page, int pageSize)
        {
            pageSize = 15;

            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }

    }
}
