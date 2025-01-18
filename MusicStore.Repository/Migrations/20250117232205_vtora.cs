using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class vtora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[] { new Guid("a84a064e-157f-4b5a-be81-9d7d4c2ba428"), "dobar muzi4ar", "Jimmy Hendrix" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a84a064e-157f-4b5a-be81-9d7d4c2ba428"));
        }
    }
}
