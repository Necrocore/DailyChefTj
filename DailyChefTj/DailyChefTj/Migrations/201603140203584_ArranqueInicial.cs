namespace DailyChefTj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArranqueInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nutriologoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Telefono = c.String(),
                        Rol_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargoes", t => t.Rol_Id)
                .Index(t => t.Rol_Id);
            
            CreateTable(
                "dbo.Platilloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Calificacion = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Platillo_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Platilloes", t => t.Platillo_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Platillo_Id)
                .Index(t => t.Usuario_Id);
            
            AddColumn("dbo.Chefs", "Rol_Id", c => c.Int());
            AddColumn("dbo.Usuarios", "Rol_Id", c => c.Int());
            AddColumn("dbo.Usuarios", "Nutriologo_Id", c => c.Int());
            AddColumn("dbo.Ingredientes", "Platillo_Id", c => c.Int());
            CreateIndex("dbo.Chefs", "Rol_Id");
            CreateIndex("dbo.Usuarios", "Rol_Id");
            CreateIndex("dbo.Usuarios", "Nutriologo_Id");
            CreateIndex("dbo.Ingredientes", "Platillo_Id");
            AddForeignKey("dbo.Chefs", "Rol_Id", "dbo.Cargoes", "Id");
            AddForeignKey("dbo.Usuarios", "Rol_Id", "dbo.Cargoes", "Id");
            AddForeignKey("dbo.Usuarios", "Nutriologo_Id", "dbo.Nutriologoes", "Id");
            AddForeignKey("dbo.Ingredientes", "Platillo_Id", "dbo.Platilloes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Ventas", "Platillo_Id", "dbo.Platilloes");
            DropForeignKey("dbo.Ingredientes", "Platillo_Id", "dbo.Platilloes");
            DropForeignKey("dbo.Nutriologoes", "Rol_Id", "dbo.Cargoes");
            DropForeignKey("dbo.Usuarios", "Nutriologo_Id", "dbo.Nutriologoes");
            DropForeignKey("dbo.Usuarios", "Rol_Id", "dbo.Cargoes");
            DropForeignKey("dbo.Chefs", "Rol_Id", "dbo.Cargoes");
            DropIndex("dbo.Ventas", new[] { "Usuario_Id" });
            DropIndex("dbo.Ventas", new[] { "Platillo_Id" });
            DropIndex("dbo.Nutriologoes", new[] { "Rol_Id" });
            DropIndex("dbo.Ingredientes", new[] { "Platillo_Id" });
            DropIndex("dbo.Usuarios", new[] { "Nutriologo_Id" });
            DropIndex("dbo.Usuarios", new[] { "Rol_Id" });
            DropIndex("dbo.Chefs", new[] { "Rol_Id" });
            DropColumn("dbo.Ingredientes", "Platillo_Id");
            DropColumn("dbo.Usuarios", "Nutriologo_Id");
            DropColumn("dbo.Usuarios", "Rol_Id");
            DropColumn("dbo.Chefs", "Rol_Id");
            DropTable("dbo.Ventas");
            DropTable("dbo.Platilloes");
            DropTable("dbo.Nutriologoes");
            DropTable("dbo.Cargoes");
        }
    }
}
