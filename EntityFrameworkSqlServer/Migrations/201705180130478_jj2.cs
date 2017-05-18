namespace EntityFrameworkSqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jj2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "RoleId" });
            AlterColumn("dbo.Users", "RoleId", c => c.Int());
            CreateIndex("dbo.Users", "RoleId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "RoleId" });
            AlterColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "RoleId");
        }
    }
}
