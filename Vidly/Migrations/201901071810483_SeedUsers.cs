namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5667fa42-19ab-4ebb-bf8a-40be389e4035', N'guest@vidly.com', 0, N'ALeTJ2vLNH17TWNgTI3ufkELmAuiFIdMM+Qaxacxn57hrSddCsfqZDAsgqKv+TCVaQ==', N'd741d351-ca6e-43b4-8637-1dc135427725', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e0b8ff1b-d0ed-4356-b58c-27f3079581ea', N'admin@vidly.com', 0, N'ALNC8jIMjjN9T2r1V5pywujB2I+JWqhftPxRU3ywkfO4jqFKk+4ma+Zf56fSkNPQxA==', N'ebe36714-dcbd-4af6-bc6b-f3e0f544f098', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'39569b58-ce5e-4c81-9e76-3125beefd154', N'CanManageMovies')
");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e0b8ff1b-d0ed-4356-b58c-27f3079581ea', N'39569b58-ce5e-4c81-9e76-3125beefd154')
");
        }
        
        public override void Down()
        {
        }
    }
}
