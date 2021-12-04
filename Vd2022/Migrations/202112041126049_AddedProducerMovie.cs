namespace Vd2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProducerMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Producer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Producer");
        }
    }
}
