namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_musteri_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "M_About", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musterilers", "M_About");
        }
    }
}
