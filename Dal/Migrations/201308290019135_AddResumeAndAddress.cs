namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddResumeAndAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Resumes", new[] { "Address_Id" });
            DropForeignKey("dbo.Resumes", "Address_Id", "dbo.Addresses");
            DropTable("dbo.Addresses");
            DropTable("dbo.Resumes");
        }
    }
}
