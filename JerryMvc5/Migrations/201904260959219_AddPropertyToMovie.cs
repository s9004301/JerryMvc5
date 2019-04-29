namespace JerryMvc5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "RealeaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "RealeaseDate");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
