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
        Id = "1",
        UserName = "ivan414@gmail.com",
        NormalizedUserName = "IVAN414@GMAIL.COM",
        Email = "ivan414@gmail.com",
        NormalizedEmail = "IVAN414@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "2",
        UserName = "maria270@gmail.com",
        NormalizedUserName = "MARIA270@GMAIL.COM",
        Email = "maria270@gmail.com",
        NormalizedEmail = "MARIA270@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "3",
        UserName = "elena309@gmail.com",
        NormalizedUserName = "ELENA309@GMAIL.COM",
        Email = "elena309@gmail.com",
        NormalizedEmail = "ELENA309@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "4",
        UserName = "viktor725@gmail.com",
        NormalizedUserName = "VIKTOR725@GMAIL.COM",
        Email = "viktor725@gmail.com",
        NormalizedEmail = "VIKTOR725@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "5",
        UserName = "pesho278@gmail.com",
        NormalizedUserName = "PESHO278@GMAIL.COM",
        Email = "pesho278@gmail.com",
        NormalizedEmail = "PESHO278@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "6",
        UserName = "nina.borisova@gmail.com",
        NormalizedUserName = "NINA.BORISOVA@GMAIL.COM",
        Email = "nina.borisova@gmail.com",
        NormalizedEmail = "NINA.BORISOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "7",
        UserName = "ivo.pavlov@gmail.com",
        NormalizedUserName = "IVO.PAVLOV@GMAIL.COM",
        Email = "ivo.pavlov@gmail.com",
        NormalizedEmail = "IVO.PAVLOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "8",
        UserName = "katerina.gancheva@gmail.com",
        NormalizedUserName = "KATERINA.GANCHEVA@GMAIL.COM",
        Email = "katerina.gancheva@gmail.com",
        NormalizedEmail = "KATERINA.GANCHEVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "9",
        UserName = "dimitar.mihailov@gmail.com",
        NormalizedUserName = "DIMITAR.MIHAILOV@GMAIL.COM",
        Email = "dimitar.mihailov@gmail.com",
        NormalizedEmail = "DIMITAR.MIHAILOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "10",
        UserName = "stefan.yordanov@gmail.com",
        NormalizedUserName = "STEFAN.YORDANOV@GMAIL.COM",
        Email = "stefan.yordanov@gmail.com",
        NormalizedEmail = "STEFAN.YORDANOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "11",
        UserName = "diana.ruseva@gmail.com",
        NormalizedUserName = "DIANA.RUSEVA@GMAIL.COM",
        Email = "diana.ruseva@gmail.com",
        NormalizedEmail = "DIANA.RUSEVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "12",
        UserName = "petar.georgiev@gmail.com",
        NormalizedUserName = "PETAR.GEORGIEV@GMAIL.COM",
        Email = "petar.georgiev@gmail.com",
        NormalizedEmail = "PETAR.GEORGIEV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "13",
        UserName = "tanya.ivanova@gmail.com",
        NormalizedUserName = "TANYA.IVANOVA@GMAIL.COM",
        Email = "tanya.ivanova@gmail.com",
        NormalizedEmail = "TANYA.IVANOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "14",
        UserName = "aleksandar.pavlov@gmail.com",
        NormalizedUserName = "ALEKSANDAR.PAVLOV@GMAIL.COM",
        Email = "aleksandar.pavlov@gmail.com",
        NormalizedEmail = "ALEKSANDAR.PAVLOV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "15",
        UserName = "julia.dimitrova@gmail.com",
        NormalizedUserName = "JULIA.DIMITROVA@GMAIL.COM",
        Email = "julia.dimitrova@gmail.com",
        NormalizedEmail = "JULIA.DIMITROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "16",
        UserName = "kiril.kolarov@gmail.com",
        NormalizedUserName = "KIRIL.KOLAROV@GMAIL.COM",
        Email = "kiril.kolarov@gmail.com",
        NormalizedEmail = "KIRIL.KOLAROV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "17",
        UserName = "daniela.todorova@gmail.com",
        NormalizedUserName = "DANIELA.TODOROVA@GMAIL.COM",
        Email = "daniela.todorova@gmail.com",
        NormalizedEmail = "DANIELA.TODOROVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "18",
        UserName = "lazar.grigorov@gmail.com",
        NormalizedUserName = "LAZAR.GRIGOROV@GMAIL.COM",
        Email = "lazar.grigorov@gmail.com",
        NormalizedEmail = "LAZAR.GRIGOROV@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "19",
        UserName = "ivanka.nikolova@gmail.com",
        NormalizedUserName = "IVANKA.NIKOLOVA@GMAIL.COM",
        Email = "ivanka.nikolova@gmail.com",
        NormalizedEmail = "IVANKA.NIKOLOVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser()
    {
        Id = "20",
        UserName = "gergana.georgieva@gmail.com",
        NormalizedUserName = "GERGANA.GEORGIEVA@GMAIL.COM",
        Email = "gergana.georgieva@gmail.com",
        NormalizedEmail = "GERGANA.GEORGIEVA@GMAIL.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!")
    },
    new IdentityUser
                {
                    Id = "21",
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
                    Id = "22",
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
                    Id = "23",
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
                    Id = "24",
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
                    Id = "25",
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
                    Id = "26",
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
                    Id = "27",
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
                    Id = "28",
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
                    Id = "29",
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
                    Id = "30",
                    UserName = "valentina.nikolova@gmail.com",
                    NormalizedUserName = "VALENTINA.NIKOLOVA@GMAIL.COM",
                    Email = "valentina.nikolova@gmail.com",
                    NormalizedEmail = "VALENTINA.NIKOLOVA@GMAIL.COM",
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
