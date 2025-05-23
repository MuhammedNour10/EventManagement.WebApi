using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagement.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRsvsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9687eda2-8604-4d67-8f27-01131fc59750", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9687eda2-8604-4d67-8f27-01131fc59750", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9687eda2-8604-4d67-8f27-01131fc59750", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9687eda2-8604-4d67-8f27-01131fc59750", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9687eda2-8604-4d67-8f27-01131fc59750", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9687eda2-8604-4d67-8f27-01131fc59750", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3873ef0e-19ce-4cc2-a7a4-9163cd130e01", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3873ef0e-19ce-4cc2-a7a4-9163cd130e01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9687eda2-8604-4d67-8f27-01131fc59750");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "37746149-97d2-4ec8-8074-ceea9f48246b", "User", "USER" },
                    { "bc9fd39e-a1be-4f7f-aa91-725f964b9ddd", "bc9fd39e-a1be-4f7f-aa91-725f964b9ddd", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "333072a1-22a3-4f2f-9c6b-26cd1143242a", "AQAAAAIAAYagAAAAEK433Z/oYUPB6PnZuMgu3QMlR6PRQGa87icKV7ryvE8cIpC34VyzB+O1Gy6lzTqOcQ==", "c34748f4-9842-4cfd-9665-887e28239e15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae78ffbb-27ea-4d58-9b50-bf98437ef7c0", "AQAAAAIAAYagAAAAEJ0EfayAotJAwbzn4E2IfXVM+CbU6g3Ln3rcFVDY3ADH4vfizAAjnSGkjlx1SSlAyQ==", "742b3032-36b6-4427-8e76-b64381d66307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0df8ee-2125-45e6-881d-da1304f93653", "AQAAAAIAAYagAAAAEA8nETLhRFLvvLPCo6646VMNqLkfyusLDjipCSWg7wAjnbQdIng2hMOs3VeEypsXpg==", "12bf2cea-6b41-46ce-a34f-ae7140f8a2c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "891a1656-423c-43ab-9fcb-2dcfe6f48e28", "AQAAAAIAAYagAAAAEDWAgPgfNTSLqcfDhXUckvQsLT5AdFOl5hvacRXPWee1gVJ/6yFxh8cVL0i6V9oV1w==", "fcc8b482-13e0-4c64-a3df-0d26f32309ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c628d44b-a38f-4cf7-9e46-6d14f57a7508", "AQAAAAIAAYagAAAAEPfRaJGVYxalCkTC2YmoblnjgZbUyHHv1p6oMYj+SfT792Tw8AEv3j6NsjGTdKeuUQ==", "a763d9df-4a4e-4670-8ffb-0437a701815a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dadab6e-b41e-48b7-ba09-57fbe58b4724", "AQAAAAIAAYagAAAAELWVXqRDnsprrpiyK6z2bp7rc0zCLQuiu/epJt/L4CQS4L8naZ3c7qVyAKev4EERRA==", "bd6d519b-685b-45d4-ae54-3da02ec30553" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f53e9421-b0ac-4959-9f57-48f0d59f95a2", "AQAAAAIAAYagAAAAEO7hEDu1fmZQKu4MQMsGvaQMPtBzo6v/zpGGhbKctewAfyQz7CD9LqSvgcExecQsKg==", "fb35a9b0-d6dc-417d-aeed-f37de18c121f" });

            migrationBuilder.InsertData(
                table: "RSVPs",
                columns: new[] { "Id", "EventId", "Status", "UserId" },
                values: new object[,]
                {
                    { 4, 2, 0, "043d41f5-929a-4e4d-b23a-d288d16eb967" },
                    { 5, 3, 0, "043d41f5-929a-4e4d-b23a-d288d16eb967" },
                    { 6, 6, 0, "043d41f5-929a-4e4d-b23a-d288d16eb967" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "37746149-97d2-4ec8-8074-ceea9f48246b", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "bc9fd39e-a1be-4f7f-aa91-725f964b9ddd", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37746149-97d2-4ec8-8074-ceea9f48246b", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37746149-97d2-4ec8-8074-ceea9f48246b", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37746149-97d2-4ec8-8074-ceea9f48246b", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37746149-97d2-4ec8-8074-ceea9f48246b", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37746149-97d2-4ec8-8074-ceea9f48246b", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37746149-97d2-4ec8-8074-ceea9f48246b", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc9fd39e-a1be-4f7f-aa91-725f964b9ddd", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" });

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37746149-97d2-4ec8-8074-ceea9f48246b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc9fd39e-a1be-4f7f-aa91-725f964b9ddd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3873ef0e-19ce-4cc2-a7a4-9163cd130e01", "3873ef0e-19ce-4cc2-a7a4-9163cd130e01", "Admin", "ADMIN" },
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "9687eda2-8604-4d67-8f27-01131fc59750", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7a00ed1-8722-4f7c-917b-be60f12f77ca", "AQAAAAIAAYagAAAAEOmw7yVshDIBp+hNHLW/mEso4R1oQUpJhU8u9DftMG7P0LIwtCqerU0ADqiSGcLFwg==", "cfd49a9f-ab83-4987-91a1-1ad72349fe7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e56a1a2-fbc2-4a78-9633-c50c72deb6e6", "AQAAAAIAAYagAAAAEBrBnt82s7nbiki8hw0l+RxxFEYVu5fbLYVw9Qtxv7oFE/CE0XbDfbpgxmfNLPDisw==", "fa30ec4c-11e8-4f9a-991f-0e097e06d130" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55d22752-3dcb-420b-b752-35c19a86adf5", "AQAAAAIAAYagAAAAELhyVWJ6uFOxmkbMVo/tbqo4DTWu85zODdZJluNzf3bEDKb7xDpPsotEJIctXilpmw==", "45fbae3f-ba58-489c-8a77-3fa64b9eaa66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf129644-3763-43ea-bd8d-f7948f629b94", "AQAAAAIAAYagAAAAEAjIBQpN63OJllzXR0vYpQyDuwMKizoA3zpnJ9KhLSqF7HNAsGBR90hiLTcBNPad+g==", "5188daae-cc48-42b5-b611-f4370e5afeeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25cf8e57-4624-4c06-9b55-8808f0ea2a9d", "AQAAAAIAAYagAAAAEDonj+u+YAXotbx2MXb3pdNEaA8PagWxtq2CTz0aYO2SGMFFYXdYM+lGrL8fzrqX8w==", "9c34eddc-c013-4565-944b-e0e1aa4e811a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea461fdc-7bc2-4d7e-b29b-d61ce19ca042", "AQAAAAIAAYagAAAAEJlBFC2FNLpwZnD4myCzBNRLX5NbXc2IuuErHXchBbNfbySSHVSoyBzi53ziV+X8Vg==", "bd85cd93-8acb-4296-8878-54f4a0fd7e17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c79acf3c-6303-472f-8624-c49247c8b0bc", "AQAAAAIAAYagAAAAEI8+5EUWvD5rKfTA4GQfW0pkZzv6VD2wi0+Lg1Hsh9CE5+q6g6MSb9ZhAhRXVhzB0A==", "2b6c80b0-25f6-4ec8-8210-8f1037846162" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "9687eda2-8604-4d67-8f27-01131fc59750", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "3873ef0e-19ce-4cc2-a7a4-9163cd130e01", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
                });
        }
    }
}
