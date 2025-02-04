using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    AlbumImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    AlbumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TrackImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tracks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPlaylists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MusicStoreApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlaylists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPlaylists_AspNetUsers_MusicStoreApplicationUserId",
                        column: x => x.MusicStoreApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserPlaylists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoughtItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoughtItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoughtItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MusicStoreApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_AspNetUsers_MusicStoreApplicationUserId",
                        column: x => x.MusicStoreApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackUserPlaylist",
                columns: table => new
                {
                    PlaylistsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TracksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackUserPlaylist", x => new { x.PlaylistsId, x.TracksId });
                    table.ForeignKey(
                        name: "FK_TrackUserPlaylist_Tracks_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackUserPlaylist_UserPlaylists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "UserPlaylists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), "One of the most influential rock bands.", "The Beatles" },
                    { new Guid("437b71ca-0899-4a88-9555-0260005d7813"), "A grunge band that shaped the 90s music scene.", "Nirvana" },
                    { new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), "A legendary rock band.", "Pink Floyd" },
                    { new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), "A rock band known for its heavy sound.", "Led Zeppelin" },
                    { new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), "A rock band known for its eclectic musical style.", "Queen" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageUrl", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0673db40-90fa-4837-9dde-e4ef2d04d655"), "https://i.discogs.com/XoAXkLe03Vk0Kt-oQqw7V9uW5nBzQdNvZd0zar5mOiQ/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2NzA4/NC0xMjYzMDk1NTUz/LmpwZWc.jpeg", new Guid("437b71ca-0899-4a88-9555-0260005d7813"), 18, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevermind" },
                    { new Guid("2b62c76c-fa0a-4d44-b031-e3a00ff0b92d"), "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg", new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), 22, new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wish You Were Here" },
                    { new Guid("6bedab31-c9aa-4c49-bfa2-cf2477ee75c5"), "https://i.discogs.com/goWfjpqUBW8Y0xrqJG_GFz3fCTHPSWeKLZAX1alAAzk/rs:fit/g:sm/q:90/h:600/w:592/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MTg2/NDQxLTE1Njk0ODcx/NjEtNzMxNC5qcGVn.jpeg", new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), 25, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbey Road" },
                    { new Guid("7126cbd8-248f-4d4a-8aa8-5208f026342a"), "https://i.discogs.com/ijIUNhH--0OKzKuKv-aLpgFkb7lr6OQVb5FcAF_aW0U/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NTk3/OS0xNDkxNzAwMzQ3/LTcyNjMuanBlZw.jpeg", new Guid("437b71ca-0899-4a88-9555-0260005d7813"), 20, new DateTime(1993, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Utero" },
                    { new Guid("7a65ebb7-1ff0-4930-b2a0-36a6c7a48790"), "https://i.discogs.com/1fwskTLM6cfxbdNmBDJ8expl6wab0tEgxvuloLIqKh8/rs:fit/g:sm/q:90/h:596/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTkyODc4/MDktMTQ3OTc1MzIz/Ni05NjE3LmpwZWc.jpeg", new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), 20, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" },
                    { new Guid("a41dfbec-fd86-4567-9e08-ddfea194a1fe"), "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg", new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), 26, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houses of the Holy" },
                    { new Guid("b0921a71-b25d-4fb7-8d2f-9e0025a2170c"), "https://i.discogs.com/HWA3uoT2xu7zj_kM-f18f02CCQNKk2W8YzUL-D_l2ZM/rs:fit/g:sm/q:90/h:581/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwODgx/MjYtMTI1Njk1MDk3/OS5qcGVn.jpeg", new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), 23, new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let It Be" },
                    { new Guid("e2bd5edd-0b4b-4b3a-9d8e-d7022faabec7"), "https://i.discogs.com/p2o5GGONaTq4jK398iU0X3KjuMfnK10_TEC_bdnKA6k/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTMzMjg5/ODItMTM1NzgxOTE3/NS05NTU3LmpwZWc.jpeg", new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), 19, new DateTime(1984, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Works" },
                    { new Guid("f120f6ef-be82-4617-97ea-0828ee628b56"), "https://i.discogs.com/yFq3X0xZMxIVHIFgmbrsPvJHXLJCfVLWs60AL4XS4bs/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg2/Ny0yNzg1LmpwZWc.jpeg", new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), 24, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led Zeppelin IV" },
                    { new Guid("f95a5849-a216-4e3e-bc09-3ba548823c95"), "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg", new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), 21, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Night at the Opera" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title", "TrackImageUrl" },
                values: new object[,]
                {
                    { new Guid("1537e6c8-b4f9-46f8-819b-1844fddf14d6"), new Guid("e2bd5edd-0b4b-4b3a-9d8e-d7022faabec7"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Tear It Up", "https://i.discogs.com/TNq6BKsREuTvVL0QtgziQ0ACcLNhKq9AjP-NYI7yo14/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ3NTU5/Ni0xNDU0NzA3NDYw/LTIxNzkuanBlZw.jpeg" },
                    { new Guid("154fc06e-4682-4756-8d74-66438ac8b6eb"), new Guid("2b62c76c-fa0a-4d44-b031-e3a00ff0b92d"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 5, 0, 0), 129, "Have a Cigar", "https://i.discogs.com/frk8i23GN3Epw5RaA-um7KwmBw0NTQiEHUYtirXaqdg/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MDgtMTIxMi5qcGVn.jpeg" },
                    { new Guid("18b65708-07dd-496e-8ae2-c3cc05c00a27"), new Guid("0673db40-90fa-4837-9dde-e4ef2d04d655"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come as You Are", "https://i.discogs.com/gIQVfX1uZI857sBz7NntFRdTCLO3eQT0o4qCiCIHnfE/rs:fit/g:sm/q:90/h:486/w:543/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc4MzIx/Ni0xNDE2ODkwNjQx/LTc3OTQuanBlZw.jpeg" },
                    { new Guid("1d6d52e1-0a22-4546-8f67-ef73762c1566"), new Guid("b0921a71-b25d-4fb7-8d2f-9e0025a2170c"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 3, 0, 0), 129, "The Long and Winding Road", "https://i.discogs.com/3C94Ivdig0n1Jyb8d_0jKoIvj54r56hYW6kb6kiM8cY/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzMw/LmpwZWc.jpeg" },
                    { new Guid("231c7dd6-06ac-4651-b9e9-1b220e635cbb"), new Guid("e2bd5edd-0b4b-4b3a-9d8e-d7022faabec7"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 4, 0, 0), 129, "It's a Hard Life", "https://i.discogs.com/gdK1Z8e8y1qZybHe6WF_NXUstJzEhHSId63nx0GS_Yo/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1OTU3/NTktMTIzMTA1Njkw/MS5qcGVn.jpeg" },
                    { new Guid("2ed49b45-c954-4f64-a624-86a4d47d6026"), new Guid("6bedab31-c9aa-4c49-bfa2-cf2477ee75c5"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come Together", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("2ee65ebd-9ede-4933-a997-5f1261e91ca3"), new Guid("2b62c76c-fa0a-4d44-b031-e3a00ff0b92d"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 13, 0, 0), 129, "Shine On You Crazy Diamond (Part I-V)", "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg" },
                    { new Guid("31d5e2a7-af0e-4963-975f-f423a806d77c"), new Guid("b0921a71-b25d-4fb7-8d2f-9e0025a2170c"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 3, 0, 0), 129, "Get Back", "https://i.discogs.com/yZ8hA52tgMGcdxfY182_OqxJIjUuzu1NvwVKxNM_Ztg/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzIw/LmpwZWc.jpeg" },
                    { new Guid("33fef7c1-f037-4d1c-a2fc-c879e75821f7"), new Guid("a41dfbec-fd86-4567-9e08-ddfea194a1fe"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 7, 0, 0), 129, "The Rain Song", "https://i.discogs.com/8wnDvfzEjV9Wc1BBxbaIIUeBhIxQ7WeFsKjdwt9hoWc/rs:fit/g:sm/q:90/h:574/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMjY2/LTY4MzkuanBlZw.jpeg" },
                    { new Guid("341f5206-a73a-40ee-a1a5-e9d795bdb84b"), new Guid("7a65ebb7-1ff0-4930-b2a0-36a6c7a48790"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 6, 0, 0), 129, "Time", "https://i.discogs.com/rCpj_7gUWtxKDPQQpoVwbrud6zN2wwyQRVFR-ZaNtFI/rs:fit/g:sm/q:90/h:380/w:577/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDU4/MS5qcGVn.jpeg" },
                    { new Guid("37c97584-e59c-48df-b2df-36022128f0ed"), new Guid("0673db40-90fa-4837-9dde-e4ef2d04d655"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 5, 0, 0), 129, "Smells Like Teen Spirit", "https://i.discogs.com/MsIpIcpdbgg0r3CYB39OlwwuT81PuQ0psUcDvRLTdUU/rs:fit/g:sm/q:90/h:528/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MzI3/OC0xMzQwMTcwNjI1/LTMwNzguanBlZw.jpeg" },
                    { new Guid("3e8c44ed-bcad-431b-85ad-a36140974f35"), new Guid("f95a5849-a216-4e3e-bc09-3ba548823c95"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Love of My Life", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("403f1da6-8357-4c81-a182-ce0233d830d3"), new Guid("7a65ebb7-1ff0-4930-b2a0-36a6c7a48790"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 1, 0, 0), 129, "Speak to Me", "https://i.discogs.com/E9E7stvIt5YKUfK_CnrpIgxchviC7Q4WCeyQuuICAjo/rs:fit/g:sm/q:90/h:397/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDYw/MC5qcGVn.jpeg" },
                    { new Guid("42a546ce-087c-4412-b346-89b2404a5b2e"), new Guid("f120f6ef-be82-4617-97ea-0828ee628b56"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 8, 0, 0), 129, "Stairway to Heaven", "https://i.discogs.com/AO-PmjrMZa3JNJ8NBErUUcDOJ2Yna2jCNLbwmZ0n9aE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc1Nzg1/NC0xNTE1ODU0Mjcx/LTM3NDUuanBlZw.jpeg" },
                    { new Guid("455c6e03-4290-450d-bf09-02621fa8c5cf"), new Guid("0673db40-90fa-4837-9dde-e4ef2d04d655"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 5, 0, 0), 129, "Lithium", "https://i.discogs.com/hjHzpqaFqgJXi12l082Z4iIDAqkooFWzQOss9XzW6LU/rs:fit/g:sm/q:90/h:600/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyOTg2/OTQtMTU4NDk2NTg5/OS03MTUyLmpwZWc.jpeg" },
                    { new Guid("530a3229-96c8-4042-8ced-3e8a246b7292"), new Guid("7a65ebb7-1ff0-4930-b2a0-36a6c7a48790"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 3, 0, 0), 129, "On the Run", "https://i.discogs.com/t4BbENT4ugUFTY-pgCqTcEHhlfwlrJeJuyTOTzqxKfM/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTcyNzc2NDky/OS03ODUzLmpwZWc.jpeg" },
                    { new Guid("557ada45-4ede-4b16-9092-b4ad411479a7"), new Guid("7a65ebb7-1ff0-4930-b2a0-36a6c7a48790"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 2, 0, 0), 129, "Breathe in the air", "https://i.discogs.com/mfba8kz9-PIwZGE5g70Z5i6JpITmeRfaXLsWClcxj8g/rs:fit/g:sm/q:90/h:500/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI4NzAw/MjYwLTE2OTgyMzg5/MDItNDY5NS5qcGVn.jpeg" },
                    { new Guid("5c7b8133-b978-4760-b764-8a75ca7383b7"), new Guid("f120f6ef-be82-4617-97ea-0828ee628b56"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 4, 0, 0), 129, "Black Dog", "https://i.discogs.com/Ok43Qrm9pIMNTCCCR5oXwL9XU_0_WxXdRl6RKeXfxBg/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/My00NDI0LmpwZWc.jpeg" },
                    { new Guid("600bb873-295b-4df3-b85a-2b578bffa911"), new Guid("a41dfbec-fd86-4567-9e08-ddfea194a1fe"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 5, 0, 0), 129, "The Song Remains the Same", "https://i.discogs.com/PGoolvGRHExppmuvEDxPETmRJAFIlpoSAZ41ws86GLw/rs:fit/g:sm/q:90/h:577/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMzA2/LTU4MzMuanBlZw.jpeg" },
                    { new Guid("68351b85-4723-46ed-adf7-c7db6175e53b"), new Guid("7126cbd8-248f-4d4a-8aa8-5208f026342a"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 3, 0, 0), 129, "Frances Farmer Will Have Her Revenge On Seattle", "https://i.discogs.com/FeGBBtykttDrTxPvdjPufzgY4HuxmQ_Yw-4F0ooQdCw/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MDE4/ODMyLTE1NjY3NjM4/MTctMzc3OS5qcGVn.jpeg" },
                    { new Guid("69b090ff-171d-4424-a109-5ebcb33df2b2"), new Guid("2b62c76c-fa0a-4d44-b031-e3a00ff0b92d"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 7, 0, 0), 129, "Welcome to the Machine", "https://i.discogs.com/a36kcqXYhsvwN7S1cyq8_CGqqyWi78u3CLtxuE86-Go/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTYtMTc3Mi5qcGVn.jpeg" },
                    { new Guid("71d2beec-591b-4e06-952f-7b3ff54c5a46"), new Guid("b0921a71-b25d-4fb7-8d2f-9e0025a2170c"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 3, 0, 0), 129, "Across the Universe", "https://i.discogs.com/KFfU_VOBY43WsttSMHMp0uUvaQ8Sk63qAoCDeTeENpE/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ1NjcxNjIy/LTM1ODYuanBlZw.jpeg" },
                    { new Guid("86863715-f532-4a4e-9fdc-4e62c7067851"), new Guid("7126cbd8-248f-4d4a-8aa8-5208f026342a"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 4, 0, 0), 129, "Pennyroyal Tea", "https://i.discogs.com/7W0cV6lsC_kWMo0sbFf1pd73ROkSNo6cpWEUHGrgdas/rs:fit/g:sm/q:90/h:462/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgyOTcz/My0xMTY1MTQ0MjEy/LmpwZWc.jpeg" },
                    { new Guid("88289a3b-1afb-4aed-a84e-97a969959514"), new Guid("7126cbd8-248f-4d4a-8aa8-5208f026342a"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 4, 0, 0), 129, "Serve the Servants", "https://i.discogs.com/mFtdd9bDwACrDsS9nQyxKcWlBY_WKlcIib_5iq0NspE/rs:fit/g:sm/q:90/h:522/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyMjc5/MzMwLTE1MzIwMzE2/OTMtOTE3OC5qcGVn.jpeg" },
                    { new Guid("9041d29c-b65e-42bd-b527-8aa4127f4151"), new Guid("f95a5849-a216-4e3e-bc09-3ba548823c95"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Death on Two Legs", "https://i.discogs.com/exLiE9TUHd1Osv4-SBjJsO8zScHQQ2s5XTA7QzvHmjk/rs:fit/g:sm/q:90/h:591/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQy/LTU2OTMuanBlZw.jpeg" },
                    { new Guid("906d8cbc-e4b3-4219-86b8-3cfdef07ba87"), new Guid("0673db40-90fa-4837-9dde-e4ef2d04d655"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 4, 0, 0), 129, "In Bloom", "https://i.discogs.com/6fsdEUC3-9WQy2tB4PmRvGcYrKPtggYbUSgD5QyZQQ4/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEzNDgz/ODctMTY4MDY3ODQ1/My05NTcwLmpwZWc.jpeg" },
                    { new Guid("9449033d-83ea-4ddd-bfc6-8a2581dbf7f5"), new Guid("b0921a71-b25d-4fb7-8d2f-9e0025a2170c"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 4, 0, 0), 129, "Let It Be", "https://i.discogs.com/hAdrrjfnT2klIYc1V_oKX5HjpJ3xElwd7FDaDydTFGo/rs:fit/g:sm/q:90/h:600/w:566/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ0NTE5Njg4/LTU0MzkuanBlZw.jpeg" },
                    { new Guid("9708bee3-4e55-473d-a74a-4134117a872f"), new Guid("e2bd5edd-0b4b-4b3a-9d8e-d7022faabec7"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 5, 0, 0), 129, "Radio Ga Ga", "https://i.discogs.com/b20JvPlll2B74GR7tMh3oSukHbeTjq3cyTBpdKk25fA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1MTU5/MTEtMTU5OTIzODcx/MS05NjI1LmpwZWc.jpeg" },
                    { new Guid("b49acbdb-456c-4057-ba59-32fb52aab890"), new Guid("e2bd5edd-0b4b-4b3a-9d8e-d7022faabec7"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 4, 0, 0), 129, "I Want to Break Free", "https://i.discogs.com/GZW57VCYRIgmdlkLRQwj_ZejpTs1lW3TiH-m5zJzvKg/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1NDU5/MDAtMTIyNzQzNTEx/NS5qcGVn.jpeg" },
                    { new Guid("c78010a7-d3b0-4dc8-896d-e6d914297de1"), new Guid("6bedab31-c9aa-4c49-bfa2-cf2477ee75c5"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 3, 0, 0), 129, "Octopus's Garden", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("cc822355-0f0b-4cf6-a6c5-a505cd15f26c"), new Guid("6bedab31-c9aa-4c49-bfa2-cf2477ee75c5"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 3, 0, 0), 129, "Here Comes the Sun", "https://i.discogs.com/qsJyhu9LR8BERwbo5DRIYdNJzZFyuxQMr3RJcnOSEkw/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgxMzcz/NTUtMTQ1NTgzODU3/My0zNDk0LmpwZWc.jpeg" },
                    { new Guid("ddb625ea-003e-410a-a965-34e753cb1ae5"), new Guid("f95a5849-a216-4e3e-bc09-3ba548823c95"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 3, 0, 0), 129, "You're My Best Friend", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("e453862a-57b8-4b19-a885-6c0348a175d3"), new Guid("f95a5849-a216-4e3e-bc09-3ba548823c95"), new Guid("d176df78-ab3e-4d82-baed-0ac92b4f0a4c"), new TimeSpan(0, 0, 6, 0, 0), 129, "Bohemian Rhapsody", "https://i.discogs.com/_RN78C49qgCxMX3CnRdxDggOCSI5P7uYaUGJ_Pl_CGM/rs:fit/g:sm/q:90/h:567/w:574/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2OTg5/MC0xMzkzMjg2NDQz/LTU3NTUuanBlZw.jpeg" },
                    { new Guid("e52c7f3d-9043-4952-861d-02cd24133e8f"), new Guid("6bedab31-c9aa-4c49-bfa2-cf2477ee75c5"), new Guid("38dc46f6-3d37-4d60-9b7b-44354f613036"), new TimeSpan(0, 0, 3, 0, 0), 129, "Something", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("e91e9662-11bc-4271-a2f2-66d7e44c4d36"), new Guid("f120f6ef-be82-4617-97ea-0828ee628b56"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 3, 0, 0), 129, "Going to California", "https://i.discogs.com/kOYbkKoJqpZfHNMg38TaBrOQmJWYO8UoRWV_BOgR6MA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg4/My02MDE1LmpwZWc.jpeg" },
                    { new Guid("ed29b179-968a-409d-baa0-34b6d72e21ad"), new Guid("a41dfbec-fd86-4567-9e08-ddfea194a1fe"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 4, 0, 0), 129, "Over the Hills and Far Away", "https://i.discogs.com/QVRkVVBO1gFfafoFfNzNps67VKs1DsGRcHQ474zEDf0/rs:fit/g:sm/q:90/h:224/w:452/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMTcxOTI0MzQz/LmpwZWc.jpeg" },
                    { new Guid("f4a42742-d5c0-42a4-bcea-2f767de2cb44"), new Guid("2b62c76c-fa0a-4d44-b031-e3a00ff0b92d"), new Guid("b21ac1be-70bb-4950-9160-32cb64068b0e"), new TimeSpan(0, 0, 5, 0, 0), 129, "Wish You Were Here", "https://i.discogs.com/hJBh2v_V6Ow6_hyPu791g1d_Pqj6_aoKB6fm_JUKUPA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MjgtNDE1My5qcGVn.jpeg" },
                    { new Guid("f9b212d4-1ffa-49b6-bc87-d0f15e59d1ac"), new Guid("a41dfbec-fd86-4567-9e08-ddfea194a1fe"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 7, 0, 0), 129, "No Quarter", "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg" },
                    { new Guid("fa5dafc0-65d2-42d1-8834-b9b6412d2f1f"), new Guid("7126cbd8-248f-4d4a-8aa8-5208f026342a"), new Guid("437b71ca-0899-4a88-9555-0260005d7813"), new TimeSpan(0, 0, 5, 0, 0), 129, "Heart-Shaped Box", "https://i.discogs.com/jvt57zTP4f1brU4p_ABs9ylQ8K6B6a0El-CFqmHRyPU/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM5MzA2/NS0xMTgyNjg0ODgz/LmpwZWc.jpeg" },
                    { new Guid("ffdc047c-267e-4536-9f94-94b7f7fd0ba4"), new Guid("f120f6ef-be82-4617-97ea-0828ee628b56"), new Guid("bc7f8cff-deb7-4d49-a9e6-6bb2d65b353f"), new TimeSpan(0, 0, 3, 0, 0), 129, "Rock and Roll", "https://i.discogs.com/aFc_fainrAcSiX2MbERPPWWlvjeYKc0D4yf53WD4rzM/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/NC00ODYwLmpwZWc.jpeg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserCartId",
                table: "AspNetUsers",
                column: "UserCartId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtItems_OrderId",
                table: "BoughtItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_MusicStoreApplicationUserId",
                table: "CartItems",
                column: "MusicStoreApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OwnerId",
                table: "Orders",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_OwnerId",
                table: "ShoppingCarts",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_ArtistId",
                table: "Tracks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackUserPlaylist_TracksId",
                table: "TrackUserPlaylist",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlaylists_MusicStoreApplicationUserId",
                table: "UserPlaylists",
                column: "MusicStoreApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlaylists_UserId",
                table: "UserPlaylists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_UserCartId",
                table: "AspNetUsers",
                column: "UserCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_OwnerId",
                table: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BoughtItems");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "TrackUserPlaylist");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserPlaylists");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");
        }
    }
}
