using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTTDay09CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ntt_LoaiSanPham",
                columns: table => new
                {
                    nttId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nttMaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nttTenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nttTrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ntt_LoaiSanPham", x => x.nttId);
                    table.UniqueConstraint("AK_ntt_LoaiSanPham_nttMaLoai", x => x.nttMaLoai);
                });

            migrationBuilder.CreateTable(
                name: "ntt_SanPham",
                columns: table => new
                {
                    nttId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nttMaSP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nttTenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nttHinhAnh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    nttSoLuong = table.Column<int>(type: "int", nullable: false),
                    nttDonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    nttLoaiSPId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ntt_SanPham", x => x.nttId);
                    table.ForeignKey(
                        name: "FK_ntt_SanPham_ntt_LoaiSanPham_nttLoaiSPId",
                        column: x => x.nttLoaiSPId,
                        principalTable: "ntt_LoaiSanPham",
                        principalColumn: "nttMaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ntt_SanPham_nttLoaiSPId",
                table: "ntt_SanPham",
                column: "nttLoaiSPId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ntt_SanPham");

            migrationBuilder.DropTable(
                name: "ntt_LoaiSanPham");
        }
    }
}
