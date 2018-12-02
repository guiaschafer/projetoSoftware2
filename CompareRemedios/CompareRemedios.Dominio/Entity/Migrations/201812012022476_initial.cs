namespace CompareRemedios.Dominio.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FARMACIA",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeFantasia = c.String(),
                        Endereco = c.String(),
                        Bairro = c.String(),
                        Numero = c.Int(nullable: false),
                        CEP = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PRECO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdFarmacia = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FARMACIA", t => t.IdFarmacia, cascadeDelete: true)
                .ForeignKey("dbo.PRODUTO", t => t.IdProduto, cascadeDelete: true)
                .Index(t => t.IdFarmacia)
                .Index(t => t.IdProduto);
            
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Perfils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.Int(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.USUARIO", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Perfils", "Usuario_Id", "dbo.USUARIO");
            DropForeignKey("dbo.PRECO", "IdProduto", "dbo.PRODUTO");
            DropForeignKey("dbo.PRECO", "IdFarmacia", "dbo.FARMACIA");
            DropIndex("dbo.Perfils", new[] { "Usuario_Id" });
            DropIndex("dbo.PRECO", new[] { "IdProduto" });
            DropIndex("dbo.PRECO", new[] { "IdFarmacia" });
            DropTable("dbo.Perfils");
            DropTable("dbo.USUARIO");
            DropTable("dbo.PRODUTO");
            DropTable("dbo.PRECO");
            DropTable("dbo.FARMACIA");
        }
    }
}
