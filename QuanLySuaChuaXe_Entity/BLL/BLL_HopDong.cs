using System;
using System.Linq;
using System.Data;
using QuanLySuaChuaXe_Entity;

namespace BLL
{
    public class BLL_HopDong
    {
        public BLL_HopDong() { }

        // --> OK
        public DataTable LayHopDong()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_HopDong", typeof(string));
            dataTable.Columns.Add("Ten_HopDong", typeof(string));
            dataTable.Columns.Add("NgayBatDau_HopDong", typeof(DateTime));
            dataTable.Columns.Add("NgayKetThuc_HopDong", typeof(DateTime));
            dataTable.Columns.Add("GiaTri_HopDong", typeof(float));
            dataTable.Columns.Add("ID_Xe", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from hopdong in quanly_SuaChuaXe.HopDongs
                        select hopdong;
                        

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_HopDong,
                            item.Ten_HopDong,
                            item.NgayBatDau_HopDong,
                            item.NgayKetThuc_HopDong,
                            item.GiaTri_HopDong,
                            item.ID_Xe
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimHopDong_Xe(string id_Xe)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_HopDong", typeof(string));
            dataTable.Columns.Add("Ten_HopDong", typeof(string));
            dataTable.Columns.Add("NgayBatDau_HopDong", typeof(DateTime));
            dataTable.Columns.Add("NgayKetThuc_HopDong", typeof(DateTime));
            dataTable.Columns.Add("GiaTri_HopDong", typeof(float));
            dataTable.Columns.Add("ID_Xe", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from hd in quanly_SuaChuaXe.HopDongs
                        join xe in quanly_SuaChuaXe.Xes on hd.ID_Xe equals xe.ID_Xe
                        where xe.ID_Xe == id_Xe.Trim()
                        select new
                        {
                            hd.ID_HopDong
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_HopDong
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        // Chưa OK 
        public DataTable TimHopDong_Xe_KhachHang(
            string ten_HopDong,
            DateTime ngaybatdau_HopDong,
            string dieukien,
            float giatri_HopDong,
            string hoten_KhachHang,
            DateTime ngaysinh_KhachHang,
            bool gioitinh_KhachHang,
            string id_Xe,
            string sodienthoai_KhachHang)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_HopDong", typeof(string));
            dataTable.Columns.Add("Ten_HopDong", typeof(string));
            dataTable.Columns.Add("NgayBatDau_HopDong", typeof(DateTime));
            dataTable.Columns.Add("NgayKetThuc_HopDong", typeof(DateTime));
            dataTable.Columns.Add("GiaTri_HopDong", typeof(float));
            dataTable.Columns.Add("ID_Xe", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = from hopdong in quanly_SuaChuaXe.HopDongs
                                 join xe in quanly_SuaChuaXe.Xes on hopdong.ID_Xe equals xe.ID_Xe
                                 join khachhang in quanly_SuaChuaXe.KhachHangs on xe.ID_KhachHang equals khachhang.ID_KhachHang
                                 where
                                     (string.IsNullOrEmpty(ten_HopDong.Trim()) || hopdong.Ten_HopDong.Contains(ten_HopDong.Trim())) &&
                                     (hopdong.NgayBatDau_HopDong >= ngaybatdau_HopDong) &&
                                     ((dieukien == ">" && hopdong.GiaTri_HopDong > giatri_HopDong) ||
                                     (dieukien == "<" && hopdong.GiaTri_HopDong < giatri_HopDong) ||
                                     (dieukien == "=" && hopdong.GiaTri_HopDong == giatri_HopDong)) &&
                                     (string.IsNullOrEmpty(hoten_KhachHang.Trim()) || khachhang.HoTen_KhachHang.Contains(hoten_KhachHang.Trim())) &&
                                     (khachhang.NgaySinh_KhachHang == ngaysinh_KhachHang) &&
                                     (khachhang.GioiTinh_KhachHang == gioitinh_KhachHang) &&
                                     (string.IsNullOrEmpty(id_Xe.Trim()) || xe.ID_Xe == id_Xe.Trim()) &&
                                     (string.IsNullOrEmpty(sodienthoai_KhachHang.Trim()) || khachhang.SoDienThoai_KhachHang == sodienthoai_KhachHang.Trim())
                                 select hopdong;

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_HopDong,
                            item.Ten_HopDong,
                            item.NgayBatDau_HopDong,
                            item.NgayKetThuc_HopDong,
                            item.GiaTri_HopDong,
                            item.ID_Xe
                        );
                    }
                }
            }
            catch { }
            return dataTable;
        }

        // --> OK
        public bool ThemHopDong(
            string id_HopDong, 
            string ten_HopDong, 
            DateTime ngaybatdau_HopDong, 
            DateTime ngayketthuc_HopDong, 
            float giatri_HopDong, 
            string id_Xe)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    HopDong hopdong = new HopDong();

                    hopdong.ID_HopDong = id_HopDong.Trim();
                    hopdong.Ten_HopDong = ten_HopDong.Trim();
                    hopdong.NgayBatDau_HopDong = ngaybatdau_HopDong;
                    hopdong.NgayKetThuc_HopDong = ngayketthuc_HopDong;
                    hopdong.GiaTri_HopDong = giatri_HopDong;
                    hopdong.ID_Xe = id_Xe.Trim();

                    quanly_SuaChuaXe.HopDongs.Add(hopdong);
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
        public bool XoaHopDong(string id_HopDong)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    HopDong hopdong = new HopDong();
                    hopdong.ID_HopDong = id_HopDong.Trim();

                    quanly_SuaChuaXe.HopDongs.Attach(hopdong);
                    quanly_SuaChuaXe.HopDongs.Remove(hopdong);
                    
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
        public bool CapNhatHopDong(
            string id_HopDong,
            string ten_HopDong,
            DateTime ngaybatdau_HopDong,
            DateTime ngayketthuc_HopDong,
            float giatri_HopDong,
            string id_Xe)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = (from hopdong in quanly_SuaChuaXe.HopDongs
                                  where hopdong.ID_HopDong == id_HopDong.Trim()
                                  select hopdong).SingleOrDefault();

                    if (result == null) return true;

                    result.Ten_HopDong = ten_HopDong.Trim();
                    result.NgayBatDau_HopDong = ngaybatdau_HopDong;
                    result.NgayKetThuc_HopDong = ngayketthuc_HopDong;
                    result.GiaTri_HopDong = giatri_HopDong;
                    result.ID_Xe = id_Xe.Trim();

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
