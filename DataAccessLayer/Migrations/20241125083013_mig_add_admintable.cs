using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_admintable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Admins tablosunu oluştur
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            // Eğer Messages tablosu yoksa oluştur
            if (!migrationBuilder.ActiveProvider.Contains("SqlServer"))
            {
                migrationBuilder.CreateTable(
                    name: "Messages",
                    columns: table => new
                    {
                        MessageID = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        Sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        Receiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                        MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Messages", x => x.MessageID);
                    });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Admins tablosunu sil
            migrationBuilder.DropTable(
                name: "Admins");

            // Eğer Messages tablosu bu migration ile oluşturulmuşsa sil
            if (!migrationBuilder.ActiveProvider.Contains("SqlServer"))
            {
                migrationBuilder.DropTable(
                    name: "Messages");
            }

            // Message2s tablosundaki sütunları tekrar ekle
            migrationBuilder.AddColumn<string>(
                name: "Receiver",
                table: "Message2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sender",
                table: "Message2s",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
