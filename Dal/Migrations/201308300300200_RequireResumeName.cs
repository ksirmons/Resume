namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequireResumeName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resumes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resumes", "Name", c => c.String());
        }
    }
}
