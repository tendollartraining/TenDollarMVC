namespace FamilyDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tempDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Street", c => c.String(nullable: false));
            AddColumn("dbo.People", "City", c => c.String(nullable: false));
            AddColumn("dbo.People", "State", c => c.String(nullable: false));
            AddColumn("dbo.People", "Zip", c => c.String(nullable: false));
            AddColumn("dbo.People", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.People", "Fname", c => c.String(nullable: false));
            AlterColumn("dbo.People", "Lname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Lname", c => c.String());
            AlterColumn("dbo.People", "Fname", c => c.String());
            DropColumn("dbo.People", "Phone");
            DropColumn("dbo.People", "Zip");
            DropColumn("dbo.People", "State");
            DropColumn("dbo.People", "City");
            DropColumn("dbo.People", "Street");
        }
    }
}
