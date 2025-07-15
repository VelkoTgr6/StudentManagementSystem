using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private IdentityUserRole<string>[] initialUserRoles = new IdentityUserRole<string>[]
        {
            new IdentityUserRole<string> { RoleId = "1", UserId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f" }, // Administrator
            new IdentityUserRole<string> { RoleId = "2", UserId = "51065229-23b9-402f-a54d-00bb813d6b1c" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "6b6433a7-3564-4cba-ace2-4a44afca4177" },// Teacher
            new IdentityUserRole<string> { RoleId = "2", UserId = "331d08d0-d407-4d61-af6e-1bb134ae7998" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "030ddabd-7dcb-46ca-bab6-3feeae3492a8" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "291cc1a8-8f2c-4f48-a919-ff4d9692a859" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "32739a60-8250-4178-a19c-96d90444ebd3" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "04b6c6b1-5f9b-4c7a-9f42-86193c03d327" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "9ab8c775-88c0-4dc3-b11d-178c3ca2129" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "f2875100-0cf1-4b1d-ba91-1dfa38690f84" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "b65e6163-1454-4164-9869-2ff822f9da98" },  // Student
            new IdentityUserRole<string> { RoleId = "3", UserId = "c5d7d80f-08d5-41ec-892c-30833098c047" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "217e3e65-026d-4a8e-97af-a4fb30dfab30" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "8f7bca8f-059f-4750-8bfe-7def13ef37e8" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "1a688e82-f609-47af-a359-d8bcdd62b5e9" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "01185cf1-525d-478a-ad05-b9629573333a" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "cab3584a-da3f-4858-a65a-3f7bde9e553f" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "325092c7-9882-40d9-854b-32326c2bd43b" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "2e830c43-2ce2-462d-9880-be8aa1e71696" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "c64af0f1-3716-4e30-b5f7-b0c5153e2b01" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "ab696b9f-f5d2-45a0-8495-96e2d2a01acc" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "8eb86d7d-02f7-477d-8e6f-539d7c155930" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "3034c6c5-e1f5-4655-9baf-079f41605550" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "e8264a26-ea76-44c4-a013-12759599a081" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "e0e396e6-53f2-40e9-8013-664b8a8dbd46" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "0c4b8988-22f2-4ed5-8486-85e757a97e41" },
            new IdentityUserRole<string> { RoleId = "3", UserId = "3a76fd9d-a1bb-48f2-9626-1122ecf2d797" }
        };
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(initialUserRoles);
        }
    }
}
