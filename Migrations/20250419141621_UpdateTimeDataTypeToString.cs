using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagement.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTimeDataTypeToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f42019-5d39-4465-8fc2-29aa01e5497c", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f42019-5d39-4465-8fc2-29aa01e5497c", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f42019-5d39-4465-8fc2-29aa01e5497c", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f42019-5d39-4465-8fc2-29aa01e5497c", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f42019-5d39-4465-8fc2-29aa01e5497c", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62f42019-5d39-4465-8fc2-29aa01e5497c", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0be77fe1-6246-4355-9cd6-8964314b759f", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0be77fe1-6246-4355-9cd6-8964314b759f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62f42019-5d39-4465-8fc2-29aa01e5497c");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fb7891d-ea8f-496e-99d2-01fc3162b0fe", "3fb7891d-ea8f-496e-99d2-01fc3162b0fe", "Admin", "ADMIN" },
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "77794ff3-cdd3-42d9-a643-68ab9163a715", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "800f1801-ce71-4b59-9026-fdede81f0fe4", "AQAAAAIAAYagAAAAEOkbr+rUQucCuUgz/U9VPq2lPKM8JqlufAFHFyOM1WtDofM6Ur4omfNIDmfYA2njTA==", "8a252698-be13-40e8-9a56-67c5d5b3b4ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c5bca1d-0d12-4be7-ae73-4865fa634b3e", "AQAAAAIAAYagAAAAEPhm7t5lEl5qTFMe6qRI5ZdYCP19RC60/glad4mwhU4y4XAnRyrk01ZBDIWWB8+zTQ==", "accf7467-e6c4-4521-a935-dd3eaba020c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be1e713c-b655-4590-9a5d-48e0fd41ee76", "AQAAAAIAAYagAAAAEMMqA/A+Odd8QZz2rFUlSVgCcIWEgBB9IsARSGDiHRtw4ePNtJJl4Fof1DHsw/Cmqg==", "83aced1e-d28b-4198-9260-e9fae74ef051" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b733147-9eec-4bcc-8c47-66b17c559c10", "AQAAAAIAAYagAAAAEKkJMzNPBDqmsnYUgaMBLnyhrJ9t6XE8hw7bKTyEKrU+jHmUWasnAULOECUzJHa93Q==", "39c9c95e-3d0b-4bfb-bb4a-c826386e1662" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01dbf14d-65e5-4a69-8120-4e36d73cd7f5", "AQAAAAIAAYagAAAAEAMNetINbT9U27YRVbtpgj6GDoRTv4pg7ZKZ0iSDKf+rqRJHJA0jcE06dXdPvsdeCA==", "2ce9c686-c82a-49ee-955f-dc63fceb4f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586d1217-0568-4d3a-a72b-88250cf7633f", "AQAAAAIAAYagAAAAEBoCALpHbVzh3NJ1KCKu5f2iHIRriYVyqsegYpCms4yMEIp6kWKHzMflnd8fR2997Q==", "c7aa1510-0f87-4d89-99f8-d381da2b3f37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd19619f-ecc0-4cde-a187-cc3c808992e7", "AQAAAAIAAYagAAAAEAEgKPg7NgrN/1DYwt9ozb87Vjc9HtR8GyVCYnm94IMc82qo57VYDh1FSPLHEI5T+g==", "ce3ff4ae-f9c9-41f2-9367-283c8ee9cf01" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "77794ff3-cdd3-42d9-a643-68ab9163a715", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "3fb7891d-ea8f-496e-99d2-01fc3162b0fe", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77794ff3-cdd3-42d9-a643-68ab9163a715", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77794ff3-cdd3-42d9-a643-68ab9163a715", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77794ff3-cdd3-42d9-a643-68ab9163a715", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77794ff3-cdd3-42d9-a643-68ab9163a715", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77794ff3-cdd3-42d9-a643-68ab9163a715", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77794ff3-cdd3-42d9-a643-68ab9163a715", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3fb7891d-ea8f-496e-99d2-01fc3162b0fe", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fb7891d-ea8f-496e-99d2-01fc3162b0fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77794ff3-cdd3-42d9-a643-68ab9163a715");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "Events",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0be77fe1-6246-4355-9cd6-8964314b759f", "0be77fe1-6246-4355-9cd6-8964314b759f", "Admin", "ADMIN" },
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "62f42019-5d39-4465-8fc2-29aa01e5497c", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01316028-1571-41c2-903b-ca543285cb64", "AQAAAAIAAYagAAAAEEb0cTV/FJDrAJc7iVh45uf84OZnbnEjSz5te7cXgoksBghO67qce+YsLvNIn+jvlg==", "441fcafc-14ba-4dbc-98d8-f5b6bc676f00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5216fe16-9ba5-473b-8b99-1a9825503014", "AQAAAAIAAYagAAAAEGOe3WonV0fBQYFYOCDeeRy2jpV2J1Vc7GbiRgjvDrxZoanm6pGcB1PlsCIR4UMQLg==", "35e4ab9c-b08e-47be-9bc4-a89acd9d29d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ff2bd7e-e293-4c0d-8838-7461e42fe15b", "AQAAAAIAAYagAAAAEATdM3ksraZnXizRYT3Jh5WW+kEaeaocsYkwRc9SYuhr2V9v0uI5lHJtXfC1io4Bfw==", "65b9e5d1-09d2-4b8a-850f-6fe290a6280e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "221a8c24-c47c-49bb-8f47-32f9e0975dfd", "AQAAAAIAAYagAAAAEPU75X8v+AXVBYygf1g8xo01EIdpH/N6+4viEEWcggiigFeA4LaBUbD6AKnGmpztZg==", "ce6ab416-7c70-49ff-a135-7fdf27407809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65140154-349c-4516-93f0-ca78d8a00d41", "AQAAAAIAAYagAAAAECNWeJJaA0Ij301AchLaozsSCl/xSYFOojqlaJBxzfacYUDfx06lIJn2uRjps+k2xA==", "0e8c49af-2e9a-4efa-89a9-83337d17367f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31db1f10-35d7-4efe-8391-2e9b4a39a0f0", "AQAAAAIAAYagAAAAEIwDSIxnFdWdIgoaaWsGRu96LKcZPf++yxIX9blyBIxoS1vwN8RszEsY8/KI3i9SqA==", "2ae3184c-d156-436e-9de8-d378781e6ebe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "008dde27-cba2-4c72-947c-1e6c6c1910e2", "AQAAAAIAAYagAAAAEKDy4+udU9GSyj36ROUf0Xqra7FjSSGX+I0LtCH4Jl0HPIEE/Iv8kFXtfJ4zCNdDPA==", "692c3eec-5022-4499-b01a-b739741ba3de" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "62f42019-5d39-4465-8fc2-29aa01e5497c", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "0be77fe1-6246-4355-9cd6-8964314b759f", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
                });
        }
    }
}
