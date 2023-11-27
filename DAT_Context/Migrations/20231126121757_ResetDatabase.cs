using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAT_Context.Migrations
{
    public partial class ResetDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cas",
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
                    table.PrimaryKey("PK_Cas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganhs",
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
                    table.PrimaryKey("PK_ChuyenNganhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuyenNganhs_ChuyenNganhs_ChuyenNganhChaId",
                        column: x => x.ChuyenNganhChaId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KiHocs",
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
                    table.PrimaryKey("PK_KiHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiangViens",
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
                    table.PrimaryKey("PK_GiangViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiangViens_ChuyenNganhs_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuyenNganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lops_ChuyenNganhs_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
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
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhViens_ChuyenNganhs_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganhs",
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
                        name: "FK_ChuyenNganhMonHoc_ChuyenNganhs_ChuyenNganhsId",
                        column: x => x.ChuyenNganhsId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuyenNganhMonHoc_MonHocs_MonHocsId",
                        column: x => x.MonHocsId,
                        principalTable: "MonHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id");
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
                        name: "FK_KiHocLop_KiHocs_KiHocsId",
                        column: x => x.KiHocsId,
                        principalTable: "KiHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KiHocLop_Lops_LopsId",
                        column: x => x.LopsId,
                        principalTable: "Lops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichHocs",
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
                    table.PrimaryKey("PK_LichHocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichHocs_Cas_CaID",
                        column: x => x.CaID,
                        principalTable: "Cas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHocs_GiangViens_GiangVienId",
                        column: x => x.GiangVienId,
                        principalTable: "GiangViens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LichHocs_Lops_LopHocId",
                        column: x => x.LopHocId,
                        principalTable: "Lops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHocs_MonHocs_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemDanhs",
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
                    table.PrimaryKey("PK_DiemDanhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiemDanhs_LichHocs_LichHocId",
                        column: x => x.LichHocId,
                        principalTable: "LichHocs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RolesId",
                table: "Accounts",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganhMonHoc_MonHocsId",
                table: "ChuyenNganhMonHoc",
                column: "MonHocsId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganhs_ChuyenNganhChaId",
                table: "ChuyenNganhs",
                column: "ChuyenNganhChaId");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_LichHocId",
                table: "DiemDanhs",
                column: "LichHocId");

            migrationBuilder.CreateIndex(
                name: "IX_GiangViens_ChuyenNganhId",
                table: "GiangViens",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_KiHocLop_LopsId",
                table: "KiHocLop",
                column: "LopsId");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_CaID",
                table: "LichHocs",
                column: "CaID");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_GiangVienId",
                table: "LichHocs",
                column: "GiangVienId");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_LopHocId",
                table: "LichHocs",
                column: "LopHocId");

            migrationBuilder.CreateIndex(
                name: "IX_LichHocs_MonHocId",
                table: "LichHocs",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_ChuyenNganhId",
                table: "Lops",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_ChuyenNganhId",
                table: "SinhViens",
                column: "ChuyenNganhId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ChuyenNganhMonHoc");

            migrationBuilder.DropTable(
                name: "DiemDanhs");

            migrationBuilder.DropTable(
                name: "KiHocLop");

            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "LichHocs");

            migrationBuilder.DropTable(
                name: "KiHocs");

            migrationBuilder.DropTable(
                name: "Cas");

            migrationBuilder.DropTable(
                name: "GiangViens");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "MonHocs");

            migrationBuilder.DropTable(
                name: "ChuyenNganhs");
        }
    }
}
