using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogsStatus",
                columns: table => new
                {
                    BlogsStatus_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogsStatus", x => x.BlogsStatus_Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusUsers",
                columns: table => new
                {
                    StatusUsers_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusUsers", x => x.StatusUsers_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Users_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Users_Name = table.Column<string>(maxLength: 255, nullable: false),
                    Users_Logins = table.Column<string>(maxLength: 255, nullable: false),
                    Users_Password = table.Column<string>(maxLength: 255, nullable: false),
                    RegistrDate = table.Column<DateTime>(nullable: false),
                    StatusUsers_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Users_Id);
                    table.ForeignKey(
                        name: "FK_Users_StatusUsers_StatusUsers_Id",
                        column: x => x.StatusUsers_Id,
                        principalTable: "StatusUsers",
                        principalColumn: "StatusUsers_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BLOGS",
                columns: table => new
                {
                    BLOGS_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Text = table.Column<string>(maxLength: 255, nullable: false),
                    Users_Id = table.Column<int>(nullable: false),
                    BlogsStatus_Id = table.Column<int>(nullable: false),
                    WritingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLOGS", x => x.BLOGS_Id);
                    table.ForeignKey(
                        name: "FK_BLOGS_BlogsStatus_BlogsStatus_Id",
                        column: x => x.BlogsStatus_Id,
                        principalTable: "BlogsStatus",
                        principalColumn: "BlogsStatus_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BLOGS_Users_Users_Id",
                        column: x => x.Users_Id,
                        principalTable: "Users",
                        principalColumn: "Users_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BLOGS_BlogsStatus_Id",
                table: "BLOGS",
                column: "BlogsStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BLOGS_Users_Id",
                table: "BLOGS",
                column: "Users_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusUsers_Id",
                table: "Users",
                column: "StatusUsers_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BLOGS");

            migrationBuilder.DropTable(
                name: "BlogsStatus");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "StatusUsers");
        }
    }
}
