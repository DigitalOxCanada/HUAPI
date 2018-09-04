using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Profile7ClassLibrary.Migrations.ProfileDBData
{
    public partial class huapiGetFormTransData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[huapiGetFormTransData]
                    @FormName varchar(250)
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                   SELECT *
                           FROM CDO_TRANSDATA
                           WHERE(VERSIONMAX > 1000000) and COLLECTION is null
                           and dbo.GetTextByTag(TEXTS, 'TI') = ''  and dbo.GETTEXTBYTAG(TEXTS, 'NM') = '' + @FormName + ''
                    END";

                   migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[huapiGetFormTransData]";
            migrationBuilder.Sql(sp);
        }
    }
}
