using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRepro.Migrations
{
    /// <inheritdoc />
    public partial class Migration2Windows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_TestEntity_TestEnum2",
                table: "TestEntity");

            migrationBuilder.AddCheckConstraint(
                name: "CK_TestEntity_TestEnum2",
                table: "TestEntity",
                sql: "\r\n  (Status = 'Status1' AND SubStatus IN ('Status1_SubStatus1','Status1_SubStatus2','Status1_SubStatus3','Status1_SubStatus4','Status1_SubStatus5','Status1_SubStatus6') OR\r\n Status = 'Status2' AND SubStatus IN ('Status2_SubStatus1','Status2_SubStatus2','Status2_SubStatus3','Status2_SubStatus4')))\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_TestEntity_TestEnum2",
                table: "TestEntity");

            migrationBuilder.AddCheckConstraint(
                name: "CK_TestEntity_TestEnum2",
                table: "TestEntity",
                sql: "\n  (Status = 'Status1' AND SubStatus IN ('Status1_SubStatus1','Status1_SubStatus2','Status1_SubStatus3','Status1_SubStatus4','Status1_SubStatus5','Status1_SubStatus6') OR\n Status = 'Status2' AND SubStatus IN ('Status2_SubStatus1','Status2_SubStatus2','Status2_SubStatus3','Status2_SubStatus4')))\n");
        }
    }
}
