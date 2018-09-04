using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Profile7ClassLibrary.Migrations.ProfileDBData
{
    public partial class huapiGetAllCustomForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[huapiGetAllCustomForms] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

select cdo_transdata.oid, dbo.GETTEXTBYTAG(cdo_transdata.TEXTS, 'NM') as Description, CDO_TRANSDATA.DT_MODIFIED as Created, CDO_TRANSDATA.VERSIONMIN as Version, CDO_TERMSET_TERM.CODE as Code
FROM CDO_TERMSET_TERM
	inner join CDO_TRANSDATA on CDO_TERMSET_TERM.OID = CDO_TRANSDATA.TERM
	where CDO_TRANSDATA.Versionmax > 1000000 and CDO_TRANSDATA.Collection is null and dbo.GetTextByTag(cdo_transdata.TEXTS, 'TI') = ''
	order by Description

END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[huapiGetAllCustomForms]";
            migrationBuilder.Sql(sp);
        }
    }
}
