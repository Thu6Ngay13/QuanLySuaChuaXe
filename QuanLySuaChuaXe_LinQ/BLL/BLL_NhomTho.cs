using System.Linq;
using System.Data;
using QuanLySuaChuaXe_LinQ;

namespace BLL
{
    public class BLL_NhomTho
    {
        public BLL_NhomTho() { }    

        public DataTable LayNhomTho()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_NhomTho", typeof(string));
            dataTable.Columns.Add("Ten_NhomTho", typeof(string));
            dataTable.Columns.Add("ID_TruongNhom", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from nhomtho in quanly_SuaChuaXe.NhomThos
                        select new
                        {
                            nhomtho.ID_NhomTho,
                            nhomtho.Ten_NhomTho,
                            nhomtho.ID_TruongNhom
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_NhomTho,
                            item.Ten_NhomTho,
                            item.ID_TruongNhom
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        // --> OK
        public bool ThemNhomTho(string id_NhomTho, string ten_NhomTho, string id_TruongNhom)
        {

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    NhomTho nhomtho = new NhomTho();
                    nhomtho.ID_NhomTho = id_NhomTho.Trim();
                    nhomtho.Ten_NhomTho = ten_NhomTho.Trim();
                    nhomtho.ID_TruongNhom = id_TruongNhom.Trim();

                    quanly_SuaChuaXe.NhomThos.InsertOnSubmit(nhomtho);
                    quanly_SuaChuaXe.NhomThos.Context.SubmitChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        // --> OK
        public bool XoaNhomTho(string id_NhomTho)
        {

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result = from nhomtho in quanly_SuaChuaXe.NhomThos
                                        where nhomtho.ID_NhomTho == id_NhomTho.Trim()
                                        select nhomtho;

                    quanly_SuaChuaXe.NhomThos.DeleteAllOnSubmit(result);
                    quanly_SuaChuaXe.SubmitChanges();

                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        // --> OK
        public bool CapNhapNhomTho(string id_NhomTho, string ten_NhomTho, string id_TruongNhom)
        {

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {

                    var result = (from nhomtho in quanly_SuaChuaXe.NhomThos
                                         where nhomtho.ID_NhomTho == id_NhomTho.Trim()
                                         select nhomtho).SingleOrDefault();

                    if (result == null) return true;

                    result.Ten_NhomTho = ten_NhomTho.Trim();
                    result.ID_TruongNhom = id_TruongNhom.Trim();
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
