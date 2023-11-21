using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudApp.Migrations
{
    public partial class tableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "UrlHandle",
                table: "BlogPosts",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "BlogPosts",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "PageTitle",
                table: "BlogPosts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Heading",
                table: "BlogPosts",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "FeaturedImageUrl",
                table: "BlogPosts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "BlogPosts",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "BlogPosts",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "BlogPosts",
                newName: "UrlHandle");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "BlogPosts",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BlogPosts",
                newName: "PageTitle");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "BlogPosts",
                newName: "Heading");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "BlogPosts",
                newName: "FeaturedImageUrl");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "BlogPosts",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "BlogPosts",
                newName: "Author");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "BlogPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "BlogPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
