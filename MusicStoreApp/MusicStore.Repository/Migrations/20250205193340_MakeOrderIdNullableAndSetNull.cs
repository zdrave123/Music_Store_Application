using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MakeOrderIdNullableAndSetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoughtItems_Orders_OrderId",
                table: "BoughtItems");

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

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { new Guid("0a5a6408-a484-45f9-9609-e73059158289"), "A rock band known for its eclectic musical style.", "Queen" },
                    { new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), "A grunge band that shaped the 90s music scene.", "Nirvana" },
                    { new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), "A legendary rock band.", "Pink Floyd" },
                    { new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), "One of the most influential rock bands.", "The Beatles" },
                    { new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), "A rock band known for its heavy sound.", "Led Zeppelin" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageUrl", "ArtistId", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4d9dc852-f291-4f9f-8a1f-0643e2416c3f"), "https://i.discogs.com/ijIUNhH--0OKzKuKv-aLpgFkb7lr6OQVb5FcAF_aW0U/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NTk3/OS0xNDkxNzAwMzQ3/LTcyNjMuanBlZw.jpeg", new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), 20, new DateTime(1993, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Utero" },
                    { new Guid("50bd036b-34d3-4b24-932f-a6805629b5a9"), "https://i.discogs.com/yFq3X0xZMxIVHIFgmbrsPvJHXLJCfVLWs60AL4XS4bs/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg2/Ny0yNzg1LmpwZWc.jpeg", new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), 24, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led Zeppelin IV" },
                    { new Guid("74c096d7-a565-4fbc-b65d-cf962adca542"), "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg", new Guid("0a5a6408-a484-45f9-9609-e73059158289"), 21, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Night at the Opera" },
                    { new Guid("955e64d1-f8af-49d2-813d-5a4be265bb01"), "https://i.discogs.com/goWfjpqUBW8Y0xrqJG_GFz3fCTHPSWeKLZAX1alAAzk/rs:fit/g:sm/q:90/h:600/w:592/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MTg2/NDQxLTE1Njk0ODcx/NjEtNzMxNC5qcGVn.jpeg", new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), 25, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbey Road" },
                    { new Guid("9939d5cc-8b92-43ce-81b6-51d4bca6bb70"), "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg", new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), 22, new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wish You Were Here" },
                    { new Guid("9aeec161-fdbf-43f2-9df6-ad9eecffa4f8"), "https://i.discogs.com/1fwskTLM6cfxbdNmBDJ8expl6wab0tEgxvuloLIqKh8/rs:fit/g:sm/q:90/h:596/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTkyODc4/MDktMTQ3OTc1MzIz/Ni05NjE3LmpwZWc.jpeg", new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), 20, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon" },
                    { new Guid("a44a2b55-8237-4c54-ba0f-1656536630f8"), "https://i.discogs.com/XoAXkLe03Vk0Kt-oQqw7V9uW5nBzQdNvZd0zar5mOiQ/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2NzA4/NC0xMjYzMDk1NTUz/LmpwZWc.jpeg", new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), 18, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevermind" },
                    { new Guid("c8684cd1-a8ae-47d5-a017-4d0f0941f23c"), "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg", new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), 26, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houses of the Holy" },
                    { new Guid("e6289ca4-9a0b-460b-b1d3-4224e9656f77"), "https://i.discogs.com/HWA3uoT2xu7zj_kM-f18f02CCQNKk2W8YzUL-D_l2ZM/rs:fit/g:sm/q:90/h:581/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwODgx/MjYtMTI1Njk1MDk3/OS5qcGVn.jpeg", new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), 23, new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let It Be" },
                    { new Guid("fd93596a-99fc-4636-b0d8-8e9630ade643"), "https://i.discogs.com/p2o5GGONaTq4jK398iU0X3KjuMfnK10_TEC_bdnKA6k/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTMzMjg5/ODItMTM1NzgxOTE3/NS05NTU3LmpwZWc.jpeg", new Guid("0a5a6408-a484-45f9-9609-e73059158289"), 19, new DateTime(1984, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Works" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "Duration", "Price", "Title", "TrackImageUrl" },
                values: new object[,]
                {
                    { new Guid("082edfaa-2af4-4c68-9a7b-19347616c617"), new Guid("4d9dc852-f291-4f9f-8a1f-0643e2416c3f"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 5, 0, 0), 129, "Heart-Shaped Box", "https://i.discogs.com/jvt57zTP4f1brU4p_ABs9ylQ8K6B6a0El-CFqmHRyPU/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM5MzA2/NS0xMTgyNjg0ODgz/LmpwZWc.jpeg" },
                    { new Guid("08576d3b-62a8-404a-b780-5fecd878e780"), new Guid("9aeec161-fdbf-43f2-9df6-ad9eecffa4f8"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 3, 0, 0), 129, "On the Run", "https://i.discogs.com/t4BbENT4ugUFTY-pgCqTcEHhlfwlrJeJuyTOTzqxKfM/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTcyNzc2NDky/OS03ODUzLmpwZWc.jpeg" },
                    { new Guid("1149c0c2-aae5-4a8a-9a62-fa4d4be5f22a"), new Guid("955e64d1-f8af-49d2-813d-5a4be265bb01"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 3, 0, 0), 129, "Octopus's Garden", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("1ab4df3c-4213-48a8-958f-17cf56d5c63c"), new Guid("9939d5cc-8b92-43ce-81b6-51d4bca6bb70"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 13, 0, 0), 129, "Shine On You Crazy Diamond (Part I-V)", "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg" },
                    { new Guid("24378446-af44-4923-9d10-5807af48884f"), new Guid("50bd036b-34d3-4b24-932f-a6805629b5a9"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 3, 0, 0), 129, "Rock and Roll", "https://i.discogs.com/aFc_fainrAcSiX2MbERPPWWlvjeYKc0D4yf53WD4rzM/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/NC00ODYwLmpwZWc.jpeg" },
                    { new Guid("2d45cf8f-2fa6-421c-9be5-accff0a42511"), new Guid("74c096d7-a565-4fbc-b65d-cf962adca542"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 6, 0, 0), 129, "Bohemian Rhapsody", "https://i.discogs.com/_RN78C49qgCxMX3CnRdxDggOCSI5P7uYaUGJ_Pl_CGM/rs:fit/g:sm/q:90/h:567/w:574/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2OTg5/MC0xMzkzMjg2NDQz/LTU3NTUuanBlZw.jpeg" },
                    { new Guid("2dfe7f02-8bd9-4b0a-8a95-186a07f32673"), new Guid("a44a2b55-8237-4c54-ba0f-1656536630f8"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come as You Are", "https://i.discogs.com/gIQVfX1uZI857sBz7NntFRdTCLO3eQT0o4qCiCIHnfE/rs:fit/g:sm/q:90/h:486/w:543/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc4MzIx/Ni0xNDE2ODkwNjQx/LTc3OTQuanBlZw.jpeg" },
                    { new Guid("3663936c-91fe-4954-bbd4-c4693704553b"), new Guid("74c096d7-a565-4fbc-b65d-cf962adca542"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 3, 0, 0), 129, "Love of My Life", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("38a29651-7652-484f-bb93-dfd0f0a4df85"), new Guid("9939d5cc-8b92-43ce-81b6-51d4bca6bb70"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 5, 0, 0), 129, "Wish You Were Here", "https://i.discogs.com/hJBh2v_V6Ow6_hyPu791g1d_Pqj6_aoKB6fm_JUKUPA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MjgtNDE1My5qcGVn.jpeg" },
                    { new Guid("3c6d4a89-1558-40af-bfe2-e971524a142f"), new Guid("a44a2b55-8237-4c54-ba0f-1656536630f8"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 5, 0, 0), 129, "Lithium", "https://i.discogs.com/hjHzpqaFqgJXi12l082Z4iIDAqkooFWzQOss9XzW6LU/rs:fit/g:sm/q:90/h:600/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyOTg2/OTQtMTU4NDk2NTg5/OS03MTUyLmpwZWc.jpeg" },
                    { new Guid("40739108-855f-4588-b333-33b49ce96430"), new Guid("50bd036b-34d3-4b24-932f-a6805629b5a9"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 3, 0, 0), 129, "Going to California", "https://i.discogs.com/kOYbkKoJqpZfHNMg38TaBrOQmJWYO8UoRWV_BOgR6MA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg4/My02MDE1LmpwZWc.jpeg" },
                    { new Guid("46820f41-dd97-4b8a-a832-6504e220d3cc"), new Guid("50bd036b-34d3-4b24-932f-a6805629b5a9"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 8, 0, 0), 129, "Stairway to Heaven", "https://i.discogs.com/AO-PmjrMZa3JNJ8NBErUUcDOJ2Yna2jCNLbwmZ0n9aE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc1Nzg1/NC0xNTE1ODU0Mjcx/LTM3NDUuanBlZw.jpeg" },
                    { new Guid("4917a5f8-2a6d-4e6b-a73d-19a957941b59"), new Guid("955e64d1-f8af-49d2-813d-5a4be265bb01"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 3, 0, 0), 129, "Here Comes the Sun", "https://i.discogs.com/qsJyhu9LR8BERwbo5DRIYdNJzZFyuxQMr3RJcnOSEkw/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgxMzcz/NTUtMTQ1NTgzODU3/My0zNDk0LmpwZWc.jpeg" },
                    { new Guid("493439ff-57ab-4de5-9e45-8ee0019ec87a"), new Guid("a44a2b55-8237-4c54-ba0f-1656536630f8"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 5, 0, 0), 129, "Smells Like Teen Spirit", "https://i.discogs.com/MsIpIcpdbgg0r3CYB39OlwwuT81PuQ0psUcDvRLTdUU/rs:fit/g:sm/q:90/h:528/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MzI3/OC0xMzQwMTcwNjI1/LTMwNzguanBlZw.jpeg" },
                    { new Guid("4cc828da-852b-4d28-a831-1b33670afb96"), new Guid("fd93596a-99fc-4636-b0d8-8e9630ade643"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 4, 0, 0), 129, "It's a Hard Life", "https://i.discogs.com/gdK1Z8e8y1qZybHe6WF_NXUstJzEhHSId63nx0GS_Yo/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1OTU3/NTktMTIzMTA1Njkw/MS5qcGVn.jpeg" },
                    { new Guid("4ce8fc19-cae6-4d7a-b51c-21d315eda9d5"), new Guid("4d9dc852-f291-4f9f-8a1f-0643e2416c3f"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 4, 0, 0), 129, "Pennyroyal Tea", "https://i.discogs.com/7W0cV6lsC_kWMo0sbFf1pd73ROkSNo6cpWEUHGrgdas/rs:fit/g:sm/q:90/h:462/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgyOTcz/My0xMTY1MTQ0MjEy/LmpwZWc.jpeg" },
                    { new Guid("54bd2221-651b-487d-9f5d-6108f34737c8"), new Guid("fd93596a-99fc-4636-b0d8-8e9630ade643"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 3, 0, 0), 129, "Tear It Up", "https://i.discogs.com/TNq6BKsREuTvVL0QtgziQ0ACcLNhKq9AjP-NYI7yo14/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ3NTU5/Ni0xNDU0NzA3NDYw/LTIxNzkuanBlZw.jpeg" },
                    { new Guid("55bab500-2844-4d45-9d96-023932ebe9a2"), new Guid("e6289ca4-9a0b-460b-b1d3-4224e9656f77"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 3, 0, 0), 129, "Across the Universe", "https://i.discogs.com/KFfU_VOBY43WsttSMHMp0uUvaQ8Sk63qAoCDeTeENpE/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ1NjcxNjIy/LTM1ODYuanBlZw.jpeg" },
                    { new Guid("5b87080f-4e8d-4e0d-8296-ca72abe80fca"), new Guid("c8684cd1-a8ae-47d5-a017-4d0f0941f23c"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 7, 0, 0), 129, "No Quarter", "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg" },
                    { new Guid("80ae42c3-ce6b-4890-a9b1-786dc170ee30"), new Guid("fd93596a-99fc-4636-b0d8-8e9630ade643"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 5, 0, 0), 129, "Radio Ga Ga", "https://i.discogs.com/b20JvPlll2B74GR7tMh3oSukHbeTjq3cyTBpdKk25fA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1MTU5/MTEtMTU5OTIzODcx/MS05NjI1LmpwZWc.jpeg" },
                    { new Guid("8190643a-08db-4f6c-b914-23baf9d437a5"), new Guid("e6289ca4-9a0b-460b-b1d3-4224e9656f77"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 4, 0, 0), 129, "Let It Be", "https://i.discogs.com/hAdrrjfnT2klIYc1V_oKX5HjpJ3xElwd7FDaDydTFGo/rs:fit/g:sm/q:90/h:600/w:566/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ0NTE5Njg4/LTU0MzkuanBlZw.jpeg" },
                    { new Guid("88194897-22bf-4dcc-aa92-1d9b6b962e98"), new Guid("50bd036b-34d3-4b24-932f-a6805629b5a9"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 4, 0, 0), 129, "Black Dog", "https://i.discogs.com/Ok43Qrm9pIMNTCCCR5oXwL9XU_0_WxXdRl6RKeXfxBg/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/My00NDI0LmpwZWc.jpeg" },
                    { new Guid("8909e7f1-668c-4242-af61-5cd342a5bc47"), new Guid("9aeec161-fdbf-43f2-9df6-ad9eecffa4f8"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 1, 0, 0), 129, "Speak to Me", "https://i.discogs.com/E9E7stvIt5YKUfK_CnrpIgxchviC7Q4WCeyQuuICAjo/rs:fit/g:sm/q:90/h:397/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDYw/MC5qcGVn.jpeg" },
                    { new Guid("8b6fc296-a99d-4ac7-af3d-549653e2d4cc"), new Guid("fd93596a-99fc-4636-b0d8-8e9630ade643"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 4, 0, 0), 129, "I Want to Break Free", "https://i.discogs.com/GZW57VCYRIgmdlkLRQwj_ZejpTs1lW3TiH-m5zJzvKg/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1NDU5/MDAtMTIyNzQzNTEx/NS5qcGVn.jpeg" },
                    { new Guid("8fe04cee-4815-42b2-8ce8-20ca9f457954"), new Guid("9939d5cc-8b92-43ce-81b6-51d4bca6bb70"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 7, 0, 0), 129, "Welcome to the Machine", "https://i.discogs.com/a36kcqXYhsvwN7S1cyq8_CGqqyWi78u3CLtxuE86-Go/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTYtMTc3Mi5qcGVn.jpeg" },
                    { new Guid("9b4faac5-2c4a-45c2-a5ff-73cb3f223367"), new Guid("955e64d1-f8af-49d2-813d-5a4be265bb01"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 3, 0, 0), 129, "Something", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("9d022888-befd-4274-b729-7255cecd4765"), new Guid("9939d5cc-8b92-43ce-81b6-51d4bca6bb70"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 5, 0, 0), 129, "Have a Cigar", "https://i.discogs.com/frk8i23GN3Epw5RaA-um7KwmBw0NTQiEHUYtirXaqdg/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MDgtMTIxMi5qcGVn.jpeg" },
                    { new Guid("a422a5ff-f9b4-43b5-9a49-72d341a477ba"), new Guid("74c096d7-a565-4fbc-b65d-cf962adca542"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 3, 0, 0), 129, "Death on Two Legs", "https://i.discogs.com/exLiE9TUHd1Osv4-SBjJsO8zScHQQ2s5XTA7QzvHmjk/rs:fit/g:sm/q:90/h:591/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQy/LTU2OTMuanBlZw.jpeg" },
                    { new Guid("aba2672b-5506-4972-8935-54a21d74d2d7"), new Guid("e6289ca4-9a0b-460b-b1d3-4224e9656f77"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 3, 0, 0), 129, "The Long and Winding Road", "https://i.discogs.com/3C94Ivdig0n1Jyb8d_0jKoIvj54r56hYW6kb6kiM8cY/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzMw/LmpwZWc.jpeg" },
                    { new Guid("ad9ec9ed-a8e5-4eaa-a890-fa835b19bf07"), new Guid("4d9dc852-f291-4f9f-8a1f-0643e2416c3f"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 3, 0, 0), 129, "Frances Farmer Will Have Her Revenge On Seattle", "https://i.discogs.com/FeGBBtykttDrTxPvdjPufzgY4HuxmQ_Yw-4F0ooQdCw/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MDE4/ODMyLTE1NjY3NjM4/MTctMzc3OS5qcGVn.jpeg" },
                    { new Guid("ae744f21-ff83-4643-8fb4-8b676fa6016f"), new Guid("e6289ca4-9a0b-460b-b1d3-4224e9656f77"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 3, 0, 0), 129, "Get Back", "https://i.discogs.com/yZ8hA52tgMGcdxfY182_OqxJIjUuzu1NvwVKxNM_Ztg/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzIw/LmpwZWc.jpeg" },
                    { new Guid("c541d07e-d70d-444a-9355-657392d9b2c5"), new Guid("9aeec161-fdbf-43f2-9df6-ad9eecffa4f8"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 2, 0, 0), 129, "Breathe in the air", "https://i.discogs.com/mfba8kz9-PIwZGE5g70Z5i6JpITmeRfaXLsWClcxj8g/rs:fit/g:sm/q:90/h:500/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI4NzAw/MjYwLTE2OTgyMzg5/MDItNDY5NS5qcGVn.jpeg" },
                    { new Guid("d8160563-899f-402c-8edf-bbd2771a693b"), new Guid("c8684cd1-a8ae-47d5-a017-4d0f0941f23c"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 5, 0, 0), 129, "The Song Remains the Same", "https://i.discogs.com/PGoolvGRHExppmuvEDxPETmRJAFIlpoSAZ41ws86GLw/rs:fit/g:sm/q:90/h:577/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMzA2/LTU4MzMuanBlZw.jpeg" },
                    { new Guid("da7453d3-7430-44e1-a1f3-0b477d7a8cf0"), new Guid("955e64d1-f8af-49d2-813d-5a4be265bb01"), new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"), new TimeSpan(0, 0, 4, 0, 0), 129, "Come Together", "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
                    { new Guid("dba66f88-92f3-415d-b2d3-a74534c8d351"), new Guid("c8684cd1-a8ae-47d5-a017-4d0f0941f23c"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 4, 0, 0), 129, "Over the Hills and Far Away", "https://i.discogs.com/QVRkVVBO1gFfafoFfNzNps67VKs1DsGRcHQ474zEDf0/rs:fit/g:sm/q:90/h:224/w:452/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMTcxOTI0MzQz/LmpwZWc.jpeg" },
                    { new Guid("e05be34b-bb40-44e9-a405-a28f4bf90552"), new Guid("74c096d7-a565-4fbc-b65d-cf962adca542"), new Guid("0a5a6408-a484-45f9-9609-e73059158289"), new TimeSpan(0, 0, 3, 0, 0), 129, "You're My Best Friend", "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    { new Guid("e41a8157-8ccf-444b-9657-57556e608e41"), new Guid("c8684cd1-a8ae-47d5-a017-4d0f0941f23c"), new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"), new TimeSpan(0, 0, 7, 0, 0), 129, "The Rain Song", "https://i.discogs.com/8wnDvfzEjV9Wc1BBxbaIIUeBhIxQ7WeFsKjdwt9hoWc/rs:fit/g:sm/q:90/h:574/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMjY2/LTY4MzkuanBlZw.jpeg" },
                    { new Guid("e82cf279-452b-40f4-a98e-7681e011ae51"), new Guid("9aeec161-fdbf-43f2-9df6-ad9eecffa4f8"), new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"), new TimeSpan(0, 0, 6, 0, 0), 129, "Time", "https://i.discogs.com/rCpj_7gUWtxKDPQQpoVwbrud6zN2wwyQRVFR-ZaNtFI/rs:fit/g:sm/q:90/h:380/w:577/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDU4/MS5qcGVn.jpeg" },
                    { new Guid("f75476c4-b411-4084-acd1-556a5e43a0a7"), new Guid("4d9dc852-f291-4f9f-8a1f-0643e2416c3f"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 4, 0, 0), 129, "Serve the Servants", "https://i.discogs.com/mFtdd9bDwACrDsS9nQyxKcWlBY_WKlcIib_5iq0NspE/rs:fit/g:sm/q:90/h:522/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyMjc5/MzMwLTE1MzIwMzE2/OTMtOTE3OC5qcGVn.jpeg" },
                    { new Guid("fe698329-5ff4-4c6c-9620-f04a345bc7b3"), new Guid("a44a2b55-8237-4c54-ba0f-1656536630f8"), new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"), new TimeSpan(0, 0, 4, 0, 0), 129, "In Bloom", "https://i.discogs.com/6fsdEUC3-9WQy2tB4PmRvGcYrKPtggYbUSgD5QyZQQ4/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEzNDgz/ODctMTY4MDY3ODQ1/My05NTcwLmpwZWc.jpeg" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BoughtItems_Orders_OrderId",
                table: "BoughtItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoughtItems_Orders_OrderId",
                table: "BoughtItems");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("082edfaa-2af4-4c68-9a7b-19347616c617"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("08576d3b-62a8-404a-b780-5fecd878e780"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1149c0c2-aae5-4a8a-9a62-fa4d4be5f22a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1ab4df3c-4213-48a8-958f-17cf56d5c63c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("24378446-af44-4923-9d10-5807af48884f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2d45cf8f-2fa6-421c-9be5-accff0a42511"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2dfe7f02-8bd9-4b0a-8a95-186a07f32673"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3663936c-91fe-4954-bbd4-c4693704553b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("38a29651-7652-484f-bb93-dfd0f0a4df85"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3c6d4a89-1558-40af-bfe2-e971524a142f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("40739108-855f-4588-b333-33b49ce96430"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("46820f41-dd97-4b8a-a832-6504e220d3cc"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4917a5f8-2a6d-4e6b-a73d-19a957941b59"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("493439ff-57ab-4de5-9e45-8ee0019ec87a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4cc828da-852b-4d28-a831-1b33670afb96"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4ce8fc19-cae6-4d7a-b51c-21d315eda9d5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("54bd2221-651b-487d-9f5d-6108f34737c8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("55bab500-2844-4d45-9d96-023932ebe9a2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5b87080f-4e8d-4e0d-8296-ca72abe80fca"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("80ae42c3-ce6b-4890-a9b1-786dc170ee30"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8190643a-08db-4f6c-b914-23baf9d437a5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("88194897-22bf-4dcc-aa92-1d9b6b962e98"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8909e7f1-668c-4242-af61-5cd342a5bc47"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8b6fc296-a99d-4ac7-af3d-549653e2d4cc"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8fe04cee-4815-42b2-8ce8-20ca9f457954"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9b4faac5-2c4a-45c2-a5ff-73cb3f223367"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9d022888-befd-4274-b729-7255cecd4765"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a422a5ff-f9b4-43b5-9a49-72d341a477ba"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("aba2672b-5506-4972-8935-54a21d74d2d7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ad9ec9ed-a8e5-4eaa-a890-fa835b19bf07"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ae744f21-ff83-4643-8fb4-8b676fa6016f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c541d07e-d70d-444a-9355-657392d9b2c5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d8160563-899f-402c-8edf-bbd2771a693b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("da7453d3-7430-44e1-a1f3-0b477d7a8cf0"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("dba66f88-92f3-415d-b2d3-a74534c8d351"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e05be34b-bb40-44e9-a405-a28f4bf90552"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e41a8157-8ccf-444b-9657-57556e608e41"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e82cf279-452b-40f4-a98e-7681e011ae51"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f75476c4-b411-4084-acd1-556a5e43a0a7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fe698329-5ff4-4c6c-9620-f04a345bc7b3"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("4d9dc852-f291-4f9f-8a1f-0643e2416c3f"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("50bd036b-34d3-4b24-932f-a6805629b5a9"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("74c096d7-a565-4fbc-b65d-cf962adca542"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("955e64d1-f8af-49d2-813d-5a4be265bb01"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("9939d5cc-8b92-43ce-81b6-51d4bca6bb70"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("9aeec161-fdbf-43f2-9df6-ad9eecffa4f8"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("a44a2b55-8237-4c54-ba0f-1656536630f8"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("c8684cd1-a8ae-47d5-a017-4d0f0941f23c"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("e6289ca4-9a0b-460b-b1d3-4224e9656f77"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("fd93596a-99fc-4636-b0d8-8e9630ade643"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("0a5a6408-a484-45f9-9609-e73059158289"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("3ce30c3d-c447-4a1e-ae4d-6a084c558caf"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("911a1646-4ba7-4d31-b632-2ef2c062fa15"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a64fb778-dcbd-43b8-93b5-588a76f923d8"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("f8c0495d-adaa-45f1-9db4-ca7b1983fcda"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_BoughtItems_Orders_OrderId",
                table: "BoughtItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
