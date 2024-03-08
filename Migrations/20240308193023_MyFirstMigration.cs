using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Koszty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWystawieniaFaktury = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NumerFaktury = table.Column<string>(type: "text", nullable: true),
                    NipFirmy = table.Column<string>(type: "text", nullable: true),
                    OpisKosztu = table.Column<string>(type: "text", nullable: true),
                    RodzajKosztu = table.Column<string>(type: "text", nullable: true),
                    WartoscNetto = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscVat = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscBrutto = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koszty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Przychody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWystawieniaFaktury = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TerminPlatnosci = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NumerFaktury = table.Column<string>(type: "text", nullable: true),
                    NipKlienta = table.Column<string>(type: "text", nullable: true),
                    OpisFaktury = table.Column<string>(type: "text", nullable: true),
                    WartoscNetto = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscVat = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscBrutto = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przychody", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Koszty");

            migrationBuilder.DropTable(
                name: "Przychody");
        }
    }
}
