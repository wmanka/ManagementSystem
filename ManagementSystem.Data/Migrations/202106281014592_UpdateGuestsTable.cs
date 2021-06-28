namespace ManagementSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGuestsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "PhoneNumber", c => c.String());
            AddColumn("dbo.Guests", "Address", c => c.String());
            AddColumn("dbo.Guests", "City", c => c.String());
            AlterColumn("dbo.GuestsReservations", "ReservationId", c => c.Int(nullable: false));
            AlterColumn("dbo.GuestsReservations", "GuestId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GuestsReservations", "GuestId", c => c.Int(nullable: false));
            AlterColumn("dbo.GuestsReservations", "ReservationId", c => c.Int(nullable: false));
            DropColumn("dbo.Guests", "City");
            DropColumn("dbo.Guests", "Address");
            DropColumn("dbo.Guests", "PhoneNumber");
        }
    }
}
