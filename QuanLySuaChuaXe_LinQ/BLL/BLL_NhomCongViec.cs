using System.Linq;
using System.Data;
using QuanLySuaChuaXe_LinQ;

namespace BLL
{
    public class BLL_NhomCongViec
    {
        public BLL_NhomCongViec() { }   

        public DataTable LayNhomCongViec()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_NhomCongViec", typeof(string));
            dataTable.Columns.Add("Ten_NhomCongViec", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from nhomcongviec in quanly_SuaChuaXe.NhomCongViecs
                        select new
                        {
                            nhomcongviec.ID_NhomCongViec,
                            nhomcongviec.Ten_NhomCongViec
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_NhomCongViec,
                            item.Ten_NhomCongViec
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }
        // --> OK 
        public bool ThemNhomCongViec(
            string id_NhomCongViec,
            string ten_NhomCongViec)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {


                    NhomCongViec nhomcongviec = new NhomCongViec();
                    nhomcongviec.ID_NhomCongViec = id_NhomCongViec.Trim();
                    nhomcongviec.Ten_NhomCongViec = ten_NhomCongViec.Trim();

                    quanly_SuaChuaXe.NhomCongViecs.InsertOnSubmit(nhomcongviec);
                    quanly_SuaChuaXe.NhomCongViecs.Context.SubmitChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        // --> OK 
        public bool CapNhapNhomCongViec(
            string id_NhomCongViec,
            string ten_NhomCongViec)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {

                    var result = (from nhomcongviec in quanly_SuaChuaXe.NhomCongViecs
                                              where nhomcongviec.ID_NhomCongViec == id_NhomCongViec.Trim()
                                              select nhomcongviec).SingleOrDefault();

                    if (result == null) return true;

                    result.ID_NhomCongViec = id_NhomCongViec.Trim();
                    result.Ten_NhomCongViec = ten_NhomCongViec.Trim();
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
