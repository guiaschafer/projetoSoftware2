namespace ConsoleApp1.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FARMACIA",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeFantasia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PRECO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Farmacia_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FARMACIA", t => t.Farmacia_Id)
                .ForeignKey("dbo.PRODUTO", t => t.Produto_Id)
                .Index(t => t.Farmacia_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Farmacia_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FARMACIA", t => t.Farmacia_Id)
                .Index(t => t.Farmacia_Id);
            
            CreateTable(
                "dbo.USUARIO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        NomeCompleto = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRECO", "Produto_Id", "dbo.PRODUTO");
            DropForeignKey("dbo.PRODUTO", "Farmacia_Id", "dbo.FARMACIA");
            DropForeignKey("dbo.PRECO", "Farmacia_Id", "dbo.FARMACIA");
            DropIndex("dbo.PRODUTO", new[] { "Farmacia_Id" });
            DropIndex("dbo.PRECO", new[] { "Produto_Id" });
            DropIndex("dbo.PRECO", new[] { "Farmacia_Id" });
            DropTable("dbo.USUARIO");
            DropTable("dbo.PRODUTO");
            DropTable("dbo.PRECO");
            DropTable("dbo.FARMACIA");
        }
    }
}
