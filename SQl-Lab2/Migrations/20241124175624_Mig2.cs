using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQl_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Böckers_Författares_FörfattareId",
                table: "Böckers");

            migrationBuilder.DropForeignKey(
                name: "FK_Böckers_Förlags_FörlagId",
                table: "Böckers");

            migrationBuilder.DropForeignKey(
                name: "FK_LagerSaldos_Butikers_ButikId",
                table: "LagerSaldos");

            migrationBuilder.DropForeignKey(
                name: "FK_LagerSaldos_Böckers_BokIsbn",
                table: "LagerSaldos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LagerSaldos",
                table: "LagerSaldos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kunders",
                table: "Kunders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Förlags",
                table: "Förlags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Författares",
                table: "Författares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Böckers",
                table: "Böckers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Butikers",
                table: "Butikers");

            migrationBuilder.RenameTable(
                name: "LagerSaldos",
                newName: "LagerSaldo");

            migrationBuilder.RenameTable(
                name: "Kunders",
                newName: "Kunder");

            migrationBuilder.RenameTable(
                name: "Förlags",
                newName: "Förlag");

            migrationBuilder.RenameTable(
                name: "Författares",
                newName: "Författare");

            migrationBuilder.RenameTable(
                name: "Böckers",
                newName: "Böcker");

            migrationBuilder.RenameTable(
                name: "Butikers",
                newName: "Butiker");

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "LagerSaldo",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "ButikId",
                table: "LagerSaldo",
                newName: "ButikID");

            migrationBuilder.RenameColumn(
                name: "LagerId",
                table: "LagerSaldo",
                newName: "LagerID");

            migrationBuilder.RenameIndex(
                name: "IX_LagerSaldos_ButikId",
                table: "LagerSaldo",
                newName: "IX_LagerSaldo_ButikID");

            migrationBuilder.RenameIndex(
                name: "IX_LagerSaldos_BokIsbn",
                table: "LagerSaldo",
                newName: "IX_LagerSaldo_BokIsbn");

            migrationBuilder.RenameColumn(
                name: "KundId",
                table: "Kunder",
                newName: "KundID");

            migrationBuilder.RenameColumn(
                name: "FörlagId",
                table: "Förlag",
                newName: "FörlagID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Författare",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "FörlagId",
                table: "Böcker",
                newName: "FörlagID");

            migrationBuilder.RenameColumn(
                name: "FörfattareId",
                table: "Böcker",
                newName: "FörfattareID");

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "Böcker",
                newName: "ISBN");

            migrationBuilder.RenameIndex(
                name: "IX_Böckers_FörlagId",
                table: "Böcker",
                newName: "IX_Böcker_FörlagID");

            migrationBuilder.RenameIndex(
                name: "IX_Böckers_FörfattareId",
                table: "Böcker",
                newName: "IX_Böcker_FörfattareID");

            migrationBuilder.RenameColumn(
                name: "ButikId",
                table: "Butiker",
                newName: "ButikID");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "LagerSaldo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BokIsbn",
                table: "LagerSaldo",
                type: "varchar(13)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nummer",
                table: "Kunder",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FörNamn",
                table: "Kunder",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Kunder",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EfterNamn",
                table: "Kunder",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Kunder",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namn",
                table: "Förlag",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FörNamn",
                table: "Författare",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EfterNamn",
                table: "Författare",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Titel",
                table: "Böcker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Språk",
                table: "Böcker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pris",
                table: "Böcker",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Kategori",
                table: "Böcker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Böcker",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "GatuNummer",
                table: "Butiker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gata",
                table: "Butiker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ButiksNamn",
                table: "Butiker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK__LagerSal__23FED8A917AE06D1",
                table: "LagerSaldo",
                column: "LagerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Kunder__F2B5DEAC835A627F",
                table: "Kunder",
                column: "KundID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Förlag__DE6A852C74E32959",
                table: "Förlag",
                column: "FörlagID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Författa__3214EC27297E678D",
                table: "Författare",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Böcker__447D36EB2B545335",
                table: "Böcker",
                column: "ISBN");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Butiker__B5D66BFA498EDF40",
                table: "Butiker",
                column: "ButikID");

            migrationBuilder.AddForeignKey(
                name: "FK__Böcker__Författa__29221CFB",
                table: "Böcker",
                column: "FörfattareID",
                principalTable: "Författare",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK__Böcker__FörlagID__2A164134",
                table: "Böcker",
                column: "FörlagID",
                principalTable: "Förlag",
                principalColumn: "FörlagID");

            migrationBuilder.AddForeignKey(
                name: "FK_LagerSaldo_Böcker_BokIsbn",
                table: "LagerSaldo",
                column: "BokIsbn",
                principalTable: "Böcker",
                principalColumn: "ISBN");

            migrationBuilder.AddForeignKey(
                name: "FK__LagerSald__Butik__76969D2E",
                table: "LagerSaldo",
                column: "ButikID",
                principalTable: "Butiker",
                principalColumn: "ButikID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Böcker__Författa__29221CFB",
                table: "Böcker");

            migrationBuilder.DropForeignKey(
                name: "FK__Böcker__FörlagID__2A164134",
                table: "Böcker");

            migrationBuilder.DropForeignKey(
                name: "FK_LagerSaldo_Böcker_BokIsbn",
                table: "LagerSaldo");

            migrationBuilder.DropForeignKey(
                name: "FK__LagerSald__Butik__76969D2E",
                table: "LagerSaldo");

            migrationBuilder.DropPrimaryKey(
                name: "PK__LagerSal__23FED8A917AE06D1",
                table: "LagerSaldo");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Kunder__F2B5DEAC835A627F",
                table: "Kunder");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Förlag__DE6A852C74E32959",
                table: "Förlag");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Författa__3214EC27297E678D",
                table: "Författare");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Böcker__447D36EB2B545335",
                table: "Böcker");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Butiker__B5D66BFA498EDF40",
                table: "Butiker");

            migrationBuilder.RenameTable(
                name: "LagerSaldo",
                newName: "LagerSaldos");

            migrationBuilder.RenameTable(
                name: "Kunder",
                newName: "Kunders");

            migrationBuilder.RenameTable(
                name: "Förlag",
                newName: "Förlags");

            migrationBuilder.RenameTable(
                name: "Författare",
                newName: "Författares");

            migrationBuilder.RenameTable(
                name: "Böcker",
                newName: "Böckers");

            migrationBuilder.RenameTable(
                name: "Butiker",
                newName: "Butikers");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "LagerSaldos",
                newName: "Isbn");

            migrationBuilder.RenameColumn(
                name: "ButikID",
                table: "LagerSaldos",
                newName: "ButikId");

            migrationBuilder.RenameColumn(
                name: "LagerID",
                table: "LagerSaldos",
                newName: "LagerId");

            migrationBuilder.RenameIndex(
                name: "IX_LagerSaldo_ButikID",
                table: "LagerSaldos",
                newName: "IX_LagerSaldos_ButikId");

            migrationBuilder.RenameIndex(
                name: "IX_LagerSaldo_BokIsbn",
                table: "LagerSaldos",
                newName: "IX_LagerSaldos_BokIsbn");

            migrationBuilder.RenameColumn(
                name: "KundID",
                table: "Kunders",
                newName: "KundId");

            migrationBuilder.RenameColumn(
                name: "FörlagID",
                table: "Förlags",
                newName: "FörlagId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Författares",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FörlagID",
                table: "Böckers",
                newName: "FörlagId");

            migrationBuilder.RenameColumn(
                name: "FörfattareID",
                table: "Böckers",
                newName: "FörfattareId");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Böckers",
                newName: "Isbn");

            migrationBuilder.RenameIndex(
                name: "IX_Böcker_FörlagID",
                table: "Böckers",
                newName: "IX_Böckers_FörlagId");

            migrationBuilder.RenameIndex(
                name: "IX_Böcker_FörfattareID",
                table: "Böckers",
                newName: "IX_Böckers_FörfattareId");

            migrationBuilder.RenameColumn(
                name: "ButikID",
                table: "Butikers",
                newName: "ButikId");

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "LagerSaldos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BokIsbn",
                table: "LagerSaldos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nummer",
                table: "Kunders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FörNamn",
                table: "Kunders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Kunders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EfterNamn",
                table: "Kunders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Kunders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namn",
                table: "Förlags",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FörNamn",
                table: "Författares",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "EfterNamn",
                table: "Författares",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Titel",
                table: "Böckers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Språk",
                table: "Böckers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Pris",
                table: "Böckers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Kategori",
                table: "Böckers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Böckers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "GatuNummer",
                table: "Butikers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gata",
                table: "Butikers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ButiksNamn",
                table: "Butikers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LagerSaldos",
                table: "LagerSaldos",
                column: "LagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kunders",
                table: "Kunders",
                column: "KundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Förlags",
                table: "Förlags",
                column: "FörlagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Författares",
                table: "Författares",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Böckers",
                table: "Böckers",
                column: "Isbn");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Butikers",
                table: "Butikers",
                column: "ButikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Böckers_Författares_FörfattareId",
                table: "Böckers",
                column: "FörfattareId",
                principalTable: "Författares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Böckers_Förlags_FörlagId",
                table: "Böckers",
                column: "FörlagId",
                principalTable: "Förlags",
                principalColumn: "FörlagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LagerSaldos_Butikers_ButikId",
                table: "LagerSaldos",
                column: "ButikId",
                principalTable: "Butikers",
                principalColumn: "ButikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LagerSaldos_Böckers_BokIsbn",
                table: "LagerSaldos",
                column: "BokIsbn",
                principalTable: "Böckers",
                principalColumn: "Isbn");
        }
    }
}
