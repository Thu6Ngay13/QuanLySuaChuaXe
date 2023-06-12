using System;
using System.Linq;
using System.Data;
using QuanLySuaChuaXe_LinQ;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_PhieuThu
    {
        public BLL_PhieuThu() { }

        public DataTable LayPhieuThu()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_PhieuThu", typeof(string));
            dataTable.Columns.Add("HoTenNguoiThu_PhieuThu", typeof(string));
            dataTable.Columns.Add("HoTenNguoiNop_PhieuThu", typeof(string));
            dataTable.Columns.Add("NgayThu_PhieuThu", typeof(DateTime));
            dataTable.Columns.Add("SoTienThu_PhieuThu", typeof(float));
            dataTable.Columns.Add("ID_HopDong", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from phieuthu in quanly_SuaChuaXe.PhieuThus
                        select new
                        {
                            phieuthu.ID_PhieuThu,
                            phieuthu.HoTenNguoiThu_PhieuThu,
                            phieuthu.HoTenNguoiNop_PhieuThu,
                            phieuthu.NgayThu_PhieuThu,
                            phieuthu.SoTienThu_PhieuThu,
                            phieuthu.ID_HopDong
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_PhieuThu,
                            item.HoTenNguoiThu_PhieuThu,
                            item.HoTenNguoiNop_PhieuThu,
                            item.NgayThu_PhieuThu,
                            item.SoTienThu_PhieuThu,
                            item.ID_HopDong
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        public DataTable TimPhieuThu_HopDong(string id_HopDong)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID_PhieuThu", typeof(string));

            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result =
                        from phieuthu in quanly_SuaChuaXe.PhieuThus
                        join hopdong in quanly_SuaChuaXe.HopDongs on phieuthu.ID_HopDong equals hopdong.ID_HopDong
                        where hopdong.ID_HopDong == id_HopDong.Trim()
                        select new
                        {
                            phieuthu.ID_PhieuThu
                        };

                    foreach (var item in result)
                    {
                        dataTable.Rows.Add(
                            item.ID_PhieuThu
                        );
                    }
                }
            }
            catch { }

            return dataTable;
        }

        // --> OK
        public bool ThemPhieuThu(
            string id_HopDong,
            DateTime ngaythu_PhieuThu,
            string id_PhieuThu,
            string hotennguoithu_PhieuThu,
            string hotennguoinop_PhieuThu,
            float sotienthu_PhieuThu)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    string ngaythu = ngaythu_PhieuThu.ToString("yyyy-MM-dd");

                    PhieuThu phieuthu = new PhieuThu();
                    phieuthu.ID_PhieuThu = id_PhieuThu.Trim();
                    phieuthu.HoTenNguoiThu_PhieuThu = hotennguoithu_PhieuThu.Trim();
                    phieuthu.HoTenNguoiNop_PhieuThu = hotennguoinop_PhieuThu.Trim();

                    phieuthu.NgayThu_PhieuThu = Convert.ToDateTime(ngaythu);
                    phieuthu.SoTienThu_PhieuThu = sotienthu_PhieuThu;
                    phieuthu.ID_HopDong = id_HopDong.Trim();



                    quanly_SuaChuaXe.PhieuThus.InsertOnSubmit(phieuthu);
                    quanly_SuaChuaXe.PhieuThus.Context.SubmitChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;

        }

        // --> OK
        public bool XoaPhieuThu(string id_PhieuThu)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    var result = from phieuthu in quanly_SuaChuaXe.PhieuThus
                                         where phieuthu.ID_PhieuThu == id_PhieuThu.Trim()
                                         select phieuthu;

                    quanly_SuaChuaXe.PhieuThus.DeleteAllOnSubmit(result);
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
        public bool CapNhatPhieuThu(
            string id_HopDong,
            DateTime ngaythu_PhieuThu,
            string id_PhieuThu,
            string hotennguoithu_PhieuThu,
            string hotennguoinop_PhieuThu,
            float sotienthu_PhieuThu)
        {
            try
            {
                using (QuanLySuaChuaXeDataContext quanly_SuaChuaXe = new QuanLySuaChuaXeDataContext())
                {
                    string ngaythu = ngaythu_PhieuThu.ToString("yyyy-MM-dd");
                    var result = (from phieuthu in quanly_SuaChuaXe.PhieuThus
                                          where phieuthu.ID_PhieuThu == id_PhieuThu.Trim()
                                          select phieuthu).SingleOrDefault();

                    if (result == null) return true;

                    result.ID_PhieuThu = id_PhieuThu.Trim();
                    result.HoTenNguoiThu_PhieuThu = hotennguoithu_PhieuThu.Trim();
                    result.HoTenNguoiNop_PhieuThu = hotennguoinop_PhieuThu.Trim();
                    result.NgayThu_PhieuThu = Convert.ToDateTime(ngaythu);
                    result.SoTienThu_PhieuThu = sotienthu_PhieuThu;
                    result.ID_HopDong = id_HopDong.Trim();
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