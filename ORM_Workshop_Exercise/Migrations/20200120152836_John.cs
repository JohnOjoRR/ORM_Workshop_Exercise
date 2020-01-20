using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM_Workshop_Exercise.Migrations
{
    public partial class John : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Illness",
                columns: table => new
                {
                    IllnessId = table.Column<Guid>(nullable: false),
                    IllnessName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illness", x => x.IllnessId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<Guid>(nullable: false),
                    PersonName = table.Column<string>(nullable: true),
                    PersonSurname = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    PersonIDnumber = table.Column<string>(nullable: true),
                    PersonEmail = table.Column<string>(nullable: true),
                    PersonContactNumber = table.Column<string>(nullable: true),
                    Active = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: true),
                    PersonId1 = table.Column<Guid>(nullable: true),
                    IllnessId = table.Column<Guid>(nullable: true),
                    DoctorId = table.Column<Guid>(nullable: true),
                    Doctor_PersonId1 = table.Column<Guid>(nullable: true),
                    Specialist = table.Column<int>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Illness_IllnessId",
                        column: x => x.IllnessId,
                        principalTable: "Illness",
                        principalColumn: "IllnessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Person_Doctor_PersonId1",
                        column: x => x.Doctor_PersonId1,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitsId = table.Column<Guid>(nullable: false),
                    DoctorId = table.Column<Guid>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitsId);
                    table.ForeignKey(
                        name: "FK_Visits_Person_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Person_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_IllnessId",
                table: "Person",
                column: "IllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonId1",
                table: "Person",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Doctor_PersonId1",
                table: "Person",
                column: "Doctor_PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ClientId",
                table: "Visits",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DoctorId",
                table: "Visits",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Illness");
        }
    }
}
