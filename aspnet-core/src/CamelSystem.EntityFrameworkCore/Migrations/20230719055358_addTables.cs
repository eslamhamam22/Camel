using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CamelSystem.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camels_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Camels_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Camels_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AnthropometricMeasurements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoulderHeight = table.Column<double>(type: "float", nullable: false),
                    ChestWidth = table.Column<double>(type: "float", nullable: false),
                    HumpGirth = table.Column<double>(type: "float", nullable: false),
                    LiveWeight = table.Column<double>(type: "float", nullable: false),
                    CamelLength = table.Column<double>(type: "float", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    FatRatioCoefficient = table.Column<double>(type: "float", nullable: false),
                    MuscleWeight = table.Column<double>(type: "float", nullable: false),
                    CamelId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnthropometricMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnthropometricMeasurements_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AnthropometricMeasurements_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AnthropometricMeasurements_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AnthropometricMeasurements_Camels_CamelId",
                        column: x => x.CamelId,
                        principalTable: "Camels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MechanicalMeasurements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalWeight = table.Column<double>(type: "float", nullable: false),
                    StrokeDistance = table.Column<double>(type: "float", nullable: false),
                    Work = table.Column<double>(type: "float", nullable: false),
                    StrokTime = table.Column<double>(type: "float", nullable: false),
                    GenralAbility = table.Column<double>(type: "float", nullable: false),
                    Velocity = table.Column<double>(type: "float", nullable: false),
                    Gravity = table.Column<double>(type: "float", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    LengthCycle = table.Column<double>(type: "float", nullable: false),
                    InitialVelocityTime = table.Column<double>(type: "float", nullable: false),
                    FinalVelocityTime = table.Column<double>(type: "float", nullable: false),
                    Acceleration = table.Column<double>(type: "float", nullable: false),
                    MotionAmount = table.Column<double>(type: "float", nullable: false),
                    MotionEnergy = table.Column<double>(type: "float", nullable: false),
                    CamelId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MechanicalMeasurements_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MechanicalMeasurements_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MechanicalMeasurements_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MechanicalMeasurements_Camels_CamelId",
                        column: x => x.CamelId,
                        principalTable: "Camels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnthropometricMeasurements_CamelId",
                table: "AnthropometricMeasurements",
                column: "CamelId");

            migrationBuilder.CreateIndex(
                name: "IX_AnthropometricMeasurements_CreatorUserId",
                table: "AnthropometricMeasurements",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnthropometricMeasurements_DeleterUserId",
                table: "AnthropometricMeasurements",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnthropometricMeasurements_LastModifierUserId",
                table: "AnthropometricMeasurements",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Camels_CreatorUserId",
                table: "Camels",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Camels_DeleterUserId",
                table: "Camels",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Camels_LastModifierUserId",
                table: "Camels",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicalMeasurements_CamelId",
                table: "MechanicalMeasurements",
                column: "CamelId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicalMeasurements_CreatorUserId",
                table: "MechanicalMeasurements",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicalMeasurements_DeleterUserId",
                table: "MechanicalMeasurements",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicalMeasurements_LastModifierUserId",
                table: "MechanicalMeasurements",
                column: "LastModifierUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnthropometricMeasurements");

            migrationBuilder.DropTable(
                name: "MechanicalMeasurements");

            migrationBuilder.DropTable(
                name: "Camels");
        }
    }
}
