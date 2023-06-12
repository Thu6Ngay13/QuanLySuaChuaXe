using System.Linq;
using System.Data;
using QuanLySuaChuaXe_Entity;

namespace BLL
{
    public class BLL_CongViec
    {
        public BLL_CongViec() { }

        // LayCongViec() --> OK
        public DataTable LayCongViec()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_CongViec", typeof(string));
            dataTable.Columns.Add("Ten_CongViec", typeof(string));
            dataTable.Columns.Add("ID_NhomCongViec", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from congviec in quanly_SuaChuaXe.CongViecs
                        select congviec;
                        
                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_CongViec,
                            item.Ten_CongViec,
                            item.ID_NhomCongViec
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimCongViec(
            string id_CongViec,
            string ten_CongViec,
            string id_NhomCongViec)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_CongViec", typeof(string));
            dataTable.Columns.Add("Ten_CongViec", typeof(string));
            dataTable.Columns.Add("ID_NhomCongViec", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = from congviec in quanly_SuaChuaXe.CongViecs
                                 where
                                     (string.IsNullOrEmpty(id_CongViec.Trim()) || congviec.ID_CongViec == id_CongViec.Trim()) &&
                                     (string.IsNullOrEmpty(ten_CongViec.Trim()) || congviec.Ten_CongViec.Contains(ten_CongViec.Trim())) &&
                                     (string.IsNullOrEmpty(id_NhomCongViec.Trim()) || congviec.ID_NhomCongViec == id_NhomCongViec.Trim())
                                 select congviec;

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_CongViec,
                            item.Ten_CongViec,
                            item.ID_NhomCongViec
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        // ThemCongViec() --> OK
        public bool ThemCongViec(
            string id_CongViec, 
            string ten_CongViec, 
            string id_NhomCongViec)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    CongViec cv = new CongViec();
                    cv.ID_CongViec = id_CongViec.Trim();
                    cv.Ten_CongViec = ten_CongViec.Trim();
                    cv.ID_NhomCongViec = id_NhomCongViec.Trim();

                    quanly_SuaChuaXe.CongViecs.Add(cv);
                    quanly_SuaChuaXe.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        // CapNhatCongViec() --> OK
        public bool CapNhatCongViec(
            string id_CongViec,
            string ten_CongViec,
            string id_NhomCongViec)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        (from cv in quanly_SuaChuaXe.CongViecs
                         where cv.ID_CongViec == id_CongViec.Trim()
                         select cv).SingleOrDefault();

                    if (result == null) return true;

                    result.Ten_CongViec = ten_CongViec.Trim();
                    result.ID_NhomCongViec = id_NhomCongViec.Trim();
                    quanly_SuaChuaXe.SaveChanges() ;
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
