namespace POS.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "IsValid");
            DropColumn("dbo.Addresses", "IsNew");
            DropColumn("dbo.Addresses", "IsChanged");
            DropColumn("dbo.Customers", "IsValid");
            DropColumn("dbo.Customers", "IsNew");
            DropColumn("dbo.Customers", "IsChanged");
            DropColumn("dbo.Payments", "IsValid");
            DropColumn("dbo.Payments", "IsNew");
            DropColumn("dbo.Payments", "IsChanged");
            DropColumn("dbo.PurchaseLines", "IsValid");
            DropColumn("dbo.PurchaseLines", "IsNew");
            DropColumn("dbo.PurchaseLines", "IsChanged");
            DropColumn("dbo.Products", "IsValid");
            DropColumn("dbo.Products", "IsNew");
            DropColumn("dbo.Products", "IsChanged");
            DropColumn("dbo.Transactions", "IsValid");
            DropColumn("dbo.Transactions", "IsNew");
            DropColumn("dbo.Transactions", "IsChanged");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "IsChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Transactions", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Transactions", "IsValid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsValid", c => c.Boolean(nullable: false));
            AddColumn("dbo.PurchaseLines", "IsChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.PurchaseLines", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.PurchaseLines", "IsValid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Payments", "IsChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Payments", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Payments", "IsValid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsValid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Addresses", "IsChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Addresses", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Addresses", "IsValid", c => c.Boolean(nullable: false));
        }
    }
}
