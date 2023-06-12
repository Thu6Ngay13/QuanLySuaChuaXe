using System;
using System.Linq;
using System.Data;
using QuanLySuaChuaXe_Entity;

namespace BLL
{
    public class BLL_Tho
    {
        public BLL_Tho() { }

        public DataTable LayTho()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("HoTen_Tho", typeof(string));
            dataTable.Columns.Add("GioiTinh_Tho", typeof(bool));
            dataTable.Columns.Add("NgaySinh_Tho", typeof(DateTime));
            dataTable.Columns.Add("DiaChi_Tho", typeof(string));
            dataTable.Columns.Add("Luong_Tho", typeof(float));
            dataTable.Columns.Add("ID_NhomTho", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from tho in quanly_SuaChuaXe.Thoes
                        select tho;


                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.HoTen_Tho,
                            item.GioiTinh_Tho,
                            item.NgaySinh_Tho,
                            item.DiaChi_Tho,
                            item.Luong_Tho,
                            item.ID_NhomTho
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable LayTho_CongViec(string id_CongViec)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("ID_NhomTho", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from tho in quanly_SuaChuaXe.Thoes
                        from congviec in tho.CongViecs
                        where congviec.ID_CongViec == id_CongViec.Trim()
                        select tho;


                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.HoTen_Tho
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable LayTho_NhomTho(string id_NhomTho)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from tho in quanly_SuaChuaXe.Thoes
                        where tho.NhomTho.ID_NhomTho == id_NhomTho.Trim()
                        select new
                        {
                            tho.ID_Tho
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable LayTho_HopDong_CongViec(
            string id_HopDong,
            string id_CongViec)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("ID_NhomTho", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = from tho in quanly_SuaChuaXe.Thoes
                                 from chiTietHopDong in tho.ChiTietHopDongs
                                 where
                                    (string.IsNullOrEmpty(id_HopDong.Trim()) || chiTietHopDong.ID_HopDong == id_HopDong.Trim()) &&
                                    (string.IsNullOrEmpty(id_CongViec.Trim()) || chiTietHopDong.ID_CongViec == id_CongViec.Trim())
                                 select new
                                 {
                                     tho.ID_Tho,
                                     tho.HoTen_Tho
                                 };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.HoTen_Tho
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimKiemTho(
            string id_Tho,
            string hoten_Tho,
            bool gioitinh_Tho,
            DateTime ngaysinh_Tho,
            string diachi_Tho,
            string dieukien,
            float luong_Tho,
            string id_NhomTho)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("HoTen_Tho", typeof(string));
            dataTable.Columns.Add("GioiTinh_Tho", typeof(bool));
            dataTable.Columns.Add("NgaySinh_Tho", typeof(DateTime));
            dataTable.Columns.Add("DiaChi_Tho", typeof(string));
            dataTable.Columns.Add("Luong_Tho", typeof(float));
            dataTable.Columns.Add("ID_NhomTho", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = from tho in quanly_SuaChuaXe.Thoes
                                 where
                                     (string.IsNullOrEmpty(id_Tho.Trim()) || tho.ID_Tho == id_Tho.Trim()) &&
                                     (string.IsNullOrEmpty(hoten_Tho.Trim()) || tho.HoTen_Tho.Contains(hoten_Tho.Trim())) &&
                                     gioitinh_Tho == tho.GioiTinh_Tho &&
                                     ngaysinh_Tho == tho.NgaySinh_Tho &&
                                     (string.IsNullOrEmpty(diachi_Tho.Trim()) || tho.DiaChi_Tho.Contains(diachi_Tho.Trim())) &&
                                     ((dieukien == ">" && tho.Luong_Tho > luong_Tho) ||
                                     (dieukien == "<" && tho.Luong_Tho < luong_Tho) ||
                                     (dieukien == "=" && tho.Luong_Tho == luong_Tho)) &&
                                     (string.IsNullOrEmpty(id_NhomTho.Trim()) || tho.ID_NhomTho == id_NhomTho.Trim())
                                 select tho;


                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.HoTen_Tho,
                            item.GioiTinh_Tho,
                            item.NgaySinh_Tho,
                            item.DiaChi_Tho,
                            item.Luong_Tho,
                            item.ID_NhomTho
                        );
                    }
                }
            }
            catch { }

            return dataTable;

        }

        public bool ThemTho(
            string id_Tho,
            string hoten_Tho,
            bool gioitinh_Tho,
            DateTime ngaysinh_Tho,
            string diachi_Tho,
            float luong_Tho,
            string id_NhomTho)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    Tho tho = new Tho();
                    tho.ID_Tho = id_Tho.Trim();
                    tho.HoTen_Tho = hoten_Tho.Trim();
                    tho.GioiTinh_Tho = gioitinh_Tho;
                    tho.NgaySinh_Tho = ngaysinh_Tho;
                    tho.DiaChi_Tho = diachi_Tho.Trim();
                    tho.Luong_Tho = luong_Tho;
                    tho.ID_NhomTho = id_NhomTho.Trim();

                    quanly_SuaChuaXe.Thoes.Add(tho);
                    quanly_SuaChuaXe.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaTho(string id_Tho)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    Tho tho = new Tho();
                    tho.ID_Tho = id_Tho.Trim();
                    quanly_SuaChuaXe.Thoes.Attach(tho);
                    quanly_SuaChuaXe.Thoes.Remove(tho);
                    quanly_SuaChuaXe.SaveChanges();
                }


            }
            catch
            {
                return false;
            }
            return true;
        }

        // CapNhatTho() --> OK
        public bool CapNhatTho(
            string id_Tho,
            string hoten_Tho,
            bool gioitinh_Tho,
            DateTime ngaysinh_Tho,
            string diachi_Tho,
            float luong_Tho,
            string id_NhomTho)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var reuslt = (from tho in quanly_SuaChuaXe.Thoes
                                  where tho.ID_Tho == id_Tho.Trim()
                                  select tho).SingleOrDefault();

                    if (reuslt == null) return true;

                    reuslt.HoTen_Tho = hoten_Tho.Trim();
                    reuslt.GioiTinh_Tho = gioitinh_Tho;
                    reuslt.NgaySinh_Tho = ngaysinh_Tho;
                    reuslt.DiaChi_Tho = diachi_Tho.Trim();
                    reuslt.Luong_Tho = luong_Tho;
                    reuslt.ID_NhomTho = id_NhomTho.Trim();

                    quanly_SuaChuaXe.SaveChanges();

                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool CapNhatTho_ID_Tho(string id_Tho)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var reuslt = (from tho in quanly_SuaChuaXe.Thoes
                                  where tho.ID_Tho == id_Tho.Trim()
                                  select tho).SingleOrDefault();

                    if (reuslt == null) return true;

                    reuslt.ID_NhomTho = null;
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