namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'132d1c91-0c3c-4d1e-848e-80eff851a6e0', N'admin@vidly.com', 0, N'AIy1Cs/WcblhCwScFCiiOLdJClR0YNGf8DwCoQZya3A0iSLX5BmsTeRGPaPHhELapQ==', N'1556c50d-eefa-404c-8f64-a0a0bde554c2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'52d7c18f-4eb9-4165-960b-b909852932dd', N'guest@vidly.com', 0, N'AAhQN+dsXhXS2dUPjdXV4hqj7IWA0ARjUqIrJLLw3Ut8ShPjgV3uGHXJ/M6T/SOEnw==', N'5f54c289-4e29-4ef9-85c5-b4a21cb02dba', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cadf0fa5-3a4a-45c1-955c-193953868942', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'132d1c91-0c3c-4d1e-848e-80eff851a6e0', N'cadf0fa5-3a4a-45c1-955c-193953868942')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
