namespace ExamenEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PizzaTest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PizzasIngredients", "Ingredients_Id", "dbo.Ingredients");
            DropPrimaryKey("dbo.Ingredients");
            DropColumn("dbo.Ingredients", "Id");
            RenameColumn(table: "dbo.PizzasIngredients", name: "Ingredients_Id", newName: "Ingredients_IngId");
            RenameIndex(table: "dbo.PizzasIngredients", name: "IX_Ingredients_Id", newName: "IX_Ingredients_IngId");
           
            AddColumn("dbo.Ingredients", "IngId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Ingredients", "IngId");
            AddForeignKey("dbo.PizzasIngredients", "Ingredients_IngId", "dbo.Ingredients", "IngId", cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.PizzasIngredients", "Ingredients_IngId", "dbo.Ingredients");
            DropPrimaryKey("dbo.Ingredients");
            DropColumn("dbo.Ingredients", "IngId");
            AddPrimaryKey("dbo.Ingredients", "Id");
            RenameIndex(table: "dbo.PizzasIngredients", name: "IX_Ingredients_IngId", newName: "IX_Ingredients_Id");
            RenameColumn(table: "dbo.PizzasIngredients", name: "Ingredients_IngId", newName: "Ingredients_Id");
            AddForeignKey("dbo.PizzasIngredients", "Ingredients_Id", "dbo.Ingredients", "Id", cascadeDelete: true);
        }
    }
}
