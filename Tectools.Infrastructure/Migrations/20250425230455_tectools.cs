using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tectools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tectools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Logo = table.Column<string>(type: "longtext", nullable: false),
                    Website = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Slug = table.Column<string>(type: "longtext", nullable: false),
                    Icon = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserBuilds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBuilds", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Compabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ComponentCategoryAId = table.Column<int>(type: "int", nullable: false),
                    ComponentCategoryBId = table.Column<int>(type: "int", nullable: false),
                    RuleType = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compabilities_Categories_ComponentCategoryAId",
                        column: x => x.ComponentCategoryAId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compabilities_Categories_ComponentCategoryBId",
                        column: x => x.ComponentCategoryBId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AveragePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AffiliateUrl = table.Column<string>(type: "longtext", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    Featured = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    UserBuildId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "longtext", nullable: true),
                    SocketCompatibility = table.Column<string>(type: "longtext", nullable: true),
                    NoiseLevel = table.Column<string>(type: "longtext", nullable: true),
                    Socket = table.Column<string>(type: "longtext", nullable: true),
                    Cores = table.Column<int>(type: "int", nullable: true),
                    Threads = table.Column<int>(type: "int", nullable: true),
                    BaseClock = table.Column<string>(type: "longtext", nullable: true),
                    BoostClock = table.Column<string>(type: "longtext", nullable: true),
                    Tdp = table.Column<string>(type: "longtext", nullable: true),
                    Resolution = table.Column<string>(type: "longtext", nullable: true),
                    Size = table.Column<string>(type: "longtext", nullable: true),
                    RefreshRate = table.Column<int>(type: "int", nullable: true),
                    PanelType = table.Column<string>(type: "longtext", nullable: true),
                    Motherboard_Socket = table.Column<string>(type: "longtext", nullable: true),
                    Chipset = table.Column<string>(type: "longtext", nullable: true),
                    FormFactor = table.Column<string>(type: "longtext", nullable: true),
                    MemorySupport = table.Column<string>(type: "longtext", nullable: true),
                    MaxMemory = table.Column<int>(type: "int", nullable: true),
                    Peripheral_Type = table.Column<string>(type: "longtext", nullable: true),
                    Connection = table.Column<string>(type: "longtext", nullable: true),
                    Wattage = table.Column<int>(type: "int", nullable: true),
                    Certification = table.Column<string>(type: "longtext", nullable: true),
                    Modular = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Ram_Type = table.Column<string>(type: "longtext", nullable: true),
                    Speed = table.Column<string>(type: "longtext", nullable: true),
                    Capacity = table.Column<string>(type: "longtext", nullable: true),
                    Modules = table.Column<int>(type: "int", nullable: true),
                    Storage_Type = table.Column<string>(type: "longtext", nullable: true),
                    Storage_Capacity = table.Column<string>(type: "longtext", nullable: true),
                    Interface = table.Column<string>(type: "longtext", nullable: true),
                    ReadSpeed = table.Column<string>(type: "longtext", nullable: true),
                    WriteSpeed = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Components_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Components_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Components_UserBuilds_UserBuildId",
                        column: x => x.UserBuildId,
                        principalTable: "UserBuilds",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Compabilities_ComponentCategoryAId",
                table: "Compabilities",
                column: "ComponentCategoryAId");

            migrationBuilder.CreateIndex(
                name: "IX_Compabilities_ComponentCategoryBId",
                table: "Compabilities",
                column: "ComponentCategoryBId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_BrandId",
                table: "Components",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_CategoryId",
                table: "Components",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_UserBuildId",
                table: "Components",
                column: "UserBuildId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compabilities");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "UserBuilds");
        }
    }
}
