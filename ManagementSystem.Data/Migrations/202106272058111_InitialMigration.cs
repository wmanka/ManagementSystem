namespace ManagementSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        BirthDate = c.DateTime(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10),
                        CreatedAt = c.DateTime(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.String(nullable: false),
                        CommissionFee = c.Decimal(precision: 18, scale: 2),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GuestsReservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false),
                        GuestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReservationId, t.GuestId })
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Guests", t => t.GuestId, cascadeDelete: true)
                .Index(t => t.ReservationId)
                .Index(t => t.GuestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GuestsReservations", "GuestId", "dbo.Guests");
            DropForeignKey("dbo.GuestsReservations", "ReservationId", "dbo.Reservations");
            DropIndex("dbo.GuestsReservations", new[] { "GuestId" });
            DropIndex("dbo.GuestsReservations", new[] { "ReservationId" });
            DropTable("dbo.GuestsReservations");
            DropTable("dbo.Reservations");
            DropTable("dbo.Guests");
        }
    }
}
