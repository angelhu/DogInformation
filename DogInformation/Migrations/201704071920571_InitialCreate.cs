namespace DogInformation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DogBreeds",
                c => new
                    {
                        DogBreedID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.DogBreedID);
            
            CreateTable(
                "dbo.Dogs",
                c => new
                    {
                        DogID = c.Int(nullable: false, identity: true),
                        DogAge = c.Int(nullable: false),
                        DogGender = c.String(),
                        DogBreedID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DogID)
                .ForeignKey("dbo.DogBreeds", t => t.DogBreedID, cascadeDelete: true)
                .Index(t => t.DogBreedID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dogs", "DogBreedID", "dbo.DogBreeds");
            DropIndex("dbo.Dogs", new[] { "DogBreedID" });
            DropTable("dbo.Dogs");
            DropTable("dbo.DogBreeds");
        }
    }
}
