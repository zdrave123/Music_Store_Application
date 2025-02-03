using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    { new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), "A grunge band that shaped the 90s music scene.", "Nirvana" },
                    { new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), "A legendary rock band.", "Pink Floyd" },
                    { new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), "A rock band known for its heavy sound.", "Led Zeppelin" },
                    { new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), "One of the most influential rock bands.", "The Beatles" },
                    { new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), "A rock band known for its eclectic musical style.", "Queen" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageUrl", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("11736c81-a365-4180-8e69-e0f30d879292"), null, new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), 0, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevermind" },
                    { new Guid("1c489fd7-4c49-40f6-9e6b-bce173392ef8"), null, new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), 0, new DateTime(1984, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Works" },
                    { new Guid("59a56f50-b7b5-414e-922a-c5c10d711178"), null, new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), 0, new DateTime(1993, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Utero" },
                    { new Guid("658c1f4a-8a65-4c77-ae64-144f2800d63d"), null, new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), 0, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbey Road" },
                    { new Guid("766c6a1d-47b0-4bed-b442-4cba9b41214e"), null, new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), 0, new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let It Be" },
                    { new Guid("7720b25f-098b-4f2b-9d51-3efc438afaa9"), null, new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), 0, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" },
                    { new Guid("923cd445-3505-49e7-827f-3f8b00e0955a"), null, new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), 0, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led Zeppelin IV" },
                    { new Guid("d444d49e-54f7-49e0-8e42-42aba82e5885"), null, new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), 0, new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wish You Were Here" },
                    { new Guid("f662dfc9-2ac2-4ab2-ac6c-478eb6aade13"), null, new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), 0, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Night at the Opera" },
                    { new Guid("fe478981-ecfe-484f-9e56-1e2b5c94a4ea"), null, new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), 0, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houses of the Holy" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title", "TrackImageUrl" },
                values: new object[,]
                {
                    { new Guid("0caddb2b-4393-4b63-9a4d-8a5557bc371f"), new Guid("59a56f50-b7b5-414e-922a-c5c10d711178"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 4, 0, 0), 0, "Pennyroyal Tea", null },
                    { new Guid("0ea5de95-c3af-41fe-aae9-9c992dee2508"), new Guid("59a56f50-b7b5-414e-922a-c5c10d711178"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 3, 0, 0), 0, "Rape Me", null },
                    { new Guid("18135237-f725-4646-87ad-0dda91cc15b3"), new Guid("1c489fd7-4c49-40f6-9e6b-bce173392ef8"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 5, 0, 0), 0, "Radio Ga Ga", null },
                    { new Guid("1c3bdf8a-993a-49ff-a819-52748e2dce44"), new Guid("766c6a1d-47b0-4bed-b442-4cba9b41214e"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 3, 0, 0), 0, "Across the Universe", null },
                    { new Guid("2488a043-9d71-47af-8ea7-1036407a616d"), new Guid("d444d49e-54f7-49e0-8e42-42aba82e5885"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 13, 0, 0), 0, "Shine On You Crazy Diamond (Part I-V)", null },
                    { new Guid("2859f58f-54a3-475d-832d-bcfdb0cf6ea4"), new Guid("1c489fd7-4c49-40f6-9e6b-bce173392ef8"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 3, 0, 0), 0, "Tear It Up", null },
                    { new Guid("2bf7ca81-f83b-49a3-ae2d-5f150219ba83"), new Guid("7720b25f-098b-4f2b-9d51-3efc438afaa9"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 3, 0, 0), 0, "On the Run", null },
                    { new Guid("2dd140b5-bd55-42ea-9ca2-7101b27eace0"), new Guid("7720b25f-098b-4f2b-9d51-3efc438afaa9"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 6, 0, 0), 0, "Time", null },
                    { new Guid("362478b1-624f-469f-8643-ef88fbad15f5"), new Guid("658c1f4a-8a65-4c77-ae64-144f2800d63d"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 4, 0, 0), 0, "Come Together", null },
                    { new Guid("400ce2b6-2fb5-4e1f-b84a-a087692f37ab"), new Guid("1c489fd7-4c49-40f6-9e6b-bce173392ef8"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 4, 0, 0), 0, "I Want to Break Free", null },
                    { new Guid("4d525fe7-e9a0-4be3-b63c-e9a16d11a8af"), new Guid("923cd445-3505-49e7-827f-3f8b00e0955a"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 3, 0, 0), 0, "Going to California", null },
                    { new Guid("59e357fd-4792-4dec-9237-fd63ef5e48c3"), new Guid("7720b25f-098b-4f2b-9d51-3efc438afaa9"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 1, 0, 0), 0, "Speak to Me", null },
                    { new Guid("5dd56936-507b-40ce-bbf1-aed551f9676f"), new Guid("f662dfc9-2ac2-4ab2-ac6c-478eb6aade13"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 3, 0, 0), 0, "You're My Best Friend", null },
                    { new Guid("5f1b9f1d-8f6d-4714-ad8a-7d19b16abac0"), new Guid("11736c81-a365-4180-8e69-e0f30d879292"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 4, 0, 0), 0, "Come as You Are", null },
                    { new Guid("5fcecc16-2972-448e-ab14-fb2b593760e4"), new Guid("658c1f4a-8a65-4c77-ae64-144f2800d63d"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 3, 0, 0), 0, "Octopus's Garden", null },
                    { new Guid("62f54ee2-9d5d-4e8d-a56e-12aa8e4ec47e"), new Guid("7720b25f-098b-4f2b-9d51-3efc438afaa9"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 2, 0, 0), 0, "Breathe", null },
                    { new Guid("6a999db4-db0a-4bae-ba29-3278b101f5f9"), new Guid("d444d49e-54f7-49e0-8e42-42aba82e5885"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 5, 0, 0), 0, "Wish You Were Here", null },
                    { new Guid("835ecdac-45d0-40cb-b0d5-0b5c88956f96"), new Guid("1c489fd7-4c49-40f6-9e6b-bce173392ef8"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 4, 0, 0), 0, "It's a Hard Life", null },
                    { new Guid("8b8cb4dd-7933-4c65-90f2-05ded22c3a88"), new Guid("fe478981-ecfe-484f-9e56-1e2b5c94a4ea"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 7, 0, 0), 0, "No Quarter", null },
                    { new Guid("8dcf8189-c7fb-4816-bb51-9f1439d260dd"), new Guid("658c1f4a-8a65-4c77-ae64-144f2800d63d"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 3, 0, 0), 0, "Here Comes the Sun", null },
                    { new Guid("90ab6cbc-3034-4cd2-8f6c-0a9bc18e952b"), new Guid("fe478981-ecfe-484f-9e56-1e2b5c94a4ea"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 7, 0, 0), 0, "The Rain Song", null },
                    { new Guid("a2b78639-841b-4e19-944f-fcc9d8499bef"), new Guid("f662dfc9-2ac2-4ab2-ac6c-478eb6aade13"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 3, 0, 0), 0, "Love of My Life", null },
                    { new Guid("ab8da9c4-ac4a-4585-bd6f-1d8a2e78d817"), new Guid("658c1f4a-8a65-4c77-ae64-144f2800d63d"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 3, 0, 0), 0, "Something", null },
                    { new Guid("aca5af7d-1f5b-4bd5-bc58-509e05d1a9c6"), new Guid("d444d49e-54f7-49e0-8e42-42aba82e5885"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 5, 0, 0), 0, "Have a Cigar", null },
                    { new Guid("ad46e0b1-f283-4a31-a303-dcd348850259"), new Guid("f662dfc9-2ac2-4ab2-ac6c-478eb6aade13"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 6, 0, 0), 0, "Bohemian Rhapsody", null },
                    { new Guid("aee6ce12-3da1-4eeb-8638-89d97d00ae18"), new Guid("59a56f50-b7b5-414e-922a-c5c10d711178"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 4, 0, 0), 0, "Serve the Servants", null },
                    { new Guid("b0c5a2e1-2769-4120-83e6-6bc1aff0fc7b"), new Guid("fe478981-ecfe-484f-9e56-1e2b5c94a4ea"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 5, 0, 0), 0, "The Song Remains the Same", null },
                    { new Guid("b21205e3-16b7-406d-b00f-14684889f4f3"), new Guid("f662dfc9-2ac2-4ab2-ac6c-478eb6aade13"), new Guid("b0501ae4-2e0b-4da5-b322-836c51e3361f"), new TimeSpan(0, 0, 3, 0, 0), 0, "Death on Two Legs", null },
                    { new Guid("b7ce4b70-65ab-497b-b154-8c069f75aa4e"), new Guid("923cd445-3505-49e7-827f-3f8b00e0955a"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 4, 0, 0), 0, "Black Dog", null },
                    { new Guid("c72bf882-1f5a-4b2c-974f-5a42de06069b"), new Guid("923cd445-3505-49e7-827f-3f8b00e0955a"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 8, 0, 0), 0, "Stairway to Heaven", null },
                    { new Guid("d7a5e7f6-0492-44b7-92fc-8d83e37abb4d"), new Guid("d444d49e-54f7-49e0-8e42-42aba82e5885"), new Guid("2c2934a5-114c-4293-b00b-9742d6c784f5"), new TimeSpan(0, 0, 7, 0, 0), 0, "Welcome to the Machine", null },
                    { new Guid("d7ccf7b2-4ce6-43fb-a1f8-cedb51edbcd3"), new Guid("11736c81-a365-4180-8e69-e0f30d879292"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 5, 0, 0), 0, "Lithium", null },
                    { new Guid("e128daa2-4487-4d1d-ac0c-b696a8e2a8d8"), new Guid("923cd445-3505-49e7-827f-3f8b00e0955a"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 3, 0, 0), 0, "Rock and Roll", null },
                    { new Guid("e2572102-ece7-4ac0-b1b2-772dd034d155"), new Guid("11736c81-a365-4180-8e69-e0f30d879292"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 5, 0, 0), 0, "Smells Like Teen Spirit", null },
                    { new Guid("e2a276df-2efa-4c60-9db7-bc029c57e701"), new Guid("766c6a1d-47b0-4bed-b442-4cba9b41214e"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 4, 0, 0), 0, "Let It Be", null },
                    { new Guid("e6e6db57-b32b-47a7-ac5c-0980365c1345"), new Guid("766c6a1d-47b0-4bed-b442-4cba9b41214e"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 3, 0, 0), 0, "Get Back", null },
                    { new Guid("e9997d92-c6b0-4b95-9702-7b92478772fb"), new Guid("11736c81-a365-4180-8e69-e0f30d879292"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 4, 0, 0), 0, "In Bloom", null },
                    { new Guid("ef8ae4b8-e446-427d-959b-fbbb41020d54"), new Guid("59a56f50-b7b5-414e-922a-c5c10d711178"), new Guid("26b70215-3f31-4e29-b2bd-a9033afff2c8"), new TimeSpan(0, 0, 5, 0, 0), 0, "Heart-Shaped Box", null },
                    { new Guid("f83d6f6f-5347-4c11-8455-a17ce3c51f6e"), new Guid("766c6a1d-47b0-4bed-b442-4cba9b41214e"), new Guid("ad25130f-f705-4525-83f9-52f88c94bb8a"), new TimeSpan(0, 0, 3, 0, 0), 0, "The Long and Winding Road", null },
                    { new Guid("f8688bc2-b394-479b-8be0-8a5dfc3ab3f2"), new Guid("fe478981-ecfe-484f-9e56-1e2b5c94a4ea"), new Guid("4c9ca14a-fc48-4c72-bc0e-53b1bf70b917"), new TimeSpan(0, 0, 4, 0, 0), 0, "Over the Hills and Far Away", null }
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
