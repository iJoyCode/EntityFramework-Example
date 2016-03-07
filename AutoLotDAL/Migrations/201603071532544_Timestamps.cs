using System.Data.Entity.Migrations;

namespace AutoLotDAL.Migrations
{
    public partial class Timestamps : DbMigration
    {
        public override void Up()
        {
            RenameTable("dbo.Inventories", "Inventory");
            AddColumn("dbo.CreditRisks", "Timestamp",
                c => c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Customers", "Timestamp",
                c => c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Orders", "Timestamp",
                c => c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Inventory", "Timestamp",
                c => c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            CreateIndex("dbo.CreditRisks", new[] {"LastName", "FirstName"}, true, "IDX_CreditRisk_Name");
        }

        public override void Down()
        {
            DropIndex("dbo.CreditRisks", "IDX_CreditRisk_Name");
            DropColumn("dbo.Inventory", "Timestamp");
            DropColumn("dbo.Orders", "Timestamp");
            DropColumn("dbo.Customers", "Timestamp");
            DropColumn("dbo.CreditRisks", "Timestamp");
            RenameTable("dbo.Inventory", "Inventories");
        }
    }
}