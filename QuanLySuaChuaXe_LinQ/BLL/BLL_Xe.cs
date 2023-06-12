using System.Linq;
using System.Data;
using QuanLySuaChuaXe_LinQ;

namespace BLL
{
    public class BLL_Xe
    {
        public BLL_Xe() { } 

        public DataTable LayXe()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Xe", typeof(string));
            dataTable.Columns.Add("Loai_Xe", typeof(string));
            dataTable.Columns.Add("Hang_Xe", typeof(string));
            dataTable.Columns.Add("ID_KhachHang", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from xe in quanly_SuaChuaXe.Xes
                        select new
                        {
                            xe.ID_Xe,
                            xe.Loai_Xe,
                            xe.Hang_Xe,
                            xe.ID_KhachHang
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Xe,
                            item.Loai_Xe,
                            item.Hang_Xe,
                            item.ID_KhachHang
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }


        public DataTable TimXe(string id_Xe)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Xe", typeof(string));
            dataTable.Columns.Add("Loai_Xe", typeof(string));
            dataTable.Columns.Add("Hang_Xe", typeof(string));
            dataTable.Columns.Add("ID_KhachHang", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from xe in quanly_SuaChuaXe.Xes
                        where xe.ID_Xe == id_Xe.Trim()
                        select new
                        {
                            xe.ID_Xe,
                            xe.Loai_Xe,
                            xe.Hang_Xe,
                            xe.ID_KhachHang
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Xe,
                            item.Loai_Xe,
                            item.Hang_Xe,
                            item.ID_KhachHang
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimXe_KhachHang(string id_KhachHang)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_Xe", typeof(string));
            dataTable.Columns.Add("Loai_Xe", typeof(string));
            dataTable.Columns.Add("Hang_Xe", typeof(string));
            dataTable.Columns.Add("ID_KhachHang", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from xe in quanly_SuaChuaXe.Xes
                        join khachhang in quanly_SuaChuaXe.Xes on xe.ID_KhachHang equals khachhang.ID_KhachHang
                        where khachhang.ID_KhachHang == id_KhachHang.Trim()
                        select new
                        {
                            xe.ID_Xe,
                            xe.Loai_Xe,
                            xe.Hang_Xe,
                            xe.ID_KhachHang
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_Xe,
                            item.Loai_Xe,
                            item.Hang_Xe,
                            item.ID_KhachHang
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        // --> OK
        public bool ThemXe(
            string id_Xe, 
            string loai_Xe, 
            string hang_Xe, 
            string id_KhachHang)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    Xe xe = new Xe();
                    xe.ID_Xe = id_Xe.Trim();
                    xe.Loai_Xe = loai_Xe.Trim();
                    xe.Hang_Xe = hang_Xe.Trim();
                    xe.ID_KhachHang = id_KhachHang.Trim();

                    quanly_SuaChuaXe.Xes.InsertOnSubmit(xe);
                    quanly_SuaChuaXe.Xes.Context.SubmitChanges();
                }
            }
            catch 
            {
                return false;
            }
            return true;
        }
        // --> OK
        public bool XoaXe(string id_Xe)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result = from xe in quanly_SuaChuaXe.Xes
                                   where xe.ID_Xe == id_Xe.Trim()
                                   select xe;

                    quanly_SuaChuaXe.Xes.DeleteAllOnSubmit(result);
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
        public bool CapnhatXe(
            string id_Xe,
            string loai_Xe,
            string hang_Xe,
            string id_KhachHang)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result = (from xe in quanly_SuaChuaXe.Xes
                                    where xe.ID_Xe == id_Xe
                                    select xe).SingleOrDefault();

                    if (result == null) return true;
                    
                    result.ID_Xe = id_Xe;
                    result.Loai_Xe = loai_Xe;
                    result.Hang_Xe = hang_Xe;
                    result.ID_KhachHang = id_KhachHang;
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