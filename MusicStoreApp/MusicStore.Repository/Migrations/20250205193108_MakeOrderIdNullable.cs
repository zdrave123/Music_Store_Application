using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MakeOrderIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0e191fdb-60b1-4ed3-be63-3d3a2cf873ae"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("126eda42-d6ae-4eaa-b5bd-f679e0dfb232"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("227fad2d-aee0-48c8-b10e-827b3ee96bc4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("23bec2de-d42b-4b2e-a5a3-e3bf961cba5d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("291ce4f6-8db4-4098-bfcc-6083855859eb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2e5ea6be-e58b-4182-b23f-c5aef0997a7b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("326cdf69-5b62-412b-9414-28fd6ae6f0ed"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("34fd5e9c-6adb-4f13-aca9-d4127fa3b5f7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("44643fa2-43cb-418b-b40f-635326fd53bd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4a0278bf-7d05-4141-b618-2bf4da8ae7a6"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4ea30dc8-40c2-4ad2-ab20-02f460250318"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("52f0255f-070a-45a5-b26c-f53cdce6a519"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("585ae788-c59f-44da-9562-a8d075efba54"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("58ffcd2a-17ae-4589-9ca6-7eeb1528b5bd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("59b7e1f3-7c71-4b8a-b80c-5eef2bdb19fd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("59d1e554-07cb-4e9a-8f71-bbc0e3b75627"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6aeb51b0-f1b4-4823-90ba-28416a8ce1ea"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7647b0fe-7089-4521-a350-6355f88e7aea"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("78e65fe0-c016-4d02-a1cb-b5b36dd18bad"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("87146a48-95fd-4b3d-aa77-d0817eb09854"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("884de3cf-5e51-457d-83e9-cfb95e37c2a8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("96229957-8617-4863-89ec-6da73cf4d164"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9ff0170e-ea9c-4faa-b369-bd9583d25705"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("adfdeb6b-c954-4f2d-ac00-adc010c3c168"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("af40ac5c-aca5-4470-8756-3f1372c97cb5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b70b210d-6235-4e98-9e9a-bab0625f162a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bd801c05-7f35-4992-b439-634d6b3f0cca"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bdc9c004-8088-40a7-b151-c5c0cb83922c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("be238550-1b70-4d33-8610-bf92bbb10139"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c12aac4a-c955-4bae-a531-1f9113ce0fec"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d65256df-b0d3-4824-9ede-f49b0007cf4c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d68102e8-a433-4b41-ab21-1f77246cce86"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("dc2f9861-4e0c-46aa-9e3d-b9460de64d6c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e397b37c-bed7-4cf8-946a-54876e75e0ad"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f0ea87c2-af87-47ec-9792-e2dcce62b532"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f2a6d8ef-6c6a-4150-9e34-1da2162b5f75"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f99742bc-0ed1-4c71-a3bb-20598e7f38fa"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fd62f17a-c23c-4a09-b40f-57a7f7c45cf6"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ff310da1-2f05-4df6-9a52-431e1555ccb9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fff5dd38-f443-4729-b9ec-7db917ba56d3"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("12c850aa-c450-4af7-bb7b-7e98d5ce4956"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("528c1b7a-008b-4e91-9c5d-81f0a6709a53"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("a35a51d6-87a1-4989-a806-08494acf98e8"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("a6968856-eb50-49ed-9e5a-878bcc47361d"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("cffaea35-dd5a-4a27-aab1-b57c2be9743f"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("d1376baa-a7b0-4967-9064-1a6b375e8e80"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("e544c543-0017-44cf-aa2e-b300208c4d4e"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("ec9d3f10-5139-4c12-944b-25da7c55742a"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("eccc5564-1c78-4f64-8df6-7bef07339902"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("fbdf9ad3-5d89-4f09-b19b-a1fc90977ac6"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("619a35b5-9004-46af-af82-a3bbd948c719"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "BoughtItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), "One of the most influential rock bands.", "The Beatles" },
                    { new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), "A legendary rock band.", "Pink Floyd" },
                    { new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), "A grunge band that shaped the 90s music scene.", "Nirvana" },
                    { new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), "A rock band known for its heavy sound.", "Led Zeppelin" },
                    { new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), "A rock band known for its eclectic musical style.", "Queen" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageUrl", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("419550b0-477c-4c2d-8b5d-35b558e991ec"), "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg", new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), 26, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houses of the Holy" },
                    { new Guid("46deccd7-bed4-4133-ac66-aee3114e2cca"), "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg", new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), 21, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Night at the Opera" },
                    { new Guid("5430f5cf-b38c-4ecc-9d22-60aee1796f28"), "https://i.discogs.com/HWA3uoT2xu7zj_kM-f18f02CCQNKk2W8YzUL-D_l2ZM/rs:fit/g:sm/q:90/h:581/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwODgx/MjYtMTI1Njk1MDk3/OS5qcGVn.jpeg", new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), 23, new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let It Be" },
                    { new Guid("601ec9ef-1931-43a4-ae83-04b773ebca1c"), "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg", new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), 22, new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wish You Were Here" },
                    { new Guid("69035498-9180-4ac2-a29f-8bf1cef30fec"), "https://i.discogs.com/yFq3X0xZMxIVHIFgmbrsPvJHXLJCfVLWs60AL4XS4bs/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg2/Ny0yNzg1LmpwZWc.jpeg", new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), 24, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led Zeppelin IV" },
                    { new Guid("7140cf95-b56c-4041-a9ed-aba960bdc255"), "https://i.discogs.com/XoAXkLe03Vk0Kt-oQqw7V9uW5nBzQdNvZd0zar5mOiQ/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2NzA4/NC0xMjYzMDk1NTUz/LmpwZWc.jpeg", new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), 18, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevermind" },
                    { new Guid("73970e5d-b375-4537-9001-196c51cf9110"), "https://i.discogs.com/ijIUNhH--0OKzKuKv-aLpgFkb7lr6OQVb5FcAF_aW0U/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NTk3/OS0xNDkxNzAwMzQ3/LTcyNjMuanBlZw.jpeg", new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), 20, new DateTime(1993, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Utero" },
                    { new Guid("9a1c6833-4a8c-4158-b204-201ddbcb04c0"), "https://i.discogs.com/goWfjpqUBW8Y0xrqJG_GFz3fCTHPSWeKLZAX1alAAzk/rs:fit/g:sm/q:90/h:600/w:592/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MTg2/NDQxLTE1Njk0ODcx/NjEtNzMxNC5qcGVn.jpeg", new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), 25, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbey Road" },
                    { new Guid("eb4c19e6-d79f-4772-bfd7-944432c032d9"), "https://i.discogs.com/p2o5GGONaTq4jK398iU0X3KjuMfnK10_TEC_bdnKA6k/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTMzMjg5/ODItMTM1NzgxOTE3/NS05NTU3LmpwZWc.jpeg", new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), 19, new DateTime(1984, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Works" },
                    { new Guid("f262c65b-cadc-4826-a40d-cab5bc08f5c8"), "https://i.discogs.com/1fwskTLM6cfxbdNmBDJ8expl6wab0tEgxvuloLIqKh8/rs:fit/g:sm/q:90/h:596/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTkyODc4/MDktMTQ3OTc1MzIz/Ni05NjE3LmpwZWc.jpeg", new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), 20, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title", "TrackImageUrl" },
                values: new object[,]
                {
                    { new Guid("027e5f71-5d62-45c6-9602-90327d3f3b75"), new Guid("46deccd7-bed4-4133-ac66-aee3114e2cca"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 3, 0, 0), 129, "Love of My Life", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("0870c38b-6599-47f1-a350-9be2ceacd551"), new Guid("69035498-9180-4ac2-a29f-8bf1cef30fec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 8, 0, 0), 129, "Stairway to Heaven", "https://i.discogs.com/AO-PmjrMZa3JNJ8NBErUUcDOJ2Yna2jCNLbwmZ0n9aE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc1Nzg1/NC0xNTE1ODU0Mjcx/LTM3NDUuanBlZw.jpeg" },
                    { new Guid("1b831e70-6671-4b38-bf34-88f79c5c6ab2"), new Guid("419550b0-477c-4c2d-8b5d-35b558e991ec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 5, 0, 0), 129, "The Song Remains the Same", "https://i.discogs.com/PGoolvGRHExppmuvEDxPETmRJAFIlpoSAZ41ws86GLw/rs:fit/g:sm/q:90/h:577/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMzA2/LTU4MzMuanBlZw.jpeg" },
                    { new Guid("1c1f2607-0863-49df-9104-cf8be305f4c7"), new Guid("69035498-9180-4ac2-a29f-8bf1cef30fec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Rock and Roll", "https://i.discogs.com/aFc_fainrAcSiX2MbERPPWWlvjeYKc0D4yf53WD4rzM/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/NC00ODYwLmpwZWc.jpeg" },
                    { new Guid("1db605f1-df28-4ee8-9feb-5012ed6d7594"), new Guid("601ec9ef-1931-43a4-ae83-04b773ebca1c"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 5, 0, 0), 129, "Have a Cigar", "https://i.discogs.com/frk8i23GN3Epw5RaA-um7KwmBw0NTQiEHUYtirXaqdg/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MDgtMTIxMi5qcGVn.jpeg" },
                    { new Guid("3758dd52-d8ce-48bb-b400-27c722d34166"), new Guid("46deccd7-bed4-4133-ac66-aee3114e2cca"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 3, 0, 0), 129, "Death on Two Legs", "https://i.discogs.com/exLiE9TUHd1Osv4-SBjJsO8zScHQQ2s5XTA7QzvHmjk/rs:fit/g:sm/q:90/h:591/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQy/LTU2OTMuanBlZw.jpeg" },
                    { new Guid("39980673-bf11-43ef-ae6a-3eb45740406b"), new Guid("f262c65b-cadc-4826-a40d-cab5bc08f5c8"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 3, 0, 0), 129, "On the Run", "https://i.discogs.com/t4BbENT4ugUFTY-pgCqTcEHhlfwlrJeJuyTOTzqxKfM/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTcyNzc2NDky/OS03ODUzLmpwZWc.jpeg" },
                    { new Guid("3b4a0933-758c-498a-a853-34fdd519db0f"), new Guid("73970e5d-b375-4537-9001-196c51cf9110"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 4, 0, 0), 129, "Serve the Servants", "https://i.discogs.com/mFtdd9bDwACrDsS9nQyxKcWlBY_WKlcIib_5iq0NspE/rs:fit/g:sm/q:90/h:522/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyMjc5/MzMwLTE1MzIwMzE2/OTMtOTE3OC5qcGVn.jpeg" },
                    { new Guid("3e81dbd1-0649-4060-b3a6-233f555c2ed6"), new Guid("9a1c6833-4a8c-4158-b204-201ddbcb04c0"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 3, 0, 0), 129, "Something", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("4aeea237-23e2-4b54-9952-c51d8f9cdd79"), new Guid("f262c65b-cadc-4826-a40d-cab5bc08f5c8"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 6, 0, 0), 129, "Time", "https://i.discogs.com/rCpj_7gUWtxKDPQQpoVwbrud6zN2wwyQRVFR-ZaNtFI/rs:fit/g:sm/q:90/h:380/w:577/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDU4/MS5qcGVn.jpeg" },
                    { new Guid("4c10e3e3-1f22-490d-8200-f285600b3e51"), new Guid("eb4c19e6-d79f-4772-bfd7-944432c032d9"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 5, 0, 0), 129, "Radio Ga Ga", "https://i.discogs.com/b20JvPlll2B74GR7tMh3oSukHbeTjq3cyTBpdKk25fA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1MTU5/MTEtMTU5OTIzODcx/MS05NjI1LmpwZWc.jpeg" },
                    { new Guid("4cf4087b-669d-4802-bec1-510a68a9587a"), new Guid("601ec9ef-1931-43a4-ae83-04b773ebca1c"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 13, 0, 0), 129, "Shine On You Crazy Diamond (Part I-V)", "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg" },
                    { new Guid("502be032-830d-4d89-a602-2ec64d82e2cb"), new Guid("eb4c19e6-d79f-4772-bfd7-944432c032d9"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 4, 0, 0), 129, "I Want to Break Free", "https://i.discogs.com/GZW57VCYRIgmdlkLRQwj_ZejpTs1lW3TiH-m5zJzvKg/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1NDU5/MDAtMTIyNzQzNTEx/NS5qcGVn.jpeg" },
                    { new Guid("5327139a-9a34-4da3-ad42-9f5e2a8c543a"), new Guid("73970e5d-b375-4537-9001-196c51cf9110"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 5, 0, 0), 129, "Heart-Shaped Box", "https://i.discogs.com/jvt57zTP4f1brU4p_ABs9ylQ8K6B6a0El-CFqmHRyPU/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM5MzA2/NS0xMTgyNjg0ODgz/LmpwZWc.jpeg" },
                    { new Guid("5a378393-e339-47ea-b78d-86d23066d771"), new Guid("601ec9ef-1931-43a4-ae83-04b773ebca1c"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 7, 0, 0), 129, "Welcome to the Machine", "https://i.discogs.com/a36kcqXYhsvwN7S1cyq8_CGqqyWi78u3CLtxuE86-Go/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTYtMTc3Mi5qcGVn.jpeg" },
                    { new Guid("5f82b39b-fb8c-49ab-9a05-664ca3e1b035"), new Guid("9a1c6833-4a8c-4158-b204-201ddbcb04c0"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 3, 0, 0), 129, "Octopus's Garden", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("6fd19035-f328-4aab-b295-e47703945f7d"), new Guid("601ec9ef-1931-43a4-ae83-04b773ebca1c"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 5, 0, 0), 129, "Wish You Were Here", "https://i.discogs.com/hJBh2v_V6Ow6_hyPu791g1d_Pqj6_aoKB6fm_JUKUPA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MjgtNDE1My5qcGVn.jpeg" },
                    { new Guid("740e0c08-081d-4890-9292-09493b1b4973"), new Guid("7140cf95-b56c-4041-a9ed-aba960bdc255"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 5, 0, 0), 129, "Lithium", "https://i.discogs.com/hjHzpqaFqgJXi12l082Z4iIDAqkooFWzQOss9XzW6LU/rs:fit/g:sm/q:90/h:600/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyOTg2/OTQtMTU4NDk2NTg5/OS03MTUyLmpwZWc.jpeg" },
                    { new Guid("7d30a9b3-e8e8-42fe-a286-a9ff11275046"), new Guid("73970e5d-b375-4537-9001-196c51cf9110"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 4, 0, 0), 129, "Pennyroyal Tea", "https://i.discogs.com/7W0cV6lsC_kWMo0sbFf1pd73ROkSNo6cpWEUHGrgdas/rs:fit/g:sm/q:90/h:462/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgyOTcz/My0xMTY1MTQ0MjEy/LmpwZWc.jpeg" },
                    { new Guid("885dbaff-69d5-4e90-acaf-58da74c09bbd"), new Guid("5430f5cf-b38c-4ecc-9d22-60aee1796f28"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 3, 0, 0), 129, "Across the Universe", "https://i.discogs.com/KFfU_VOBY43WsttSMHMp0uUvaQ8Sk63qAoCDeTeENpE/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ1NjcxNjIy/LTM1ODYuanBlZw.jpeg" },
                    { new Guid("8c1aad36-eee6-4edd-bf45-e9eb9cc7e908"), new Guid("69035498-9180-4ac2-a29f-8bf1cef30fec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Going to California", "https://i.discogs.com/kOYbkKoJqpZfHNMg38TaBrOQmJWYO8UoRWV_BOgR6MA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg4/My02MDE1LmpwZWc.jpeg" },
                    { new Guid("94b126bf-0d8a-4843-ad5f-3bbd2463798d"), new Guid("eb4c19e6-d79f-4772-bfd7-944432c032d9"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 4, 0, 0), 129, "It's a Hard Life", "https://i.discogs.com/gdK1Z8e8y1qZybHe6WF_NXUstJzEhHSId63nx0GS_Yo/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1OTU3/NTktMTIzMTA1Njkw/MS5qcGVn.jpeg" },
                    { new Guid("9d487692-b57d-4e34-9959-c2cb48cd6f42"), new Guid("f262c65b-cadc-4826-a40d-cab5bc08f5c8"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 1, 0, 0), 129, "Speak to Me", "https://i.discogs.com/E9E7stvIt5YKUfK_CnrpIgxchviC7Q4WCeyQuuICAjo/rs:fit/g:sm/q:90/h:397/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDYw/MC5qcGVn.jpeg" },
                    { new Guid("a7e99edd-0598-445a-a022-d2d0295e9ce2"), new Guid("73970e5d-b375-4537-9001-196c51cf9110"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 3, 0, 0), 129, "Frances Farmer Will Have Her Revenge On Seattle", "https://i.discogs.com/FeGBBtykttDrTxPvdjPufzgY4HuxmQ_Yw-4F0ooQdCw/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MDE4/ODMyLTE1NjY3NjM4/MTctMzc3OS5qcGVn.jpeg" },
                    { new Guid("b3e6bf3a-9db4-4c13-9724-4d78fe05d5b5"), new Guid("419550b0-477c-4c2d-8b5d-35b558e991ec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 4, 0, 0), 129, "Over the Hills and Far Away", "https://i.discogs.com/QVRkVVBO1gFfafoFfNzNps67VKs1DsGRcHQ474zEDf0/rs:fit/g:sm/q:90/h:224/w:452/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMTcxOTI0MzQz/LmpwZWc.jpeg" },
                    { new Guid("b9cd9e4e-8070-407c-9e99-4b4b061d4ae7"), new Guid("7140cf95-b56c-4041-a9ed-aba960bdc255"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 5, 0, 0), 129, "Smells Like Teen Spirit", "https://i.discogs.com/MsIpIcpdbgg0r3CYB39OlwwuT81PuQ0psUcDvRLTdUU/rs:fit/g:sm/q:90/h:528/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MzI3/OC0xMzQwMTcwNjI1/LTMwNzguanBlZw.jpeg" },
                    { new Guid("bb2720e5-6496-4faf-a34e-240df86d3266"), new Guid("5430f5cf-b38c-4ecc-9d22-60aee1796f28"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 3, 0, 0), 129, "Get Back", "https://i.discogs.com/yZ8hA52tgMGcdxfY182_OqxJIjUuzu1NvwVKxNM_Ztg/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzIw/LmpwZWc.jpeg" },
                    { new Guid("bda332b9-bb19-4944-a396-ebb03ff74f90"), new Guid("9a1c6833-4a8c-4158-b204-201ddbcb04c0"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 3, 0, 0), 129, "Here Comes the Sun", "https://i.discogs.com/qsJyhu9LR8BERwbo5DRIYdNJzZFyuxQMr3RJcnOSEkw/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgxMzcz/NTUtMTQ1NTgzODU3/My0zNDk0LmpwZWc.jpeg" },
                    { new Guid("c9a0e002-64bb-41d2-a164-17027fbcf782"), new Guid("9a1c6833-4a8c-4158-b204-201ddbcb04c0"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come Together", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("ca066c35-5fde-42e5-ab30-07c7546f841e"), new Guid("eb4c19e6-d79f-4772-bfd7-944432c032d9"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 3, 0, 0), 129, "Tear It Up", "https://i.discogs.com/TNq6BKsREuTvVL0QtgziQ0ACcLNhKq9AjP-NYI7yo14/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ3NTU5/Ni0xNDU0NzA3NDYw/LTIxNzkuanBlZw.jpeg" },
                    { new Guid("d15a16c2-9bbd-47f0-8f77-36757c0d7b5f"), new Guid("69035498-9180-4ac2-a29f-8bf1cef30fec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 4, 0, 0), 129, "Black Dog", "https://i.discogs.com/Ok43Qrm9pIMNTCCCR5oXwL9XU_0_WxXdRl6RKeXfxBg/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/My00NDI0LmpwZWc.jpeg" },
                    { new Guid("d4baf977-ea64-420f-9949-bcdb2b3fc372"), new Guid("7140cf95-b56c-4041-a9ed-aba960bdc255"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come as You Are", "https://i.discogs.com/gIQVfX1uZI857sBz7NntFRdTCLO3eQT0o4qCiCIHnfE/rs:fit/g:sm/q:90/h:486/w:543/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc4MzIx/Ni0xNDE2ODkwNjQx/LTc3OTQuanBlZw.jpeg" },
                    { new Guid("d8aa562a-5b10-491e-a398-a944e5366795"), new Guid("46deccd7-bed4-4133-ac66-aee3114e2cca"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 6, 0, 0), 129, "Bohemian Rhapsody", "https://i.discogs.com/_RN78C49qgCxMX3CnRdxDggOCSI5P7uYaUGJ_Pl_CGM/rs:fit/g:sm/q:90/h:567/w:574/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2OTg5/MC0xMzkzMjg2NDQz/LTU3NTUuanBlZw.jpeg" },
                    { new Guid("dfa1d05f-a156-4a51-83ad-a28957080cac"), new Guid("419550b0-477c-4c2d-8b5d-35b558e991ec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 7, 0, 0), 129, "The Rain Song", "https://i.discogs.com/8wnDvfzEjV9Wc1BBxbaIIUeBhIxQ7WeFsKjdwt9hoWc/rs:fit/g:sm/q:90/h:574/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMjY2/LTY4MzkuanBlZw.jpeg" },
                    { new Guid("e2c5a6c2-0941-4951-a4f2-20d6e57bea9c"), new Guid("419550b0-477c-4c2d-8b5d-35b558e991ec"), new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"), new TimeSpan(0, 0, 7, 0, 0), 129, "No Quarter", "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg" },
                    { new Guid("e87be7a7-98f5-4a31-ab30-9b46258963cd"), new Guid("5430f5cf-b38c-4ecc-9d22-60aee1796f28"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 3, 0, 0), 129, "The Long and Winding Road", "https://i.discogs.com/3C94Ivdig0n1Jyb8d_0jKoIvj54r56hYW6kb6kiM8cY/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzMw/LmpwZWc.jpeg" },
                    { new Guid("f5723d07-eeed-4054-9656-5f8b4f7427d5"), new Guid("7140cf95-b56c-4041-a9ed-aba960bdc255"), new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"), new TimeSpan(0, 0, 4, 0, 0), 129, "In Bloom", "https://i.discogs.com/6fsdEUC3-9WQy2tB4PmRvGcYrKPtggYbUSgD5QyZQQ4/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEzNDgz/ODctMTY4MDY3ODQ1/My05NTcwLmpwZWc.jpeg" },
                    { new Guid("f7e3aa0a-80d8-40cf-81b4-0bd11720b69e"), new Guid("46deccd7-bed4-4133-ac66-aee3114e2cca"), new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"), new TimeSpan(0, 0, 3, 0, 0), 129, "You're My Best Friend", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("fd7b9bfb-f9e2-4b23-9099-7395364ed836"), new Guid("5430f5cf-b38c-4ecc-9d22-60aee1796f28"), new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"), new TimeSpan(0, 0, 4, 0, 0), 129, "Let It Be", "https://i.discogs.com/hAdrrjfnT2klIYc1V_oKX5HjpJ3xElwd7FDaDydTFGo/rs:fit/g:sm/q:90/h:600/w:566/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ0NTE5Njg4/LTU0MzkuanBlZw.jpeg" },
                    { new Guid("fe7d4e13-78fe-45eb-9eb3-9e944bc15946"), new Guid("f262c65b-cadc-4826-a40d-cab5bc08f5c8"), new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"), new TimeSpan(0, 0, 2, 0, 0), 129, "Breathe in the air", "https://i.discogs.com/mfba8kz9-PIwZGE5g70Z5i6JpITmeRfaXLsWClcxj8g/rs:fit/g:sm/q:90/h:500/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI4NzAw/MjYwLTE2OTgyMzg5/MDItNDY5NS5qcGVn.jpeg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("027e5f71-5d62-45c6-9602-90327d3f3b75"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0870c38b-6599-47f1-a350-9be2ceacd551"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1b831e70-6671-4b38-bf34-88f79c5c6ab2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1c1f2607-0863-49df-9104-cf8be305f4c7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1db605f1-df28-4ee8-9feb-5012ed6d7594"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3758dd52-d8ce-48bb-b400-27c722d34166"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("39980673-bf11-43ef-ae6a-3eb45740406b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3b4a0933-758c-498a-a853-34fdd519db0f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3e81dbd1-0649-4060-b3a6-233f555c2ed6"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4aeea237-23e2-4b54-9952-c51d8f9cdd79"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4c10e3e3-1f22-490d-8200-f285600b3e51"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4cf4087b-669d-4802-bec1-510a68a9587a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("502be032-830d-4d89-a602-2ec64d82e2cb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5327139a-9a34-4da3-ad42-9f5e2a8c543a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5a378393-e339-47ea-b78d-86d23066d771"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5f82b39b-fb8c-49ab-9a05-664ca3e1b035"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6fd19035-f328-4aab-b295-e47703945f7d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("740e0c08-081d-4890-9292-09493b1b4973"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7d30a9b3-e8e8-42fe-a286-a9ff11275046"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("885dbaff-69d5-4e90-acaf-58da74c09bbd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8c1aad36-eee6-4edd-bf45-e9eb9cc7e908"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("94b126bf-0d8a-4843-ad5f-3bbd2463798d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9d487692-b57d-4e34-9959-c2cb48cd6f42"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a7e99edd-0598-445a-a022-d2d0295e9ce2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b3e6bf3a-9db4-4c13-9724-4d78fe05d5b5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b9cd9e4e-8070-407c-9e99-4b4b061d4ae7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bb2720e5-6496-4faf-a34e-240df86d3266"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bda332b9-bb19-4944-a396-ebb03ff74f90"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c9a0e002-64bb-41d2-a164-17027fbcf782"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ca066c35-5fde-42e5-ab30-07c7546f841e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d15a16c2-9bbd-47f0-8f77-36757c0d7b5f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d4baf977-ea64-420f-9949-bcdb2b3fc372"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d8aa562a-5b10-491e-a398-a944e5366795"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("dfa1d05f-a156-4a51-83ad-a28957080cac"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e2c5a6c2-0941-4951-a4f2-20d6e57bea9c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e87be7a7-98f5-4a31-ab30-9b46258963cd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f5723d07-eeed-4054-9656-5f8b4f7427d5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f7e3aa0a-80d8-40cf-81b4-0bd11720b69e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fd7b9bfb-f9e2-4b23-9099-7395364ed836"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fe7d4e13-78fe-45eb-9eb3-9e944bc15946"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("419550b0-477c-4c2d-8b5d-35b558e991ec"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("46deccd7-bed4-4133-ac66-aee3114e2cca"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("5430f5cf-b38c-4ecc-9d22-60aee1796f28"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("601ec9ef-1931-43a4-ae83-04b773ebca1c"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("69035498-9180-4ac2-a29f-8bf1cef30fec"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("7140cf95-b56c-4041-a9ed-aba960bdc255"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("73970e5d-b375-4537-9001-196c51cf9110"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("9a1c6833-4a8c-4158-b204-201ddbcb04c0"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("eb4c19e6-d79f-4772-bfd7-944432c032d9"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("f262c65b-cadc-4826-a40d-cab5bc08f5c8"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("13ca4c9c-dbb8-426d-8a95-2b02095e66bb"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("34ce29a6-f83a-46e0-b62b-19cc7f513dab"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("4832b825-5713-41ec-95ce-ab04ef1249d5"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("dcdced73-b151-42c8-a4e2-c8bc0f373d4c"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("f5041b8f-36f0-4b4c-8c62-9f1ec57994e6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "BoughtItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), "A rock band known for its heavy sound.", "Led Zeppelin" },
                    { new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), "A rock band known for its eclectic musical style.", "Queen" },
                    { new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), "A grunge band that shaped the 90s music scene.", "Nirvana" },
                    { new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), "A legendary rock band.", "Pink Floyd" },
                    { new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), "One of the most influential rock bands.", "The Beatles" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageUrl", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("12c850aa-c450-4af7-bb7b-7e98d5ce4956"), "https://i.discogs.com/ijIUNhH--0OKzKuKv-aLpgFkb7lr6OQVb5FcAF_aW0U/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NTk3/OS0xNDkxNzAwMzQ3/LTcyNjMuanBlZw.jpeg", new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), 20, new DateTime(1993, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Utero" },
                    { new Guid("528c1b7a-008b-4e91-9c5d-81f0a6709a53"), "https://i.discogs.com/HWA3uoT2xu7zj_kM-f18f02CCQNKk2W8YzUL-D_l2ZM/rs:fit/g:sm/q:90/h:581/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwODgx/MjYtMTI1Njk1MDk3/OS5qcGVn.jpeg", new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), 23, new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let It Be" },
                    { new Guid("a35a51d6-87a1-4989-a806-08494acf98e8"), "https://i.discogs.com/XoAXkLe03Vk0Kt-oQqw7V9uW5nBzQdNvZd0zar5mOiQ/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2NzA4/NC0xMjYzMDk1NTUz/LmpwZWc.jpeg", new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), 18, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevermind" },
                    { new Guid("a6968856-eb50-49ed-9e5a-878bcc47361d"), "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg", new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), 22, new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wish You Were Here" },
                    { new Guid("cffaea35-dd5a-4a27-aab1-b57c2be9743f"), "https://i.discogs.com/p2o5GGONaTq4jK398iU0X3KjuMfnK10_TEC_bdnKA6k/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTMzMjg5/ODItMTM1NzgxOTE3/NS05NTU3LmpwZWc.jpeg", new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), 19, new DateTime(1984, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Works" },
                    { new Guid("d1376baa-a7b0-4967-9064-1a6b375e8e80"), "https://i.discogs.com/goWfjpqUBW8Y0xrqJG_GFz3fCTHPSWeKLZAX1alAAzk/rs:fit/g:sm/q:90/h:600/w:592/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MTg2/NDQxLTE1Njk0ODcx/NjEtNzMxNC5qcGVn.jpeg", new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), 25, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbey Road" },
                    { new Guid("e544c543-0017-44cf-aa2e-b300208c4d4e"), "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg", new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), 21, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Night at the Opera" },
                    { new Guid("ec9d3f10-5139-4c12-944b-25da7c55742a"), "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg", new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), 26, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houses of the Holy" },
                    { new Guid("eccc5564-1c78-4f64-8df6-7bef07339902"), "https://i.discogs.com/1fwskTLM6cfxbdNmBDJ8expl6wab0tEgxvuloLIqKh8/rs:fit/g:sm/q:90/h:596/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTkyODc4/MDktMTQ3OTc1MzIz/Ni05NjE3LmpwZWc.jpeg", new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), 20, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" },
                    { new Guid("fbdf9ad3-5d89-4f09-b19b-a1fc90977ac6"), "https://i.discogs.com/yFq3X0xZMxIVHIFgmbrsPvJHXLJCfVLWs60AL4XS4bs/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg2/Ny0yNzg1LmpwZWc.jpeg", new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), 24, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led Zeppelin IV" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title", "TrackImageUrl" },
                values: new object[,]
                {
                    { new Guid("0e191fdb-60b1-4ed3-be63-3d3a2cf873ae"), new Guid("fbdf9ad3-5d89-4f09-b19b-a1fc90977ac6"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Going to California", "https://i.discogs.com/kOYbkKoJqpZfHNMg38TaBrOQmJWYO8UoRWV_BOgR6MA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg4/My02MDE1LmpwZWc.jpeg" },
                    { new Guid("126eda42-d6ae-4eaa-b5bd-f679e0dfb232"), new Guid("12c850aa-c450-4af7-bb7b-7e98d5ce4956"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 3, 0, 0), 129, "Frances Farmer Will Have Her Revenge On Seattle", "https://i.discogs.com/FeGBBtykttDrTxPvdjPufzgY4HuxmQ_Yw-4F0ooQdCw/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MDE4/ODMyLTE1NjY3NjM4/MTctMzc3OS5qcGVn.jpeg" },
                    { new Guid("227fad2d-aee0-48c8-b10e-827b3ee96bc4"), new Guid("e544c543-0017-44cf-aa2e-b300208c4d4e"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 6, 0, 0), 129, "Bohemian Rhapsody", "https://i.discogs.com/_RN78C49qgCxMX3CnRdxDggOCSI5P7uYaUGJ_Pl_CGM/rs:fit/g:sm/q:90/h:567/w:574/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2OTg5/MC0xMzkzMjg2NDQz/LTU3NTUuanBlZw.jpeg" },
                    { new Guid("23bec2de-d42b-4b2e-a5a3-e3bf961cba5d"), new Guid("eccc5564-1c78-4f64-8df6-7bef07339902"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 6, 0, 0), 129, "Time", "https://i.discogs.com/rCpj_7gUWtxKDPQQpoVwbrud6zN2wwyQRVFR-ZaNtFI/rs:fit/g:sm/q:90/h:380/w:577/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDU4/MS5qcGVn.jpeg" },
                    { new Guid("291ce4f6-8db4-4098-bfcc-6083855859eb"), new Guid("12c850aa-c450-4af7-bb7b-7e98d5ce4956"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 5, 0, 0), 129, "Heart-Shaped Box", "https://i.discogs.com/jvt57zTP4f1brU4p_ABs9ylQ8K6B6a0El-CFqmHRyPU/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM5MzA2/NS0xMTgyNjg0ODgz/LmpwZWc.jpeg" },
                    { new Guid("2e5ea6be-e58b-4182-b23f-c5aef0997a7b"), new Guid("cffaea35-dd5a-4a27-aab1-b57c2be9743f"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 5, 0, 0), 129, "Radio Ga Ga", "https://i.discogs.com/b20JvPlll2B74GR7tMh3oSukHbeTjq3cyTBpdKk25fA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1MTU5/MTEtMTU5OTIzODcx/MS05NjI1LmpwZWc.jpeg" },
                    { new Guid("326cdf69-5b62-412b-9414-28fd6ae6f0ed"), new Guid("12c850aa-c450-4af7-bb7b-7e98d5ce4956"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 4, 0, 0), 129, "Pennyroyal Tea", "https://i.discogs.com/7W0cV6lsC_kWMo0sbFf1pd73ROkSNo6cpWEUHGrgdas/rs:fit/g:sm/q:90/h:462/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgyOTcz/My0xMTY1MTQ0MjEy/LmpwZWc.jpeg" },
                    { new Guid("34fd5e9c-6adb-4f13-aca9-d4127fa3b5f7"), new Guid("d1376baa-a7b0-4967-9064-1a6b375e8e80"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come Together", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("44643fa2-43cb-418b-b40f-635326fd53bd"), new Guid("12c850aa-c450-4af7-bb7b-7e98d5ce4956"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 4, 0, 0), 129, "Serve the Servants", "https://i.discogs.com/mFtdd9bDwACrDsS9nQyxKcWlBY_WKlcIib_5iq0NspE/rs:fit/g:sm/q:90/h:522/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyMjc5/MzMwLTE1MzIwMzE2/OTMtOTE3OC5qcGVn.jpeg" },
                    { new Guid("4a0278bf-7d05-4141-b618-2bf4da8ae7a6"), new Guid("eccc5564-1c78-4f64-8df6-7bef07339902"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 2, 0, 0), 129, "Breathe in the air", "https://i.discogs.com/mfba8kz9-PIwZGE5g70Z5i6JpITmeRfaXLsWClcxj8g/rs:fit/g:sm/q:90/h:500/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI4NzAw/MjYwLTE2OTgyMzg5/MDItNDY5NS5qcGVn.jpeg" },
                    { new Guid("4ea30dc8-40c2-4ad2-ab20-02f460250318"), new Guid("ec9d3f10-5139-4c12-944b-25da7c55742a"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 7, 0, 0), 129, "No Quarter", "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg" },
                    { new Guid("52f0255f-070a-45a5-b26c-f53cdce6a519"), new Guid("fbdf9ad3-5d89-4f09-b19b-a1fc90977ac6"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 3, 0, 0), 129, "Rock and Roll", "https://i.discogs.com/aFc_fainrAcSiX2MbERPPWWlvjeYKc0D4yf53WD4rzM/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/NC00ODYwLmpwZWc.jpeg" },
                    { new Guid("585ae788-c59f-44da-9562-a8d075efba54"), new Guid("d1376baa-a7b0-4967-9064-1a6b375e8e80"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 3, 0, 0), 129, "Something", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("58ffcd2a-17ae-4589-9ca6-7eeb1528b5bd"), new Guid("eccc5564-1c78-4f64-8df6-7bef07339902"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 3, 0, 0), 129, "On the Run", "https://i.discogs.com/t4BbENT4ugUFTY-pgCqTcEHhlfwlrJeJuyTOTzqxKfM/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTcyNzc2NDky/OS03ODUzLmpwZWc.jpeg" },
                    { new Guid("59b7e1f3-7c71-4b8a-b80c-5eef2bdb19fd"), new Guid("d1376baa-a7b0-4967-9064-1a6b375e8e80"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 3, 0, 0), 129, "Octopus's Garden", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("59d1e554-07cb-4e9a-8f71-bbc0e3b75627"), new Guid("e544c543-0017-44cf-aa2e-b300208c4d4e"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 3, 0, 0), 129, "Death on Two Legs", "https://i.discogs.com/exLiE9TUHd1Osv4-SBjJsO8zScHQQ2s5XTA7QzvHmjk/rs:fit/g:sm/q:90/h:591/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQy/LTU2OTMuanBlZw.jpeg" },
                    { new Guid("6aeb51b0-f1b4-4823-90ba-28416a8ce1ea"), new Guid("a6968856-eb50-49ed-9e5a-878bcc47361d"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 5, 0, 0), 129, "Have a Cigar", "https://i.discogs.com/frk8i23GN3Epw5RaA-um7KwmBw0NTQiEHUYtirXaqdg/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MDgtMTIxMi5qcGVn.jpeg" },
                    { new Guid("7647b0fe-7089-4521-a350-6355f88e7aea"), new Guid("a6968856-eb50-49ed-9e5a-878bcc47361d"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 5, 0, 0), 129, "Wish You Were Here", "https://i.discogs.com/hJBh2v_V6Ow6_hyPu791g1d_Pqj6_aoKB6fm_JUKUPA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MjgtNDE1My5qcGVn.jpeg" },
                    { new Guid("78e65fe0-c016-4d02-a1cb-b5b36dd18bad"), new Guid("cffaea35-dd5a-4a27-aab1-b57c2be9743f"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 4, 0, 0), 129, "It's a Hard Life", "https://i.discogs.com/gdK1Z8e8y1qZybHe6WF_NXUstJzEhHSId63nx0GS_Yo/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1OTU3/NTktMTIzMTA1Njkw/MS5qcGVn.jpeg" },
                    { new Guid("87146a48-95fd-4b3d-aa77-d0817eb09854"), new Guid("528c1b7a-008b-4e91-9c5d-81f0a6709a53"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 3, 0, 0), 129, "The Long and Winding Road", "https://i.discogs.com/3C94Ivdig0n1Jyb8d_0jKoIvj54r56hYW6kb6kiM8cY/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzMw/LmpwZWc.jpeg" },
                    { new Guid("884de3cf-5e51-457d-83e9-cfb95e37c2a8"), new Guid("cffaea35-dd5a-4a27-aab1-b57c2be9743f"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 3, 0, 0), 129, "Tear It Up", "https://i.discogs.com/TNq6BKsREuTvVL0QtgziQ0ACcLNhKq9AjP-NYI7yo14/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ3NTU5/Ni0xNDU0NzA3NDYw/LTIxNzkuanBlZw.jpeg" },
                    { new Guid("96229957-8617-4863-89ec-6da73cf4d164"), new Guid("a6968856-eb50-49ed-9e5a-878bcc47361d"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 7, 0, 0), 129, "Welcome to the Machine", "https://i.discogs.com/a36kcqXYhsvwN7S1cyq8_CGqqyWi78u3CLtxuE86-Go/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTYtMTc3Mi5qcGVn.jpeg" },
                    { new Guid("9ff0170e-ea9c-4faa-b369-bd9583d25705"), new Guid("e544c543-0017-44cf-aa2e-b300208c4d4e"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 3, 0, 0), 129, "Love of My Life", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("adfdeb6b-c954-4f2d-ac00-adc010c3c168"), new Guid("fbdf9ad3-5d89-4f09-b19b-a1fc90977ac6"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 8, 0, 0), 129, "Stairway to Heaven", "https://i.discogs.com/AO-PmjrMZa3JNJ8NBErUUcDOJ2Yna2jCNLbwmZ0n9aE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc1Nzg1/NC0xNTE1ODU0Mjcx/LTM3NDUuanBlZw.jpeg" },
                    { new Guid("af40ac5c-aca5-4470-8756-3f1372c97cb5"), new Guid("528c1b7a-008b-4e91-9c5d-81f0a6709a53"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 3, 0, 0), 129, "Get Back", "https://i.discogs.com/yZ8hA52tgMGcdxfY182_OqxJIjUuzu1NvwVKxNM_Ztg/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzIw/LmpwZWc.jpeg" },
                    { new Guid("b70b210d-6235-4e98-9e9a-bab0625f162a"), new Guid("cffaea35-dd5a-4a27-aab1-b57c2be9743f"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 4, 0, 0), 129, "I Want to Break Free", "https://i.discogs.com/GZW57VCYRIgmdlkLRQwj_ZejpTs1lW3TiH-m5zJzvKg/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1NDU5/MDAtMTIyNzQzNTEx/NS5qcGVn.jpeg" },
                    { new Guid("bd801c05-7f35-4992-b439-634d6b3f0cca"), new Guid("ec9d3f10-5139-4c12-944b-25da7c55742a"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 7, 0, 0), 129, "The Rain Song", "https://i.discogs.com/8wnDvfzEjV9Wc1BBxbaIIUeBhIxQ7WeFsKjdwt9hoWc/rs:fit/g:sm/q:90/h:574/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMjY2/LTY4MzkuanBlZw.jpeg" },
                    { new Guid("bdc9c004-8088-40a7-b151-c5c0cb83922c"), new Guid("ec9d3f10-5139-4c12-944b-25da7c55742a"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 4, 0, 0), 129, "Over the Hills and Far Away", "https://i.discogs.com/QVRkVVBO1gFfafoFfNzNps67VKs1DsGRcHQ474zEDf0/rs:fit/g:sm/q:90/h:224/w:452/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMTcxOTI0MzQz/LmpwZWc.jpeg" },
                    { new Guid("be238550-1b70-4d33-8610-bf92bbb10139"), new Guid("ec9d3f10-5139-4c12-944b-25da7c55742a"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 5, 0, 0), 129, "The Song Remains the Same", "https://i.discogs.com/PGoolvGRHExppmuvEDxPETmRJAFIlpoSAZ41ws86GLw/rs:fit/g:sm/q:90/h:577/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMzA2/LTU4MzMuanBlZw.jpeg" },
                    { new Guid("c12aac4a-c955-4bae-a531-1f9113ce0fec"), new Guid("a35a51d6-87a1-4989-a806-08494acf98e8"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come as You Are", "https://i.discogs.com/gIQVfX1uZI857sBz7NntFRdTCLO3eQT0o4qCiCIHnfE/rs:fit/g:sm/q:90/h:486/w:543/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc4MzIx/Ni0xNDE2ODkwNjQx/LTc3OTQuanBlZw.jpeg" },
                    { new Guid("d65256df-b0d3-4824-9ede-f49b0007cf4c"), new Guid("eccc5564-1c78-4f64-8df6-7bef07339902"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 1, 0, 0), 129, "Speak to Me", "https://i.discogs.com/E9E7stvIt5YKUfK_CnrpIgxchviC7Q4WCeyQuuICAjo/rs:fit/g:sm/q:90/h:397/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDYw/MC5qcGVn.jpeg" },
                    { new Guid("d68102e8-a433-4b41-ab21-1f77246cce86"), new Guid("a35a51d6-87a1-4989-a806-08494acf98e8"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 5, 0, 0), 129, "Smells Like Teen Spirit", "https://i.discogs.com/MsIpIcpdbgg0r3CYB39OlwwuT81PuQ0psUcDvRLTdUU/rs:fit/g:sm/q:90/h:528/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MzI3/OC0xMzQwMTcwNjI1/LTMwNzguanBlZw.jpeg" },
                    { new Guid("dc2f9861-4e0c-46aa-9e3d-b9460de64d6c"), new Guid("a6968856-eb50-49ed-9e5a-878bcc47361d"), new Guid("e0194146-5167-432c-a2ac-389322a5f9e4"), new TimeSpan(0, 0, 13, 0, 0), 129, "Shine On You Crazy Diamond (Part I-V)", "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg" },
                    { new Guid("e397b37c-bed7-4cf8-946a-54876e75e0ad"), new Guid("a35a51d6-87a1-4989-a806-08494acf98e8"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 4, 0, 0), 129, "In Bloom", "https://i.discogs.com/6fsdEUC3-9WQy2tB4PmRvGcYrKPtggYbUSgD5QyZQQ4/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEzNDgz/ODctMTY4MDY3ODQ1/My05NTcwLmpwZWc.jpeg" },
                    { new Guid("f0ea87c2-af87-47ec-9792-e2dcce62b532"), new Guid("e544c543-0017-44cf-aa2e-b300208c4d4e"), new Guid("619a35b5-9004-46af-af82-a3bbd948c719"), new TimeSpan(0, 0, 3, 0, 0), 129, "You're My Best Friend", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("f2a6d8ef-6c6a-4150-9e34-1da2162b5f75"), new Guid("a35a51d6-87a1-4989-a806-08494acf98e8"), new Guid("6ad74817-2c8c-4075-bf9d-00e9e700eb3e"), new TimeSpan(0, 0, 5, 0, 0), 129, "Lithium", "https://i.discogs.com/hjHzpqaFqgJXi12l082Z4iIDAqkooFWzQOss9XzW6LU/rs:fit/g:sm/q:90/h:600/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyOTg2/OTQtMTU4NDk2NTg5/OS03MTUyLmpwZWc.jpeg" },
                    { new Guid("f99742bc-0ed1-4c71-a3bb-20598e7f38fa"), new Guid("fbdf9ad3-5d89-4f09-b19b-a1fc90977ac6"), new Guid("3bfda304-f53e-40f0-9b83-47235bbe506c"), new TimeSpan(0, 0, 4, 0, 0), 129, "Black Dog", "https://i.discogs.com/Ok43Qrm9pIMNTCCCR5oXwL9XU_0_WxXdRl6RKeXfxBg/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/My00NDI0LmpwZWc.jpeg" },
                    { new Guid("fd62f17a-c23c-4a09-b40f-57a7f7c45cf6"), new Guid("528c1b7a-008b-4e91-9c5d-81f0a6709a53"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 3, 0, 0), 129, "Across the Universe", "https://i.discogs.com/KFfU_VOBY43WsttSMHMp0uUvaQ8Sk63qAoCDeTeENpE/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ1NjcxNjIy/LTM1ODYuanBlZw.jpeg" },
                    { new Guid("ff310da1-2f05-4df6-9a52-431e1555ccb9"), new Guid("d1376baa-a7b0-4967-9064-1a6b375e8e80"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 3, 0, 0), 129, "Here Comes the Sun", "https://i.discogs.com/qsJyhu9LR8BERwbo5DRIYdNJzZFyuxQMr3RJcnOSEkw/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgxMzcz/NTUtMTQ1NTgzODU3/My0zNDk0LmpwZWc.jpeg" },
                    { new Guid("fff5dd38-f443-4729-b9ec-7db917ba56d3"), new Guid("528c1b7a-008b-4e91-9c5d-81f0a6709a53"), new Guid("e42f6997-b85e-4fb8-801e-7d8c526f07a3"), new TimeSpan(0, 0, 4, 0, 0), 129, "Let It Be", "https://i.discogs.com/hAdrrjfnT2klIYc1V_oKX5HjpJ3xElwd7FDaDydTFGo/rs:fit/g:sm/q:90/h:600/w:566/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ0NTE5Njg4/LTU0MzkuanBlZw.jpeg" }
                });
        }
    }
}
