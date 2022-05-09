using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_5S1.Data.Migrations
{
    public partial class init41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Normes",
                columns: table => new
                {
                    normeId = table.Column<Guid>(nullable: false),
                    designation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Normes", x => x.normeId);
                });

            migrationBuilder.CreateTable(
                name: "Pole",
                columns: table => new
                {
                    PoleId = table.Column<Guid>(nullable: false),
                    PoleName = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pole", x => x.PoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<Guid>(nullable: false),
                    userName = table.Column<string>(nullable: true),
                    userRole = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    userimage = table.Column<string>(nullable: true),
                    userpassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "criteres",
                columns: table => new
                {
                    critereId = table.Column<Guid>(nullable: false),
                    criterelabel = table.Column<string>(nullable: true),
                    NormeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_criteres", x => x.critereId);
                    table.ForeignKey(
                        name: "FK_criteres_Normes_NormeId",
                        column: x => x.NormeId,
                        principalTable: "Normes",
                        principalColumn: "normeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filiale",
                columns: table => new
                {
                    FilialId = table.Column<Guid>(nullable: false),
                    filialName = table.Column<string>(nullable: true),
                    poleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiale", x => x.FilialId);
                    table.ForeignKey(
                        name: "FK_Filiale_Pole_poleId",
                        column: x => x.poleId,
                        principalTable: "Pole",
                        principalColumn: "PoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilLocal",
                columns: table => new
                {
                    LocallId = table.Column<Guid>(nullable: false),
                    localdescription = table.Column<string>(nullable: true),
                    Filialeid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilLocal", x => x.LocallId);
                    table.ForeignKey(
                        name: "FK_FilLocal_Filiale_Filialeid",
                        column: x => x.Filialeid,
                        principalTable: "Filiale",
                        principalColumn: "FilialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    note = table.Column<float>(nullable: false),
                    comment = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    date_notation = table.Column<DateTime>(nullable: false),
                    critereid = table.Column<Guid>(nullable: false),
                    Userid = table.Column<Guid>(nullable: false),
                    evaluer = table.Column<Guid>(nullable: false),
                    FilLocalid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notation_FilLocal_FilLocalid",
                        column: x => x.FilLocalid,
                        principalTable: "FilLocal",
                        principalColumn: "LocallId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_notation_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_notation_criteres_critereid",
                        column: x => x.critereid,
                        principalTable: "criteres",
                        principalColumn: "critereId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "plan_action",
                columns: table => new
                {
                    planId = table.Column<Guid>(nullable: false),
                    notationid = table.Column<Guid>(nullable: false),
                    Plandescription = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    planDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plan_action", x => x.planId);
                    table.ForeignKey(
                        name: "FK_plan_action_notation_notationid",
                        column: x => x.notationid,
                        principalTable: "notation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_criteres_NormeId",
                table: "criteres",
                column: "NormeId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiale_poleId",
                table: "Filiale",
                column: "poleId");

            migrationBuilder.CreateIndex(
                name: "IX_FilLocal_Filialeid",
                table: "FilLocal",
                column: "Filialeid");

            migrationBuilder.CreateIndex(
                name: "IX_notation_FilLocalid",
                table: "notation",
                column: "FilLocalid");

            migrationBuilder.CreateIndex(
                name: "IX_notation_Userid",
                table: "notation",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_notation_critereid",
                table: "notation",
                column: "critereid");

            migrationBuilder.CreateIndex(
                name: "IX_plan_action_notationid",
                table: "plan_action",
                column: "notationid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "plan_action");

            migrationBuilder.DropTable(
                name: "notation");

            migrationBuilder.DropTable(
                name: "FilLocal");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "criteres");

            migrationBuilder.DropTable(
                name: "Filiale");

            migrationBuilder.DropTable(
                name: "Normes");

            migrationBuilder.DropTable(
                name: "Pole");
        }
    }
}
