﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhanCongGiangDay.Api.Models;

namespace PhanCongGiangDay.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220327161602_DataSeccon")]
    partial class DataSeccon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhanCongGiangDay.Models.GiangVien", b =>
                {
                    b.Property<int>("GiangVienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaGiangVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgaySinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quyen")
                        .HasColumnType("int");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GiangVienId");

                    b.ToTable("GiangVien");

                    b.HasData(
                        new
                        {
                            GiangVienId = 1,
                            DiaChi = "Bình Dương",
                            Email = "cntt01@gmail.com",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn Văn A",
                            MaGiangVien = "CNTT01",
                            MatKhau = "123",
                            NgaySinh = "02/07/1990",
                            Quyen = 1,
                            SoDienThoai = "0987654321"
                        },
                        new
                        {
                            GiangVienId = 2,
                            DiaChi = "Bình Dương",
                            Email = "cntt02@gmail.com",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn Văn B",
                            MaGiangVien = "CNTT02",
                            MatKhau = "123",
                            NgaySinh = "12/02/1991",
                            Quyen = 1,
                            SoDienThoai = "0987654321"
                        },
                        new
                        {
                            GiangVienId = 3,
                            DiaChi = "Bình Dương",
                            Email = "cntt03@gmail.com",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Thị C",
                            MaGiangVien = "CNTT03",
                            MatKhau = "123",
                            NgaySinh = "10/05/1990",
                            Quyen = 1,
                            SoDienThoai = "0987654321"
                        });
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.HocKy", b =>
                {
                    b.Property<int>("HocKyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HocKyThu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamHoc")
                        .HasColumnType("int");

                    b.HasKey("HocKyId");

                    b.ToTable("Hocky");

                    b.HasData(
                        new
                        {
                            HocKyId = 1,
                            HocKyThu = "1",
                            NamHoc = 2022
                        },
                        new
                        {
                            HocKyId = 2,
                            HocKyThu = "2",
                            NamHoc = 2022
                        },
                        new
                        {
                            HocKyId = 3,
                            HocKyThu = "3",
                            NamHoc = 2022
                        });
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.Khoa", b =>
                {
                    b.Property<int>("KhoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaKhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhoa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhoaId");

                    b.ToTable("Khoa");

                    b.HasData(
                        new
                        {
                            KhoaId = 1,
                            MaKhoa = "CNTT",
                            TenKhoa = "Công nghệ thông tin"
                        });
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.MonHoc", b =>
                {
                    b.Property<int>("MonHocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoTietLT")
                        .HasColumnType("int");

                    b.Property<int>("SoTietTH")
                        .HasColumnType("int");

                    b.Property<int>("SoTinChi")
                        .HasColumnType("int");

                    b.Property<string>("TenMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonHocId");

                    b.ToTable("MonHoc");

                    b.HasData(
                        new
                        {
                            MonHocId = 1,
                            MaMonHoc = "LING123",
                            SoTietLT = 30,
                            SoTietTH = 15,
                            SoTinChi = 3,
                            TenMonHoc = "Cơ sở lập trình"
                        },
                        new
                        {
                            MonHocId = 2,
                            MaMonHoc = "LING124",
                            SoTietLT = 30,
                            SoTietTH = 30,
                            SoTinChi = 4,
                            TenMonHoc = "Kỹ thuật lập trình"
                        },
                        new
                        {
                            MonHocId = 3,
                            MaMonHoc = "LING125",
                            SoTietLT = 30,
                            SoTietTH = 30,
                            SoTinChi = 4,
                            TenMonHoc = "Lập trình web"
                        });
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.NhomLop", b =>
                {
                    b.Property<int>("NhomLopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HocKyId")
                        .HasColumnType("int");

                    b.Property<int>("KhoaId")
                        .HasColumnType("int");

                    b.Property<string>("MaNhomLop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.HasKey("NhomLopId");

                    b.HasIndex("HocKyId");

                    b.HasIndex("KhoaId");

                    b.HasIndex("MonHocId");

                    b.ToTable("NhomLop");

                    b.HasData(
                        new
                        {
                            NhomLopId = 1,
                            HocKyId = 1,
                            KhoaId = 1,
                            MaNhomLop = "D19PM01",
                            MonHocId = 1
                        },
                        new
                        {
                            NhomLopId = 2,
                            HocKyId = 1,
                            KhoaId = 1,
                            MaNhomLop = "D19PM02",
                            MonHocId = 2
                        },
                        new
                        {
                            NhomLopId = 3,
                            HocKyId = 1,
                            KhoaId = 1,
                            MaNhomLop = "D19PM02",
                            MonHocId = 2
                        },
                        new
                        {
                            NhomLopId = 4,
                            HocKyId = 1,
                            KhoaId = 1,
                            MaNhomLop = "D19PM02",
                            MonHocId = 2
                        });
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.PhanCong", b =>
                {
                    b.Property<int>("PhanCongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiangVienId")
                        .HasColumnType("int");

                    b.Property<int>("NhomLopId")
                        .HasColumnType("int");

                    b.HasKey("PhanCongId");

                    b.HasIndex("GiangVienId");

                    b.HasIndex("NhomLopId");

                    b.ToTable("PhanCong");

                    b.HasData(
                        new
                        {
                            PhanCongId = 1,
                            GiangVienId = 1,
                            NhomLopId = 1
                        },
                        new
                        {
                            PhanCongId = 2,
                            GiangVienId = 2,
                            NhomLopId = 2
                        },
                        new
                        {
                            PhanCongId = 3,
                            GiangVienId = 2,
                            NhomLopId = 3
                        });
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.NhomLop", b =>
                {
                    b.HasOne("PhanCongGiangDay.Models.HocKy", "HocKy")
                        .WithMany()
                        .HasForeignKey("HocKyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhanCongGiangDay.Models.Khoa", "Khoa")
                        .WithMany()
                        .HasForeignKey("KhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhanCongGiangDay.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhanCongGiangDay.Models.PhanCong", b =>
                {
                    b.HasOne("PhanCongGiangDay.Models.GiangVien", "GiangVien")
                        .WithMany()
                        .HasForeignKey("GiangVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhanCongGiangDay.Models.NhomLop", "NhomLop")
                        .WithMany()
                        .HasForeignKey("NhomLopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}