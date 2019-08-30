namespace WebApiUltimate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vortex : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EstadoCivil = c.String(),
                        RG = c.String(),
                        CPF = c.String(),
                        Cep = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuCriacao = c.Int(nullable: false),
                        UsuAlter = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlter = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
