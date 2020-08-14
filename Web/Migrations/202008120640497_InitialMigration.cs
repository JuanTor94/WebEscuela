namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 40),
                        NumMatricula = c.String(),
                        Edad = c.Int(nullable: false),
                        Semestre = c.Int(nullable: false),
                        Genero = c.String(),
                        CarreraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carreras", t => t.CarreraId, cascadeDelete: true)
                .Index(t => t.Nombre, name: "IndexNombre")
                .Index(t => t.CarreraId);
            
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 40),
                        duracion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, name: "IndexNombre");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnoes", "CarreraId", "dbo.Carreras");
            DropIndex("dbo.Carreras", "IndexNombre");
            DropIndex("dbo.Alumnoes", new[] { "CarreraId" });
            DropIndex("dbo.Alumnoes", "IndexNombre");
            DropTable("dbo.Carreras");
            DropTable("dbo.Alumnoes");
        }
    }
}
