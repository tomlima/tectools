using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tectools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_UserBuilds_UserBuildId",
                table: "Components");

            migrationBuilder.DropIndex(
                name: "IX_Components_UserBuildId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "UserBuildId",
                table: "Components");

            migrationBuilder.CreateTable(
                name: "ComponentUserBuild",
                columns: table => new
                {
                    ComponentsId = table.Column<int>(type: "int", nullable: false),
                    UserBuildsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentUserBuild", x => new { x.ComponentsId, x.UserBuildsId });
                    table.ForeignKey(
                        name: "FK_ComponentUserBuild_Components_ComponentsId",
                        column: x => x.ComponentsId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentUserBuild_UserBuilds_UserBuildsId",
                        column: x => x.UserBuildsId,
                        principalTable: "UserBuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentUserBuild_UserBuildsId",
                table: "ComponentUserBuild",
                column: "UserBuildsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentUserBuild");

            migrationBuilder.AddColumn<int>(
                name: "UserBuildId",
                table: "Components",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Components_UserBuildId",
                table: "Components",
                column: "UserBuildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_UserBuilds_UserBuildId",
                table: "Components",
                column: "UserBuildId",
                principalTable: "UserBuilds",
                principalColumn: "Id");
        }
    }
}
