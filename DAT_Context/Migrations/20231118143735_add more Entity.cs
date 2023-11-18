using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAT_Context.Migrations
{
    public partial class addmoreEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Ca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenCa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBatDau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuyenNganhChaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuyenNganh_ChuyenNganh_ChuyenNganhChaId",
                        column: x => x.ChuyenNganhChaId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KiHoc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKiHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiangVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenGiangVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuyenNganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiangVien_ChuyenNganh_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuyenNganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lop_ChuyenNganh_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSinhVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuyenNganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhVien_ChuyenNganh_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganhMonHoc",
                columns: table => new
                {
                    ChuyenNganhsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonHocsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganhMonHoc", x => new { x.ChuyenNganhsId, x.MonHocsId });
                    table.ForeignKey(
                        name: "FK_ChuyenNganhMonHoc_ChuyenNganh_ChuyenNganhsId",
                        column: x => x.ChuyenNganhsId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuyenNganhMonHoc_MonHoc_MonHocsId",
                        column: x => x.MonHocsId,
                        principalTable: "MonHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KiHocLop",
                columns: table => new
                {
                    KiHocsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiHocLop", x => new { x.KiHocsId, x.LopsId });
                    table.ForeignKey(
                        name: "FK_KiHocLop_KiHoc_KiHocsId",
                        column: x => x.KiHocsId,
                        principalTable: "KiHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KiHocLop_Lop_LopsId",
                        column: x => x.LopsId,
                        principalTable: "Lop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichHoc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopHocId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonHocId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiangVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaLichThi = table.Column<bool>(type: "bit", nullable: false),
                    SoSV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichHoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichHoc_Ca_CaID",
                        column: x => x.CaID,
                        principalTable: "Ca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHoc_GiangVien_GiangVienId",
                        column: x => x.GiangVienId,
                        principalTable: "GiangVien",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LichHoc_Lop_LopHocId",
                        column: x => x.LopHocId,
                        principalTable: "Lop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHoc_MonHoc_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemDanh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LichHocId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SinhVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDanh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiemDanh_LichHoc_LichHocId",
                        column: x => x.LichHocId,
                        principalTable: "LichHoc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganh_ChuyenNganhChaId",
                table: "ChuyenNganh",
                column: "ChuyenNganhChaId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganhMonHoc_MonHocsId",
                table: "ChuyenNganhMonHoc",
                column: "MonHocsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanh_LichHocId",
                table: "DiemDanh",
                column: "LichHocId");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_ChuyenNganhId",
                table: "GiangVien",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_KiHocLop_LopsId",
                table: "KiHocLop",
                column: "LopsId");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_CaID",
                table: "LichHoc",
                column: "CaID");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_GiangVienId",
                table: "LichHoc",
                column: "GiangVienId");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_LopHocId",
                table: "LichHoc",
                column: "LopHocId");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_MonHocId",
                table: "LichHoc",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_ChuyenNganhId",
                table: "Lop",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_ChuyenNganhId",
                table: "SinhVien",
                column: "ChuyenNganhId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuyenNganhMonHoc");

            migrationBuilder.DropTable(
                name: "DiemDanh");

            migrationBuilder.DropTable(
                name: "KiHocLop");

            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "LichHoc");

            migrationBuilder.DropTable(
                name: "KiHoc");

            migrationBuilder.DropTable(
                name: "Ca");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "ChuyenNganh");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
