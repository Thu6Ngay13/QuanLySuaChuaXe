using System.Data;
using System.Linq;
using QuanLySuaChuaXe_LinQ;

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
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from khanang in quanly_SuaChuaXe.KhaNangs
                        select new
                        {
                            khanang.ID_Tho,
                            khanang.ID_CongViec
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
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable("KhaNang");
            dataTable.Columns.Add("ID_Tho");
            dataTable.Columns.Add("ID_CongViec");

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {

                    var result = from khannang in quanly_SuaChuaXe.KhaNangs
                                 where
                                    (string.IsNullOrEmpty(id_Tho.Trim()) || khannang.ID_Tho == id_Tho.Trim()) &&
                                    (string.IsNullOrEmpty(id_CongViec.Trim()) || khannang.ID_CongViec == id_CongViec.Trim())
                                 select khannang;

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
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {


                    KhaNang khanang = new KhaNang();

                    khanang.ID_Tho = id_Tho.Trim();
                    khanang.ID_CongViec = id_CongViec.Trim();
                    quanly_SuaChuaXe.KhaNangs.InsertOnSubmit(khanang);
                    quanly_SuaChuaXe.KhaNangs.Context.SubmitChanges();
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
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result = from khanang in quanly_SuaChuaXe.KhaNangs
                                        where khanang.ID_Tho == id_Tho.Trim()
                                        where khanang.ID_CongViec == id_CongViec.Trim() 
                                        select khanang;

                    quanly_SuaChuaXe.KhaNangs.DeleteAllOnSubmit(result);
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
