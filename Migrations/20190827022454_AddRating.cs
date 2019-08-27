using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class AddRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //(2019.08.27)  SQLiteではAlterColumnを受け付けないので、マイグレーションから外しておく(「Rating」カラムの追加のみが反映されればよい)
            // migrationBuilder.AlterColumn<decimal>(
            //     name: "Price",
            //     table: "Movie",
            //     type: "decimal(18,2)",
            //     nullable: false,
            //     oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
