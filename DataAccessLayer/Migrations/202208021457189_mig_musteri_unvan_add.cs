namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_musteri_unvan_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "M_Unvan", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musterilers", "M_Unvan");
        }
    }
}
