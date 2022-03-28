namespace _1911065165_HoChiCong_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledColumntoCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
