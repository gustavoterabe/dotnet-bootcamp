using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAgendamentoApi.Migrations
{
    /// <inheritdoc />
    public partial class EditTableTarefasDataDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 9, 21, 23, 24, 623, DateTimeKind.Local).AddTicks(7881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 9, 21, 23, 24, 623, DateTimeKind.Local).AddTicks(7881));
        }
    }
}
