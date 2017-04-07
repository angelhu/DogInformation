namespace DogInformation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddogname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dogs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dogs", "Name");
        }
    }
}
