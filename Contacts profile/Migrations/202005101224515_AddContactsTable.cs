namespace Contacts_profile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContactsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactFirstName = c.String(nullable: false),
                        ContactLastName = c.String(nullable: false),
                        ContactEmail = c.String(nullable: false),
                        ContactPhoneNum = c.String(nullable: false),
                        ContactAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
