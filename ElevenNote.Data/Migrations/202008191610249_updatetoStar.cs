namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetoStar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "IsStarred", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "IsStarred", c => c.Boolean());
        }
    }
}
