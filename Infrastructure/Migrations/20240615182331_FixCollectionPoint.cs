using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCollectionPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionPoint_Companies_CompanyId",
                table: "CollectionPoint");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionPoint",
                table: "CollectionPoint");

            migrationBuilder.RenameTable(
                name: "CollectionPoint",
                newName: "CollectionPoints");

            migrationBuilder.RenameIndex(
                name: "IX_CollectionPoint_CompanyId",
                table: "CollectionPoints",
                newName: "IX_CollectionPoints_CompanyId");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CollectionPoints",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionPoints",
                table: "CollectionPoints",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8a850390-1512-4ff8-aa55-f0aa2a978d58");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionPoints_Companies_CompanyId",
                table: "CollectionPoints",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionPoints_Companies_CompanyId",
                table: "CollectionPoints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionPoints",
                table: "CollectionPoints");

            migrationBuilder.RenameTable(
                name: "CollectionPoints",
                newName: "CollectionPoint");

            migrationBuilder.RenameIndex(
                name: "IX_CollectionPoints_CompanyId",
                table: "CollectionPoint",
                newName: "IX_CollectionPoint_CompanyId");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CollectionPoint",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionPoint",
                table: "CollectionPoint",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "04f1496c-940b-48aa-add1-eec780fddb3b");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionPoint_Companies_CompanyId",
                table: "CollectionPoint",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
