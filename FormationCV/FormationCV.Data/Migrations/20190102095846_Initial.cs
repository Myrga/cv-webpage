using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FormationCV.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    DateDeNaissance = table.Column<DateTime>(nullable: false),
                    NumeroDeRue = table.Column<int>(nullable: false),
                    Rue = table.Column<string>(nullable: true),
                    CodePostal = table.Column<int>(nullable: false),
                    Commune = table.Column<string>(nullable: true),
                    Permis = table.Column<bool>(nullable: false),
                    Titre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true),
                    CVId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competences_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: true),
                    Entreprise = table.Column<string>(nullable: true),
                    Poste = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CVId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false),
                    Ecole = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Intitule = table.Column<string>(nullable: true),
                    Diplome = table.Column<string>(nullable: true),
                    CVId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formations_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true),
                    CVId = table.Column<int>(nullable: false),
                    Niveau = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Langues_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competences_CVId",
                table: "Competences",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CVId",
                table: "Experiences",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_CVId",
                table: "Formations",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Langues_CVId",
                table: "Langues",
                column: "CVId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competences");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "Langues");

            migrationBuilder.DropTable(
                name: "CVs");
        }
    }
}
