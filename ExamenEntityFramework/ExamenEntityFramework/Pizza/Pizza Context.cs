namespace ExamenEntityFramework.Pizza
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Pizza_Context : DbContext, IUnitOW
    {
        public DbSet<Pizzas> Pizzas { get; set; }
        public DbSet<Ingredients> Ingredients { get; set;}
        public DbSet<PizzaPrice> PizzaPrice { get; set; }


        public Pizza_Context()
            : base("name=Pizza Context")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }


}