using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class CapNhat : System.Web.UI.Page
{
    cls_HocVien HocVien = new cls_HocVien();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) HienThi();
    }
    private void HienThi()
    {
        HocVien.load_DSHocVien(ref this.grv_HocVien);
    }
    protected void btn_CapNhat_Click(object sender, EventArgs e)
    {
        cls_HocVien.HSHV HoSo= new cls_HocVien.HSHV();
        HoSo.IdHocVien = this.txt_IDHocVien.Text;
        HoSo.HoTen = this.txt_HoTen.Text;
        HoSo.QueQuan = this.txt_QueQuan.Text;

        HocVien.CapNhat(HoSo);

        HienThi(); //Hiển thị lại dữ liệu trên GridView

        this.lbl_ThongBao.Text = "Đã cập nhật thành công dữ liệu !!!";

        //Xóa dữ liệu đã nhập trên webform
        this.txt_QueQuan.Text = "";
        this.txt_HoTen.Text="";
        this.txt_IDHocVien.Text="";
    }
}
