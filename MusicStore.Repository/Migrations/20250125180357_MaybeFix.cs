using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MaybeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("24f762b8-3432-4c82-ab2f-8b373788ef8d"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("82ae6f0d-dfdc-4086-8611-3b1aa334b411"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("3ec493ca-e1b5-487f-85c9-132babe9df0a"));

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[] { new Guid("4b2db0e3-d0fd-4eb3-9600-1de2d345a25b"), "A legendary rock band.", "Pink Floyd" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[] { new Guid("1cb92525-5ebc-424d-a330-ffb9b9cb3b53"), new Guid("4b2db0e3-d0fd-4eb3-9600-1de2d345a25b"), 0, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title" },
                values: new object[] { new Guid("3fd18036-226f-40b6-a69e-9f079f6aab67"), new Guid("1cb92525-5ebc-424d-a330-ffb9b9cb3b53"), new Guid("4b2db0e3-d0fd-4eb3-9600-1de2d345a25b"), new TimeSpan(0, 0, 3, 0, 0), 0, "Stoned" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3fd18036-226f-40b6-a69e-9f079f6aab67"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("1cb92525-5ebc-424d-a330-ffb9b9cb3b53"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("4b2db0e3-d0fd-4eb3-9600-1de2d345a25b"));

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[] { new Guid("3ec493ca-e1b5-487f-85c9-132babe9df0a"), "A legendary rock band.", "Pink Floyd" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[] { new Guid("82ae6f0d-dfdc-4086-8611-3b1aa334b411"), new Guid("3ec493ca-e1b5-487f-85c9-132babe9df0a"), 0, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title" },
                values: new object[] { new Guid("24f762b8-3432-4c82-ab2f-8b373788ef8d"), new Guid("82ae6f0d-dfdc-4086-8611-3b1aa334b411"), new Guid("3ec493ca-e1b5-487f-85c9-132babe9df0a"), new TimeSpan(0, 0, 3, 0, 0), 0, "Stoned" });
        }
    }
}
