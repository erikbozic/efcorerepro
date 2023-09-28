using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRepro.Migrations
{
    /// <inheritdoc />
    public partial class Migration1Linux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    SubStatus = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEntity", x => x.Id);
                    table.CheckConstraint("CK_TestEntity_TestEnum2", "\n  (Status = 'Status1' AND SubStatus IN ('Status1_SubStatus1','Status1_SubStatus2','Status1_SubStatus3','Status1_SubStatus4','Status1_SubStatus5','Status1_SubStatus6') OR\n Status = 'Status2' AND SubStatus IN ('Status2_SubStatus1','Status2_SubStatus2','Status2_SubStatus3','Status2_SubStatus4')))\n");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestEntity");
        }
    }
}
