namespace ProjectLikeStackOverflow1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserNameFieldAddedInQuestionModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "UserName");
        }
    }
}
