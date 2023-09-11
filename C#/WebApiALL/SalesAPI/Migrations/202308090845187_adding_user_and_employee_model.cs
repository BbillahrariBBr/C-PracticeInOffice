namespace SalesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_user_and_employee_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HrmEmployees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.String(),
                        Name = c.String(),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.s_User",
                c => new
                    {
                        u_ID = c.Long(nullable: false, identity: true),
                        u_LoginName = c.String(),
                        u_Password = c.String(),
                        u_Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.u_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.s_User");
            DropTable("dbo.HrmEmployees");
        }
    }
}
