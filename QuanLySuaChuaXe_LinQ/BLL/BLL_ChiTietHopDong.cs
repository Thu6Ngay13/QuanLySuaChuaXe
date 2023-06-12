using System.Linq;
using System.Data;
using QuanLySuaChuaXe_LinQ;

namespace BLL
{
    public class BLL_ChiTietHopDong
    {
        public BLL_ChiTietHopDong() { } 

        public DataTable LayChiTietHopDong()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("ID_CongViec", typeof(string));
            dataTable.Columns.Add("ID_HopDong", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from chitiethopdong in quanly_SuaChuaXe.ChiTietHopDongs
                        select new
                        {
                            chitiethopdong.ID_Tho,
                            chitiethopdong.ID_CongViec,
                            chitiethopdong.ID_HopDong
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.ID_CongViec,
                            item.ID_HopDong
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }
        public DataTable TimChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("ID_CongViec", typeof(string));
            dataTable.Columns.Add("ID_HopDong", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result = from chiTietHopDong in quanly_SuaChuaXe.ChiTietHopDongs
                                 where
                                    (string.IsNullOrEmpty(id_Tho.Trim()) || chiTietHopDong.ID_Tho == id_Tho.Trim()) &&
                                    (string.IsNullOrEmpty(id_CongViec.Trim()) || chiTietHopDong.ID_CongViec == id_CongViec.Trim()) &&
                                    (string.IsNullOrEmpty(id_HopDong.Trim()) || chiTietHopDong.ID_HopDong == id_HopDong.Trim())
                                 select chiTietHopDong;


                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.ID_CongViec,
                            item.ID_HopDong
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public bool ThemChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {


                    ChiTietHopDong chitiethopdong = new ChiTietHopDong();
                    chitiethopdong.ID_Tho = id_Tho.Trim();
                    chitiethopdong.ID_CongViec = id_CongViec.Trim();
                    chitiethopdong.ID_HopDong = id_HopDong.Trim();

                    quanly_SuaChuaXe.ChiTietHopDongs.InsertOnSubmit(chitiethopdong);
                    quanly_SuaChuaXe.ChiTietHopDongs.Context.SubmitChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var chitiethopdong_Query = from chitiethopdong in quanly_SuaChuaXe.ChiTietHopDongs
                                               where 
                                                    chitiethopdong.ID_Tho == id_Tho.Trim() &&
                                                    chitiethopdong.ID_CongViec == id_CongViec.Trim() &&
                                                    chitiethopdong.ID_HopDong == id_HopDong.Trim()  
                                               select chitiethopdong;

                    quanly_SuaChuaXe.ChiTietHopDongs.DeleteAllOnSubmit(chitiethopdong_Query);
                    quanly_SuaChuaXe.SubmitChanges();

                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CapNhatChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        (from chitiethopdong in quanly_SuaChuaXe.ChiTietHopDongs
                         where 
                            chitiethopdong.ID_CongViec == id_CongViec.Trim() &&
                            chitiethopdong.ID_HopDong == id_HopDong.Trim()    
                         select chitiethopdong).SingleOrDefault();

                    if (result == null) return true;

                    if (id_Tho.Trim() == "") result.ID_Tho = null;
                    else result.ID_Tho = id_Tho.Trim();

                    quanly_SuaChuaXe.SubmitChanges();
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

