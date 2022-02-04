using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.DataAccess.Migrations
{
    public partial class changesMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembershipType_Members_MemberId",
                table: "MembershipType");

            migrationBuilder.DropIndex(
                name: "IX_MembershipType_MemberId",
                table: "MembershipType");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "MembershipType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "MembershipType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MembershipType_MemberId",
                table: "MembershipType",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipType_Members_MemberId",
                table: "MembershipType",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
