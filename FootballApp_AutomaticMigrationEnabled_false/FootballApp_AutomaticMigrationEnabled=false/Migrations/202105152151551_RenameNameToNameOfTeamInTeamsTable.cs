namespace FootballApp_AutomaticMigrationEnabled_false.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameNameToNameOfTeamInTeamsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "NameOfTeam", c => c.String());
            Sql("Update Teams set NameOfTeam=Name"); //Changed this column name from Team Class and we added this line for to avoid data loss.
            DropColumn("dbo.Teams", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Name", c => c.String());
            Sql("Update Teams set Name=NameOfTeam");
            DropColumn("dbo.Teams", "NameOfTeam");
        }
    }
}
