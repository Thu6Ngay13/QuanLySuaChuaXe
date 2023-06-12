using System.Linq;
using System.Data;
using QuanLySuaChuaXe_Entity;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace BLL
{
    public class BLL_KhaNang
    {
        public BLL_KhaNang() { }

        public DataTable LayKhaNang()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("ID_CongViec", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result =
                        from tho in quanly_SuaChuaXe.Thoes
                        from congviec in tho.CongViecs
                        select new
                        {
                            tho.ID_Tho,
                            congviec.ID_CongViec
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.ID_CongViec
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimKhaNang(
        string id_Tho,
        string id_CongViec)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Tho", typeof(string));
            dataTable.Columns.Add("ID_CongViec", typeof(string));

            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {

                    var result = from tho in quanly_SuaChuaXe.Thoes
                                 from congviec in tho.CongViecs
                                 where
                                    (string.IsNullOrEmpty(id_Tho.Trim()) || tho.ID_Tho == id_Tho.Trim()) &&
                                    (string.IsNullOrEmpty(id_CongViec.Trim()) || congviec.ID_CongViec == id_CongViec.Trim())
                                 select new
                                 {
                                     tho.ID_Tho,
                                     congviec.ID_CongViec
                                 };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Tho,
                            item.ID_CongViec
                        );
                    }
                }
            }
            catch { }

            return dataTable;

        }

        public bool ThemKhaNang(
            string id_Tho,
            string id_CongViec)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result_tho = (from tho in quanly_SuaChuaXe.Thoes
                                  where tho.ID_Tho == id_Tho.Trim()
                                  select tho).SingleOrDefault();

                    var result_congviec = (from congviec in quanly_SuaChuaXe.CongViecs
                                      where congviec.ID_CongViec == id_CongViec.Trim()
                                      select congviec).SingleOrDefault();

                    if (result_tho == null) return true;
                    if (result_congviec == null) return true;

                    result_tho.CongViecs.Add(result_congviec);
                    result_congviec.Thoes.Add(result_tho);

                    quanly_SuaChuaXe.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaKhaNang(
            string id_Tho,
            string id_CongViec)
        {
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result_tho = (from tho in quanly_SuaChuaXe.Thoes
                                      where tho.ID_Tho == id_Tho.Trim()
                                      select tho).SingleOrDefault();

                    var result_congviec = (from congviec in quanly_SuaChuaXe.CongViecs
                                           where congviec.ID_CongViec == id_CongViec.Trim()
                                           select congviec).SingleOrDefault();

                    if (result_tho == null) return true;
                    if (result_congviec == null) return true;

                    var result_congviec_tho = from congviec in result_tho.CongViecs
                                              where congviec.ID_CongViec != id_CongViec.Trim()
                                              select congviec;

                    var result_tho_congviec = from tho in result_congviec.Thoes
                                              where tho.ID_Tho != id_Tho.Trim()
                                              select tho;


                    result_tho.CongViecs = new HashSet<CongViec>(result_congviec_tho);
                    result_congviec.Thoes = new HashSet<Tho>(result_tho_congviec);

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
