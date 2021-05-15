namespace FootballApp_AutomaticMigrationEnabled_false.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePlayerAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerAddresses",
                c => new
                    {
                        PlayerAddressId = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.Int(nullable: false),
                        PostCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerAddressId)
                .ForeignKey("dbo.Players", t => t.PlayerAddressId)
                .Index(t => t.PlayerAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerAddresses", "PlayerAddressId", "dbo.Players");
            DropIndex("dbo.PlayerAddresses", new[] { "PlayerAddressId" });
            DropTable("dbo.PlayerAddresses");
        }
    }
}
