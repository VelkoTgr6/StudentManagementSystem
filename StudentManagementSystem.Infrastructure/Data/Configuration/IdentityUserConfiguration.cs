using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {

        private IdentityUser[] initialUsers = new IdentityUser[]
{
    new IdentityUser()
    {
        Id = "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
        UserName = "ivan414@gmail.com",
        NormalizedUserName = "IVAN414@GMAIL.COM",
        Email = "ivan414@gmail.com",
        NormalizedEmail = "IVAN414@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
        UserName = "maria270@gmail.com",
        NormalizedUserName = "MARIA270@GMAIL.COM",
        Email = "maria270@gmail.com",
        NormalizedEmail = "MARIA270@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "b65e6163-1454-4164-9869-2ff822f9da98",
        UserName = "elena309@gmail.com",
        NormalizedUserName = "ELENA309@GMAIL.COM",
        Email = "elena309@gmail.com",
        NormalizedEmail = "ELENA309@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "c5d7d80f-08d5-41ec-892c-30833098c047",
        UserName = "viktor725@gmail.com",
        NormalizedUserName = "VIKTOR725@GMAIL.COM",
        Email = "viktor725@gmail.com",
        NormalizedEmail = "VIKTOR725@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "217e3e65-026d-4a8e-97af-a4fb30dfab30",
        UserName = "pesho278@gmail.com",
        NormalizedUserName = "PESHO278@GMAIL.COM",
        Email = "pesho278@gmail.com",
        NormalizedEmail = "PESHO278@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
        UserName = "nina.borisova@gmail.com",
        NormalizedUserName = "NINA.BORISOVA@GMAIL.COM",
        Email = "nina.borisova@gmail.com",
        NormalizedEmail = "NINA.BORISOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "1a688e82-f609-47af-a359-d8bcdd62b5e9",
        UserName = "ivo.pavlov@gmail.com",
        NormalizedUserName = "IVO.PAVLOV@GMAIL.COM",
        Email = "ivo.pavlov@gmail.com",
        NormalizedEmail = "IVO.PAVLOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "01185cf1-525d-478a-ad05-b9629573333a",
        UserName = "katerina.gancheva@gmail.com",
        NormalizedUserName = "KATERINA.GANCHEVA@GMAIL.COM",
        Email = "katerina.gancheva@gmail.com",
        NormalizedEmail = "KATERINA.GANCHEVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "cab3584a-da3f-4858-a65a-3f7bde9e553f",
        UserName = "dimitar.mihailov@gmail.com",
        NormalizedUserName = "DIMITAR.MIHAILOV@GMAIL.COM",
        Email = "dimitar.mihailov@gmail.com",
        NormalizedEmail = "DIMITAR.MIHAILOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "325092c7-9882-40d9-854b-32326c2bd43b",
        UserName = "stefan.yordanov@gmail.com",
        NormalizedUserName = "STEFAN.YORDANOV@GMAIL.COM",
        Email = "stefan.yordanov@gmail.com",
        NormalizedEmail = "STEFAN.YORDANOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "2e830c43-2ce2-462d-9880-be8aa1e71696",
        UserName = "diana.ruseva@gmail.com",
        NormalizedUserName = "DIANA.RUSEVA@GMAIL.COM",
        Email = "diana.ruseva@gmail.com",
        NormalizedEmail = "DIANA.RUSEVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
        UserName = "petar.georgiev@gmail.com",
        NormalizedUserName = "PETAR.GEORGIEV@GMAIL.COM",
        Email = "petar.georgiev@gmail.com",
        NormalizedEmail = "PETAR.GEORGIEV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
        UserName = "tanya.ivanova@gmail.com",
        NormalizedUserName = "TANYA.IVANOVA@GMAIL.COM",
        Email = "tanya.ivanova@gmail.com",
        NormalizedEmail = "TANYA.IVANOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "8eb86d7d-02f7-477d-8e6f-539d7c155930",
        UserName = "aleksandar.pavlov@gmail.com",
        NormalizedUserName = "ALEKSANDAR.PAVLOV@GMAIL.COM",
        Email = "aleksandar.pavlov@gmail.com",
        NormalizedEmail = "ALEKSANDAR.PAVLOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "3034c6c5-e1f5-4655-9baf-079f41605550",
        UserName = "julia.dimitrova@gmail.com",
        NormalizedUserName = "JULIA.DIMITROVA@GMAIL.COM",
        Email = "julia.dimitrova@gmail.com",
        NormalizedEmail = "JULIA.DIMITROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "e8264a26-ea76-44c4-a013-12759599a081",
        UserName = "kiril.kolarov@gmail.com",
        NormalizedUserName = "KIRIL.KOLAROV@GMAIL.COM",
        Email = "kiril.kolarov@gmail.com",
        NormalizedEmail = "KIRIL.KOLAROV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
        UserName = "daniela.todorova@gmail.com",
        NormalizedUserName = "DANIELA.TODOROVA@GMAIL.COM",
        Email = "daniela.todorova@gmail.com",
        NormalizedEmail = "DANIELA.TODOROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
        UserName = "lazar.grigorov@gmail.com",
        NormalizedUserName = "LAZAR.GRIGOROV@GMAIL.COM",
        Email = "lazar.grigorov@gmail.com",
        NormalizedEmail = "LAZAR.GRIGOROV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "0c4b8988-22f2-4ed5-8486-85e757a97e41",
        UserName = "ivanka.nikolova@gmail.com",
        NormalizedUserName = "IVANKA.NIKOLOVA@GMAIL.COM",
        Email = "ivanka.nikolova@gmail.com",
        NormalizedEmail = "IVANKA.NIKOLOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
        UserName = "gergana.georgieva@gmail.com",
        NormalizedUserName = "GERGANA.GEORGIEVA@GMAIL.COM",
        Email = "gergana.georgieva@gmail.com",
        NormalizedEmail = "GERGANA.GEORGIEVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser
    {
        Id = "51065229-23b9-402f-a54d-00bb813d6b1c",
        UserName = "stan12@gmail.com",
        NormalizedUserName = "STAN12@GMAIL.COM",
        Email = "stan12@gmail.com",
        NormalizedEmail = "STAN12@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "6b6433a7-3564-4cba-ace2-4a44afca4177",
        UserName = "ivdra23@gmail.com",
        NormalizedUserName = "IVDRA23@GMAIL.COM",
        Email = "ivdra23@gmail.com",
        NormalizedEmail = "IVDRA23@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "331d08d0-d407-4d61-af6e-1bb134ae7998",
        UserName = "mariya.petrova@gmail.com",
        NormalizedUserName = "MARIYA.PETROVA@GMAIL.COM",
        Email = "mariya.petrova@gmail.com",
        NormalizedEmail = "MARIYA.PETROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
        UserName = "nikolai.vasilev@gmail.com",
        NormalizedUserName = "NIKOLAI.VASILEV@GMAIL.COM",
        Email = "nikolai.vasilev@gmail.com",
        NormalizedEmail = "NIKOLAI.VASILEV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
        UserName = "radoslav.ivanov@gmail.com",
        NormalizedUserName = "RADOSLAV.IVANOV@GMAIL.COM",
        Email = "radoslav.ivanov@gmail.com",
        NormalizedEmail = "RADOSLAV.IVANOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "32739a60-8250-4178-a19c-96d90444ebd3",
        UserName = "katerina.dimitrova@gmail.com",
        NormalizedUserName = "KATERINA.DIMITROVA@GMAIL.COM",
        Email = "katerina.dimitrova@gmail.com",
        NormalizedEmail = "KATERINA.DIMITROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
        UserName = "gosho.georgiev@gmail.com",
        NormalizedUserName = "GOSHO.GEORGIEV@GMAIL.COM",
        Email = "gosho.georgiev@gmail.com",
        NormalizedEmail = "GOSHO.GEORGIEV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
        UserName = "lidia.todorova@gmail.com",
        NormalizedUserName = "LIDIA.TODOROVA@GMAIL.COM",
        Email = "lidia.todorova@gmail.com",
        NormalizedEmail = "LIDIA.TODOROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
        UserName = "stefan.kovachev@gmail.com",
        NormalizedUserName = "STEFAN.KOVACHEV@GMAIL.COM",
        Email = "stefan.kovachev@gmail.com",
        NormalizedEmail = "STEFAN.KOVACHEV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
        UserName = "valentina.nikolova@gmail.com",
        NormalizedUserName = "VALENTINA.NIKOLOVA@GMAIL.COM",
        Email = "valentina.nikolova@gmail.com",
        NormalizedEmail = "VALENTINA.NIKOLOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    },
    new IdentityUser
    {
        Id = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
        UserName = "admin@admin.com",
        NormalizedUserName = "ADMIN@ADMIN.COM",
        Email = "admin@admin.com",
        NormalizedEmail = "ADMIN@ADMIN.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password123"),
        SecurityStamp = string.Empty
    }
};


        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(initialUsers);
        }
    }
}
