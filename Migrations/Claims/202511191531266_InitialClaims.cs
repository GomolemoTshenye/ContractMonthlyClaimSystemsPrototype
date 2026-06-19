namespace ContractMonthlyClaimSystemsPrototype.Migrations.Claims
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialClaims : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(),
                        Month = c.String(nullable: false),
                        HoursWorked = c.Double(nullable: false),
                        HourlyRate = c.Double(nullable: false),
                        DocumentPath = c.String(),
                        AdditionalNotes = c.String(),
                        Status = c.String(),
                        SubmissionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Claims");
        }
    }
}
