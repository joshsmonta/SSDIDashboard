using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicData.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequisitionRequests",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReqPosition = table.Column<string>(nullable: true),
                    PosDept = table.Column<string>(nullable: true),
                    PosDiv = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PersonToReplace = table.Column<string>(nullable: true),
                    ReasonForReplacment = table.Column<string>(nullable: true),
                    Temporary = table.Column<bool>(nullable: false),
                    DurationInYears = table.Column<int>(nullable: false),
                    DurationInMonths = table.Column<int>(nullable: false),
                    RequestedBy = table.Column<string>(nullable: true),
                    ReviewedBy = table.Column<string>(nullable: true),
                    ApprovedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitionRequests", x => x.RequestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequisitionRequests");
        }
    }
}
