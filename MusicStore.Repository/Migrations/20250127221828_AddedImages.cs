using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketInShoppingCart");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("18bb4696-614c-4d62-ae54-81f034f34283"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("1a770b5c-a143-4b79-abcf-48352fb68abf"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("adc79403-3483-448d-9b4e-5fdf8f268fbc"));

            migrationBuilder.AddColumn<string>(
                name: "TrackImageUrl",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlbumImageUrl",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[] { new Guid("bc3227f1-3dc7-4e88-9daa-8f54efc22e74"), "A legendary rock band.", "Pink Floyd" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageUrl", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[] { new Guid("bbb30868-029c-480e-b3a5-af14d0089215"), null, new Guid("bc3227f1-3dc7-4e88-9daa-8f54efc22e74"), 0, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title", "TrackImageUrl" },
                values: new object[] { new Guid("e3406ef3-62a6-4583-87da-e6cea5df3beb"), new Guid("bbb30868-029c-480e-b3a5-af14d0089215"), new Guid("bc3227f1-3dc7-4e88-9daa-8f54efc22e74"), new TimeSpan(0, 0, 3, 0, 0), 0, "Stoned", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e3406ef3-62a6-4583-87da-e6cea5df3beb"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("bbb30868-029c-480e-b3a5-af14d0089215"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("bc3227f1-3dc7-4e88-9daa-8f54efc22e74"));

            migrationBuilder.DropColumn(
                name: "TrackImageUrl",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "AlbumImageUrl",
                table: "Albums");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketInShoppingCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MusicStoreApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketInShoppingCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketInShoppingCart_AspNetUsers_MusicStoreApplicationUserId",
                        column: x => x.MusicStoreApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TicketInShoppingCart_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketInShoppingCart_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[] { new Guid("adc79403-3483-448d-9b4e-5fdf8f268fbc"), "A legendary rock band.", "Pink Floyd" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[] { new Guid("1a770b5c-a143-4b79-abcf-48352fb68abf"), new Guid("adc79403-3483-448d-9b4e-5fdf8f268fbc"), 0, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title" },
                values: new object[] { new Guid("18bb4696-614c-4d62-ae54-81f034f34283"), new Guid("1a770b5c-a143-4b79-abcf-48352fb68abf"), new Guid("adc79403-3483-448d-9b4e-5fdf8f268fbc"), new TimeSpan(0, 0, 3, 0, 0), 0, "Stoned" });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_OrderId",
                table: "Ticket",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TrackId",
                table: "Ticket",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketInShoppingCart_MusicStoreApplicationUserId",
                table: "TicketInShoppingCart",
                column: "MusicStoreApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketInShoppingCart_ShoppingCartId",
                table: "TicketInShoppingCart",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketInShoppingCart_TicketId",
                table: "TicketInShoppingCart",
                column: "TicketId");
        }
    }
}
