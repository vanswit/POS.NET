namespace POS.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        IsValid = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        IsChanged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        AddressId = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        IsValid = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        IsChanged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Int(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        IsChanged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        LineValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsValid = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        IsChanged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        IsChanged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
            DropTable("dbo.PurchaseLines");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
