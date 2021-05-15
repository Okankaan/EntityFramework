namespace FootballApp_AutomaticMigrationEnabled_false.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamColumnToPlayerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            CreateIndex("dbo.Players", "Team_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropColumn("dbo.Players", "Team_Id");
        }
    }
}
