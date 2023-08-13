using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CamelSystem.Migrations
{
    /// <inheritdoc />
    public partial class addCausalVariables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acceleration",
                table: "MechanicalMeasurements");

            migrationBuilder.DropColumn(
                name: "FinalVelocityTime",
                table: "MechanicalMeasurements");

            migrationBuilder.DropColumn(
                name: "InitialVelocityTime",
                table: "MechanicalMeasurements");

            migrationBuilder.DropColumn(
                name: "LengthCycle",
                table: "MechanicalMeasurements");

            migrationBuilder.DropColumn(
                name: "MotionAmount",
                table: "MechanicalMeasurements");

            migrationBuilder.RenameColumn(
                name: "MotionEnergy",
                table: "MechanicalMeasurements",
                newName: "PushingForce");

            migrationBuilder.CreateTable(
                name: "CausalVariables",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Velocity = table.Column<double>(type: "float", nullable: false),
                    KineticEnergy = table.Column<double>(type: "float", nullable: false),
                    VectorDistance = table.Column<double>(type: "float", nullable: false),
                    VectorTime = table.Column<double>(type: "float", nullable: false),
                    VectorVelocity = table.Column<double>(type: "float", nullable: false),
                    LengthCycle = table.Column<double>(type: "float", nullable: false),
                    FrequencyCycle = table.Column<double>(type: "float", nullable: false),
                    RateVelocity = table.Column<double>(type: "float", nullable: false),
                    RightFrontFootSupportTime = table.Column<double>(type: "float", nullable: false),
                    LeftFrontFootSupportTime = table.Column<double>(type: "float", nullable: false),
                    RightFootSupportTime = table.Column<double>(type: "float", nullable: false),
                    LeftFootSupportTime = table.Column<double>(type: "float", nullable: false),
                    TotalStepCycleTime = table.Column<double>(type: "float", nullable: false),
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
                    table.PrimaryKey("PK_CausalVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CausalVariables_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CausalVariables_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CausalVariables_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CausalVariables_Camels_CamelId",
                        column: x => x.CamelId,
                        principalTable: "Camels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CausalVariables_CamelId",
                table: "CausalVariables",
                column: "CamelId");

            migrationBuilder.CreateIndex(
                name: "IX_CausalVariables_CreatorUserId",
                table: "CausalVariables",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CausalVariables_DeleterUserId",
                table: "CausalVariables",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CausalVariables_LastModifierUserId",
                table: "CausalVariables",
                column: "LastModifierUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CausalVariables");

            migrationBuilder.RenameColumn(
                name: "PushingForce",
                table: "MechanicalMeasurements",
                newName: "MotionEnergy");

            migrationBuilder.AddColumn<double>(
                name: "Acceleration",
                table: "MechanicalMeasurements",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FinalVelocityTime",
                table: "MechanicalMeasurements",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "InitialVelocityTime",
                table: "MechanicalMeasurements",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LengthCycle",
                table: "MechanicalMeasurements",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MotionAmount",
                table: "MechanicalMeasurements",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
