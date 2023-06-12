using System;
using System.Linq;
using System.Data;
using QuanLySuaChuaXe_Entity;

namespace BLL
{
    public class BLL_KhachHang
    {
        public BLL_KhachHang() { }

        public DataTable LayKhachHang(string id_KhachHang)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_KhachHang", typeof(string));
            dataTable.Columns.Add("HoTen_KhachHang", typeof(string));
            dataTable.Columns.Add("GioiTinh_KhachHang", typeof(bool));
            dataTable.Columns.Add("NgaySinh_KhachHang", typeof(DateTime));
            dataTable.Columns.Add("SoDienThoai_KhachHang", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from khachhang in quanly_SuaChuaXe.KhachHangs
                        where
                            (string.IsNullOrEmpty(id_KhachHang.Trim()) || khachhang.ID_KhachHang == id_KhachHang.Trim())
                        select khachhang;

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_KhachHang,
                            item.HoTen_KhachHang,
                            item.GioiTinh_KhachHang,
                            item.NgaySinh_KhachHang,
                            item.SoDienThoai_KhachHang
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimKhachHang(
            string id_KhachHang,
            string hoten_KhachHang,
            bool gioitinh_KhachHang,
            DateTime ngaysinh_KhachHang,
            string sodienthoai_KhachHang)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_KhachHang", typeof(string));
            dataTable.Columns.Add("HoTen_KhachHang", typeof(string));
            dataTable.Columns.Add("GioiTinh_KhachHang", typeof(bool));
            dataTable.Columns.Add("NgaySinh_KhachHang", typeof(DateTime));
            dataTable.Columns.Add("SoDienThoai_KhachHang", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = from khachhang in quanly_SuaChuaXe.KhachHangs
                                 where
                                     (string.IsNullOrEmpty(id_KhachHang.Trim()) || khachhang.ID_KhachHang == id_KhachHang.Trim()) &&
                                     (string.IsNullOrEmpty(hoten_KhachHang.Trim()) || khachhang.HoTen_KhachHang.Contains(hoten_KhachHang.Trim())) &&
                                     gioitinh_KhachHang == khachhang.GioiTinh_KhachHang &&
                                     ngaysinh_KhachHang == khachhang.NgaySinh_KhachHang &&
                                     (string.IsNullOrEmpty(sodienthoai_KhachHang.Trim()) || khachhang.SoDienThoai_KhachHang == sodienthoai_KhachHang.Trim())
                                 select khachhang;

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_KhachHang,
                            item.HoTen_KhachHang,
                            item.GioiTinh_KhachHang,
                            item.NgaySinh_KhachHang,
                            item.SoDienThoai_KhachHang
                        );
                    }
                }
            }
            catch { }

            return dataTable;

        }
        // --> OK
        public bool ThemKhachHang(
            string id_KhachHang,
            string hoten_KhachHang,
            bool gioitinh_KhachHang,
            DateTime ngaysinh_KhachHang,
            string sodienthoai_KhacHang)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    KhachHang khachhang = new KhachHang();

                    khachhang.ID_KhachHang = id_KhachHang.Trim();
                    khachhang.HoTen_KhachHang = hoten_KhachHang.Trim();
                    khachhang.GioiTinh_KhachHang = gioitinh_KhachHang;
                    khachhang.NgaySinh_KhachHang = ngaysinh_KhachHang;
                    khachhang.SoDienThoai_KhachHang = sodienthoai_KhacHang.Trim();

                    quanly_SuaChuaXe.KhachHangs.Add(khachhang);
                    quanly_SuaChuaXe.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        // --> OK
        public bool XoaKhachHang(string id_KhachHang)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    KhachHang khachhang = new KhachHang();
                    khachhang.ID_KhachHang = id_KhachHang.Trim();
                    quanly_SuaChuaXe.KhachHangs.Attach(khachhang);
                    quanly_SuaChuaXe.KhachHangs.Remove(khachhang);
                    quanly_SuaChuaXe.SaveChanges();

                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        // --> OK
        public bool CapNhatKhachHang(
            string id_KhachHang,
            string hoten_KhachHang,
            bool gioitinh_KhachHang,
            DateTime ngaysinh_KhachHang,
            string sodienthoai_KhacHang)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = (from khachhang in quanly_SuaChuaXe.KhachHangs
                                  where khachhang.ID_KhachHang == id_KhachHang.Trim()
                                  select khachhang).SingleOrDefault();

                    if (result == null) return true;

                    result.HoTen_KhachHang = hoten_KhachHang.Trim();
                    result.GioiTinh_KhachHang = gioitinh_KhachHang;
                    result.NgaySinh_KhachHang = ngaysinh_KhachHang;
                    result.SoDienThoai_KhachHang = sodienthoai_KhacHang.Trim();
                    quanly_SuaChuaXe.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
