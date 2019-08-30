namespace GaragemHB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        Modelo_FK = c.Int(nullable: false),
                        Cores_FK = c.Int(nullable: false),
                        CadastroPeriodo_FK = c.Int(nullable: false),
                        Usuario_FK = c.Int(nullable: false),
                        TermoDeUso_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegistroPeriodoes", t => t.CadastroPeriodo_FK, cascadeDelete: true)
                .ForeignKey("dbo.Cores", t => t.Cores_FK, cascadeDelete: true)
                .ForeignKey("dbo.Modeloes", t => t.Modelo_FK, cascadeDelete: true)
                .ForeignKey("dbo.TermoDeUsoes", t => t.TermoDeUso_FK, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_FK, cascadeDelete: true)
                .Index(t => t.Modelo_FK)
                .Index(t => t.Cores_FK)
                .Index(t => t.CadastroPeriodo_FK)
                .Index(t => t.Usuario_FK)
                .Index(t => t.TermoDeUso_FK);
            
            CreateTable(
                "dbo.RegistroPeriodoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculos = c.Int(nullable: false),
                        DataInicial = c.DateTime(nullable: false),
                        Final = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoModelo = c.String(),
                        DescricaoModelo = c.String(),
                        MarcaFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaFK, cascadeDelete: true)
                .Index(t => t.MarcaFK);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoMarca = c.Int(nullable: false),
                        DescricaoMarca = c.String(),
                        TipoVeiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TermoDeUsoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Atual = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ResideFora = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        PCD = c.Boolean(nullable: false),
                        Noturno = c.Boolean(nullable: false),
                        UsuGestor = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuAdd = c.Int(nullable: false),
                        UsuAlter = c.Int(nullable: false),
                        DataAdd = c.DateTime(nullable: false),
                        DataAlter = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Valors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoveiculo = c.Int(nullable: false),
                        valor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Usuario_FK", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "TermoDeUso_FK", "dbo.TermoDeUsoes");
            DropForeignKey("dbo.Locacaos", "Modelo_FK", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "MarcaFK", "dbo.Marcas");
            DropForeignKey("dbo.Locacaos", "Cores_FK", "dbo.Cores");
            DropForeignKey("dbo.Locacaos", "CadastroPeriodo_FK", "dbo.RegistroPeriodoes");
            DropIndex("dbo.Modeloes", new[] { "MarcaFK" });
            DropIndex("dbo.Locacaos", new[] { "TermoDeUso_FK" });
            DropIndex("dbo.Locacaos", new[] { "Usuario_FK" });
            DropIndex("dbo.Locacaos", new[] { "CadastroPeriodo_FK" });
            DropIndex("dbo.Locacaos", new[] { "Cores_FK" });
            DropIndex("dbo.Locacaos", new[] { "Modelo_FK" });
            DropTable("dbo.Valors");
            DropTable("dbo.Usuarios");
            DropTable("dbo.TermoDeUsoes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Modeloes");
            DropTable("dbo.RegistroPeriodoes");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Cores");
        }
    }
}
