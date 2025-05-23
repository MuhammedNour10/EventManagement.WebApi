using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventManagement.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updateEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6655fd0-51ca-4557-9874-27bf20be094d", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6655fd0-51ca-4557-9874-27bf20be094d", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6655fd0-51ca-4557-9874-27bf20be094d", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6655fd0-51ca-4557-9874-27bf20be094d", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6655fd0-51ca-4557-9874-27bf20be094d", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6655fd0-51ca-4557-9874-27bf20be094d", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70c32e27-8b28-4e66-a299-e4e4843bf37a", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70c32e27-8b28-4e66-a299-e4e4843bf37a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6655fd0-51ca-4557-9874-27bf20be094d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70c32e27-8b28-4e66-a299-e4e4843bf37a", "70c32e27-8b28-4e66-a299-e4e4843bf37a", "Admin", "ADMIN" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "b6655fd0-51ca-4557-9874-27bf20be094d", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47c1e34b-afce-4133-a758-6d84b6e0bc85", "AQAAAAIAAYagAAAAEP31gqpp1jtFauQpvJqsHSsvuRzpfuCXhkooNhrcWEzNBFzqsysIDgbWM6yr5jFyoQ==", "bdcff4ba-edf4-40a7-8cfd-efadc5644801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8fca6c5-5c4e-4f62-b07b-e8ed06f4b43f", "AQAAAAIAAYagAAAAEBrmTFpdnnmL/HW2wkPU4FbZgf+jxWMjIk6jGfrLskRFh3K0L3sIhlVfGiW1oeZrrw==", "47a75ef4-e602-41ac-80f6-80058a425d85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9620240d-c102-4917-8d2e-af059e144f47", "AQAAAAIAAYagAAAAEFvkI+Qv3ljQ2w+oGYYwC4WskGKlvgYRlQ6cwH8U4ottJusg3qVyKqEE6Lra/yBQ+g==", "4de3b84c-f8bb-431e-925b-d0b44c7aee7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5073ef93-329b-4124-b464-65ce435a249d", "AQAAAAIAAYagAAAAEHoiy27h7GhKVAslPG2gfxjHZJidai/EGuM7/26cmKKSav+Ej+vy8wGHxP/TW+m3fQ==", "6ce8b611-6b84-4fce-9772-28b788ee9509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "928997d8-e96a-47be-a366-3ccecd9d7f4f", "AQAAAAIAAYagAAAAEIVLKK6c+SW70Z0NpM3t2W8nLBYpj44g3kXT8Synbz8DJ+mUJB7QymWCUvAbnzIAsw==", "3e4e07b9-7bc5-445d-afc6-181c5505a6d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4162d55-22a6-4dac-8acc-c5d8f67522c9", "AQAAAAIAAYagAAAAEBI0NDkYwMlJ+v/2wFJn/IYivz0muv+N7T8RqUgFr29wQvzcZQpqiXAilSqWwjwvXA==", "133c302a-840e-4466-81b2-593fe4487164" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7f8b7d4-ead4-4751-bb74-f190ce6ff000", "AQAAAAIAAYagAAAAEBoWHEobkBAuAeai+nuudmqn+f4dqWv+IP/mlCUTza9GJkdQg3yAbq1xGz/TMMPNpw==", "cd5503f5-305c-4b6c-acc7-93e935cb3343" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "A9B9D7C4-2C6E-41A7-8FA6-5B8F1DABFA75" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "B0D0E5C1-8F22-4E67-A0F1-3B8B4D3C4B92" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "C1D1F3A2-4A1E-42C3-B6F4-4E5A55B7F3A1" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "D2E2F4B3-5B2F-4F87-9F6F-5C8A5D0F4A20" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "E3F3G5C4-6C2F-4D72-9E9B-6D1B6C3A8D11" },
                    { "b6655fd0-51ca-4557-9874-27bf20be094d", "F4H4I6D5-7D3F-4E63-8F7F-7E2B7C9D4F31" },
                    { "70c32e27-8b28-4e66-a299-e4e4843bf37a", "F4H4I6D5-7D3F-4E63-8F7F-MH12MWDDG213" }
                });
        }
    }
}
