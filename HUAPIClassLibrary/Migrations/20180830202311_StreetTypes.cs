using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HUAPIClassLibrary.Migrations
{
    public partial class StreetTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StreetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetTypes", x => x.Id);
                });

            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Alley", "Alley" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Avenue", "Ave" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Bay", "Bay" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Boulevard", "Blvd" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Circle", "Cir" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Corners", "Crnrs" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Court", "Crt" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Cove", "Cove" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Creek", "Crk" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Crescent", "Cres" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Drive", "Dr" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Garden", "Gdn" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Gardens", "Gdns" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Gate", "Gate" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Glen", "Glen" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Grove", "Grove" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Heights", "Hts" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Highway", "Hwy" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Hill", "Hill" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Lane", "Lane" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Line", "Line" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Park", "Pk" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Parkway", "Pky" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Place", "Pl" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Point", "Pt" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Road", "Rd" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Sideroad", "Siderd" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Square", "Sq" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Street", "St" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Subdivision", "Subdiv" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Terrace", "Terr" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Townline", "Tline" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Trace", "Trace" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Trail", "Trail" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Walk", "Walk" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Way", "Way" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Manor", "Manor" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Path", "Path" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Pathway", "Ptway" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Rise", "Rise" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "View", "View" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Villas", "Villas" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Close", "Close" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Circuit", "Circt" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Expressway", "Expswy" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Freeway", "Frwy" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Green", "Green" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Heath", "Heath" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Landing", "Landng" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Parade", "Parade" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "End", "End" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Mews", "Mews" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Plaza", "Plaza" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Abbey", "Abbey" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Acres", "Acres" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Beach", "Beach" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Bend", "Bend" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "By-pass", "Bypass" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Byway", "Byway" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Campus", "Campus" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Common", "Common" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Concession", "Conc" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Crossing", "Cross" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Cul-de-sac", "Cds" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Dale", "Dale" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Dell", "Dell" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Diversion", "Divers" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Downs", "Downs" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Esplanade", "Espl" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Estates", "Estate" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Extension", "Exten" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Farm", "Farm" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Field", "Field" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Forest", "Forest" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Front", "Front" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Glade", "Glade" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Grounds", "Grnds" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Harbour", "Harbr" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Highlands", "Hghlds" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Hollow", "Hollow" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Impasse", "Imp" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Inlet", "Inlet" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Island", "Island" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Key", "Key" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Knoll", "Knoll" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Limits", "Lmts" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Link", "Link" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Lookout", "Lkout" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Loop", "Loop" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Mall", "Mall" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Maze", "Maze" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Meadow", "Meadow" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Moor", "Moor" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Mount", "Mount" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Mountain", "Mtn" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Orchard", "Orch" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Passage", "Pass" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Pines", "Pines" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Plateau", "Plat" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Pointe", "Pointe" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Port", "Port" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Private", "Pvt" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Promenade", "Prom" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Quay", "Quay" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Ramp", "Ramp" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Range", "Range" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Ridge", "Ridge" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Route", "Rte" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Row", "Row" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Run", "Run" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Thicket", "Thick" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Towers", "Towers" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Turnabout", "Trnabt" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Vale", "Vale" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Via", "Via" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Village", "Villge" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Vista", "Vista" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Wharf", "Wharf" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Wood", "Wood" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Wynd", "Wynd" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Amphitheatre", "Amph" });
            migrationBuilder.InsertData("StreetTypes", new string[] { "Type", "Code" }, new string[] { "Laneway", "Laneway" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StreetTypes");
        }
    }
}
