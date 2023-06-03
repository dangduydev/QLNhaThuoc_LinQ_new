﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Phacmarcity_ADO.NET.Class
{
    public static class StringConvert
    {
        public static string ConvertToEnumPhieuNhap(string input)
        {
            switch (input)
            {
                case "Ngày sản xuất":
                    return "NgaySX";
                case "Hạn sử dụng":
                    return "NgayHH";
                case "Ngày nhập":
                    return "NgayNhap";
                case "Mã phiếu nhập":
                    return "MaPN";
                case "Mã nhân viên":
                    return "MaNhanVien";
                case "Mã thuốc":
                    return "MaThuoc";
                case "Nhà cung cấp":
                    return "MaNhaCungCap";
                case "Số lượng":
                    return "SoLuong";
                case "Đơn giá":
                    return "DonGia";
                default:
                    return "";
            }
        }
        public static string ConvertToEnumPhieuXuat(string input)
        {
            /*            Mã phiếu xuất
                        Mã nhân viên
                        Mã khách hàng
                        Mã thuốc
                        Số lượng
                        Ngày xuất*/
            switch (input)
            {
                case "Mã phiếu xuất":
                    return "MaPX";
                case "Mã nhân viên":
                    return "MaNhanVien";
                case "Mã khách hàng":
                    return "MaKhachHang";
                case "Mã thuốc":
                    return "MaThuoc";
                case "Số lượng":
                    return "SoLuong";
                case "Ngày xuất":
                    return "NgayXuat";

                default:
                    return "";
            }
        }

        public static string ConvertToEnumSupplier(string input)
        {
            /*            Mã nhà cung cấp
                    Tên nhà cung cấp
                    Địa chỉ
                        Thông tin địa diện*/
            switch (input)
            {
                case "Mã nhà cung cấp":
                    return "MaNhaCungCap";
                case "Tên nhà cung cấp":
                    return "TenNhaCungCap";
                case "Địa chỉ":
                    return "DiaChi";
                case "Thông tin địa diện":
                    return "ThongTinDaiDien";
                default:
                    return "";
            }
        }
        public static string ConvertToEnumEmployee(string input)
        {
            switch (input)
            {
                case "Ngày sinh":
                    return "NgaySinh";
                case "Ngày vào làm":
                    return "NgayVaoLam";
                case "Mã nhân viên":
                    return "MaNhanVien";
                case "Tên nhân viên":
                    return "HoTen";
                case "Số điện thoại":
                    return "SoDienThoai";
                case "Bộ phận":
                    return "BoPhan";

                default:
                    return "";
            }
        }
        public static string ConvertToEnumClient(string input)
        {
            switch (input)
            {
                case "Mã khách hàng":
                    return "MaKhachHang";
                case "Tên khách hàng":
                    return "TenKhachHang";
                case "Số điện thoại":
                    return "SoDienThoai";
                case "Địa chỉ":
                    return "DiaChi";
                default:
                    return "";
            }
        }
        public static string ConvertToEnumMedicine(string input)
        {
            switch (input)
            {
                case "Mã thuốc":
                    return "MaThuoc";
                case "Tên thuốc":
                    return "TenThuoc";
                case "Mã hãng sản xuất":
                    return "MaHangSX";
                case "Mã nhà cung cấp":
                    return "MaNhaCungCap";
                default:
                    return string.Empty;
            }
        }
        public static string ConvertToEnumRole(string input)
        {
            switch (input)
            {
                case "Quản lý":
                    return "QuanLy";
                case "Nhân viên":
                    return "NhanVien";
                default:
                    return "";
            }
        }


    }
}
