using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HUAPIClassLibrary.Migrations
{
    public partial class SMSCarrier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeltaQ",
                table: "ScrapeQuery",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "SMSCarrier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Region = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    EmailTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSCarrier", x => x.Id);
                });

            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Rogers Wireless", "@pcs.rogers.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Fido", "@fido.ca" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Telus", "@msg.telus.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Bell Mobility", "@txt.bell.ca" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Kudo Mobile", "@msg.koodomobile.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "MTS", "@text.mtsmobility.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Presidents Choice", "@txt.bell.ca" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Sasktel", "@sms.sasktel.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Solo", "@txt.bell.ca" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "Canada", "Virgin", "@vmobile.ca" });

            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "AT&T", "@txt.att.net" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Qwest", "@qwestmp.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "T-Mobile", "@tmomail.net" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Verizon", "@vtext.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Sprint", "@messaging.sprintpcs.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Sprint", "@pm.sprint.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Virgin Mobile", "@vmobl.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Nextel", "@messaging.nextel.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Alltel", "@message.alltel.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Metro PCS", "@mymetropcs.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Powertel", "@ptel.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Suncom", "@tms.suncom.com" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "U.S. Cellular", "@email.uscc.net" });
            migrationBuilder.InsertData("SMSCarrier", new string[] { "Region", "Name", "EmailTo" }, new string[] { "US", "Cingular", "@cingularme.com" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SMSCarrier");
        }
    }
}
