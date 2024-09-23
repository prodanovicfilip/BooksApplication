using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksApplication.Migrations
{
    /// <inheritdoc />
    public partial class addedClientsToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Clients_ClientId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ClientId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookClient",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookClient", x => new { x.BooksId, x.ClientsId });
                    table.ForeignKey(
                        name: "FK_BookClient_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookClient_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookClient_ClientsId",
                table: "BookClient",
                column: "ClientsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookClient");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ClientId",
                table: "Books",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Clients_ClientId",
                table: "Books",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
