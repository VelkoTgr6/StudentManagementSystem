using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private IdentityRole [] initialRoles = new IdentityRole[]
        {
            new IdentityRole () {Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
            new IdentityRole {Id = "2", Name = "Teacher", NormalizedName = "TEACHER" },
            new IdentityRole {Id = "3", Name = "Student", NormalizedName = "STUDENT" }
        };
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[0].Id,
                UserId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "51065229-23b9-402f-a54d-00bb813d6b1c"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "6b6433a7-3564-4cba-ace2-4a44afca4177"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "331d08d0-d407-4d61-af6e-1bb134ae7998"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "030ddabd-7dcb-46ca-bab6-3feeae3492a8"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "291cc1a8-8f2c-4f48-a919-ff4d9692a859"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "32739a60-8250-4178-a19c-96d90444ebd3"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "04b6c6b1-5f9b-4c7a-9f42-86193c03d327"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "9ab8c775-88c0-4dc3-b11d-178c3ca2129"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "f2875100-0cf1-4b1d-ba91-1dfa38690f84"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "b65e6163-1454-4164-9869-2ff822f9da98"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "c5d7d80f-08d5-41ec-892c-30833098c047"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "217e3e65-026d-4a8e-97af-a4fb30dfab30"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "8f7bca8f-059f-4750-8bfe-7def13ef37e8"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "1a688e82-f609-47af-a359-d8bcdd62b5e9"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "01185cf1-525d-478a-ad05-b9629573333a"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "cab3584a-da3f-4858-a65a-3f7bde9e553f"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "325092c7-9882-40d9-854b-32326c2bd43b"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "2e830c43-2ce2-462d-9880-be8aa1e71696"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "c64af0f1-3716-4e30-b5f7-b0c5153e2b01"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "ab696b9f-f5d2-45a0-8495-96e2d2a01acc"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "8eb86d7d-02f7-477d-8e6f-539d7c155930"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "3034c6c5-e1f5-4655-9baf-079f41605550"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "e8264a26-ea76-44c4-a013-12759599a081"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "e0e396e6-53f2-40e9-8013-664b8a8dbd46"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "0c4b8988-22f2-4ed5-8486-85e757a97e41"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "3a76fd9d-a1bb-48f2-9626-1122ecf2d797"
            });
        }
    }
}
