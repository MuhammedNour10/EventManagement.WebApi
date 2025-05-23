using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagement.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updateRSVSTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RSVPs",
                table: "RSVPs");

            migrationBuilder.DropIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs");

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
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37746149-97d2-4ec8-8074-ceea9f48246b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc9fd39e-a1be-4f7f-aa91-725f964b9ddd");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RSVPs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RSVPs",
                table: "RSVPs",
                columns: new[] { "UserId", "EventId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2739138-e964-44ef-b4f3-4e940710075f", "b2739138-e964-44ef-b4f3-4e940710075f", "Admin", "ADMIN" },
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc11f374-a5e4-4ff0-9bbc-135019fdbc2e", "AQAAAAIAAYagAAAAEChZRJNj6lQfLRR4tkMp+K5Zk9jM4cO8375PPPfc1KE0P4kRNhYLM8bvyt3nH86Z9g==", "628b6797-e84a-461a-bb49-dfd5d8affd61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb86b2e-402b-40c4-8b35-aec4ae49c45c", "AQAAAAIAAYagAAAAEOBcfpzP9/BmfvvLmwgb+MfPobPbARbxVFv7SfPKJfssr+2dRMtsha9yqC1JHQNwfw==", "35a3dca5-d879-498a-b011-75a2d67aab1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "886bb7ea-1a58-4659-b0f9-baf5f8a526f3", "AQAAAAIAAYagAAAAECsk4f6LuAXLveCWDDoF/yRzdqgVRb+GGPvS9Sfshph9oIVUAyYnpuBsLHWtlYByzA==", "22f5bd93-5ab1-4658-b770-2a8d1b7563cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "151e2191-4abc-4a31-ba70-75d0ec2b7d63", "AQAAAAIAAYagAAAAEOCeSjFG5h+ZtZYcyLmNb8eUv9V58OVckCgydL37IKwwMLSmavE7O90yewbd6PfMOg==", "8480a050-d173-48ed-935b-4e79a190baa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04a423b4-c03a-4cd3-b781-651522657d06", "AQAAAAIAAYagAAAAEPjUw7uIAd5PT2owT1x+xBVZnd58dvDO81exbjOmZJGEQ+ntsd2GMexjp35WdBI/3g==", "4865c9f8-b0e9-4f36-a653-72cd10b541e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f74fd96-a7e8-489e-bb77-3e67f5a84758", "AQAAAAIAAYagAAAAEDpVrkhk5ALOjBawxT09fUzrApUsdr5xhP6AvRs69N+rZhQhDSamtW6T6wIW+mhBiA==", "a2096417-edb3-4228-80ca-f3223696f866" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09b6ba64-8910-4002-85db-e9ef052fb89a", "AQAAAAIAAYagAAAAENcitl08S9ZuFvO74qNeInUHiccMITdNIhAszTY/zEkAPBj5UTluIa3Do/kGXDOdkw==", "84b0a2db-f6fc-4909-a6ec-cd22344a341d" });

            migrationBuilder.InsertData(
                table: "RSVPs",
                columns: new[] { "EventId", "UserId", "Status" },
                values: new object[,]
                {
                    { 2, "043d41f5-929a-4e4d-b23a-d288d16eb967", 0 },
                    { 3, "043d41f5-929a-4e4d-b23a-d288d16eb967", 0 },
                    { 6, "043d41f5-929a-4e4d-b23a-d288d16eb967", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "b2739138-e964-44ef-b4f3-4e940710075f", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RSVPs",
                table: "RSVPs");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2739138-e964-44ef-b4f3-4e940710075f", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" });

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "043d41f5-929a-4e4d-b23a-d288d16eb967" });

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 3, "043d41f5-929a-4e4d-b23a-d288d16eb967" });

            migrationBuilder.DeleteData(
                table: "RSVPs",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 6, "043d41f5-929a-4e4d-b23a-d288d16eb967" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2739138-e964-44ef-b4f3-4e940710075f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b52a5c70-c96a-4c9c-b0f4-4ab5603a10a8");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RSVPs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RSVPs",
                table: "RSVPs",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs",
                column: "UserId");
        }
    }
}
