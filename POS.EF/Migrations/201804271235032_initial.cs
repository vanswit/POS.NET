namespace POS.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Vendor = c.String(),
                        ProductCode = c.String(),
                        IsValid = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        IsChanged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Address_Id", c => c.Int());
            AddColumn("dbo.PurchaseLines", "Product_Id", c => c.Int());
            AddColumn("dbo.PurchaseLines", "Transaction_Id", c => c.Int());
            AddColumn("dbo.Transactions", "Customer_Id", c => c.Int());
            AddColumn("dbo.Transactions", "Payment_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Address_Id");
            CreateIndex("dbo.PurchaseLines", "Product_Id");
            CreateIndex("dbo.PurchaseLines", "Transaction_Id");
            CreateIndex("dbo.Transactions", "Customer_Id");
            CreateIndex("dbo.Transactions", "Payment_Id");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id");
            AddForeignKey("dbo.PurchaseLines", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.Transactions", "Payment_Id", "dbo.Payments", "Id");
            AddForeignKey("dbo.PurchaseLines", "Transaction_Id", "dbo.Transactions", "Id");
            DropColumn("dbo.Customers", "AddressId");
            DropColumn("dbo.PurchaseLines", "TransactionId");
            DropColumn("dbo.PurchaseLines", "ProductId");
            DropColumn("dbo.Transactions", "CustomerId");
            DropColumn("dbo.Transactions", "PaymentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "PaymentId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseLines", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseLines", "TransactionId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "AddressId", c => c.Int(nullable: false));
            DropForeignKey("dbo.PurchaseLines", "Transaction_Id", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "Payment_Id", "dbo.Payments");
            DropForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.PurchaseLines", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Transactions", new[] { "Payment_Id" });
            DropIndex("dbo.Transactions", new[] { "Customer_Id" });
            DropIndex("dbo.PurchaseLines", new[] { "Transaction_Id" });
            DropIndex("dbo.PurchaseLines", new[] { "Product_Id" });
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            DropColumn("dbo.Transactions", "Payment_Id");
            DropColumn("dbo.Transactions", "Customer_Id");
            DropColumn("dbo.PurchaseLines", "Transaction_Id");
            DropColumn("dbo.PurchaseLines", "Product_Id");
            DropColumn("dbo.Customers", "Address_Id");
            DropTable("dbo.Products");
        }
    }
}
