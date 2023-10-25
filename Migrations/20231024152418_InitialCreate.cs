using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace inecdatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "votes",
                columns: table => new
                {
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameOfRA = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    NumberOfRegisteredVoters = table.Column<int>(type: "integer", nullable: false),
                    NumberOfAccreditedVoters = table.Column<int>(type: "integer", nullable: false),
                    A = table.Column<int>(type: "integer", nullable: false),
                    AAC = table.Column<int>(type: "integer", nullable: false),
                    ADC = table.Column<int>(type: "integer", nullable: false),
                    ADP = table.Column<int>(type: "integer", nullable: false),
                    APC = table.Column<int>(type: "integer", nullable: false),
                    APM = table.Column<int>(type: "integer", nullable: false),
                    APP = table.Column<int>(type: "integer", nullable: false),
                    BP = table.Column<int>(type: "integer", nullable: false),
                    LP = table.Column<int>(type: "integer", nullable: false),
                    NNPP = table.Column<int>(type: "integer", nullable: false),
                    NRM = table.Column<int>(type: "integer", nullable: false),
                    PDP = table.Column<int>(type: "integer", nullable: false),
                    PRP = table.Column<int>(type: "integer", nullable: false),
                    SDP = table.Column<int>(type: "integer", nullable: false),
                    YPP = table.Column<int>(type: "integer", nullable: false),
                    ZLP = table.Column<int>(type: "integer", nullable: false),
                    TotalValidVotes = table.Column<int>(type: "integer", nullable: false),
                    RejectedVotes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_votes", x => x.SerialNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "votes");
        }
    }
}
