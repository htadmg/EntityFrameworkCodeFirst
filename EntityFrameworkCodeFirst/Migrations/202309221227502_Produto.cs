namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");         
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
        }
    }
}
