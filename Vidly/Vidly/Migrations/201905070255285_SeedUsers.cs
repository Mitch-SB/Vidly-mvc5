namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4033844d-676a-47a5-80f9-5293215dec0a', N'admin@vidly.com', 0, N'APD6xHWDLQvy+NO/pFL5YKObdy6y+jTeLTBZ/FxBe3WRlYmQqj1CUG0rVf52eB9nYQ==', N'2754921b-8a79-431f-8e4b-6fe447a3b9ef', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eb116cc8-9415-41be-bedd-5a3d1031ac6b', N'guest@vidly.com', 0, N'AEo85Y2ynXzqEx3RUJowrS88KP/Rqzbk3oiV2smJjOg7kmcv4hKavt5friboGHCwsw==', N'58b325bc-ebce-407e-9768-2bd9449c8401', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cf621af1-5eb2-4b64-abdb-004b26822333', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4033844d-676a-47a5-80f9-5293215dec0a', N'cf621af1-5eb2-4b64-abdb-004b26822333')

");

        }
        
        public override void Down()
        {
        }
    }
}
