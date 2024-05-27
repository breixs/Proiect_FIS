namespace Proiect_Fis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Angajats",
                c => new
                    {
                        AngajatId = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Categorie = c.String(),
                    })
                .PrimaryKey(t => t.AngajatId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        ContCreat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Comandas",
                c => new
                    {
                        ComandaId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Status = c.String(),
                        ClientId = c.Int(nullable: false),
                        ProdusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComandaId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Produs", t => t.ProdusId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ProdusId);
            
            CreateTable(
                "dbo.Produs",
                c => new
                    {
                        ProdusId = c.Int(nullable: false, identity: true),
                        Descriere = c.String(),
                        Pret = c.Single(nullable: false),
                        Scor = c.Single(nullable: false),
                        Promotie_PromotieId = c.Int(),
                    })
                .PrimaryKey(t => t.ProdusId)
                .ForeignKey("dbo.Promoties", t => t.Promotie_PromotieId)
                .Index(t => t.Promotie_PromotieId);
            
            CreateTable(
                "dbo.Promoties",
                c => new
                    {
                        PromotieId = c.Int(nullable: false, identity: true),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PromotieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produs", "Promotie_PromotieId", "dbo.Promoties");
            DropForeignKey("dbo.Comandas", "ProdusId", "dbo.Produs");
            DropForeignKey("dbo.Comandas", "ClientId", "dbo.Clients");
            DropIndex("dbo.Produs", new[] { "Promotie_PromotieId" });
            DropIndex("dbo.Comandas", new[] { "ProdusId" });
            DropIndex("dbo.Comandas", new[] { "ClientId" });
            DropTable("dbo.Promoties");
            DropTable("dbo.Produs");
            DropTable("dbo.Comandas");
            DropTable("dbo.Clients");
            DropTable("dbo.Angajats");
        }
    }
}
