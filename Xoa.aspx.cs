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

public partial class Xoa : System.Web.UI.Page
{
    cls_HocVien HocVien = new cls_HocVien();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            HienThi();
    }
    private void HienThi()
    {
        HocVien.load_DSHocVien(ref this.grv_HocVien); //Load dữ liệu lên GridView
    }
    protected void btn_Xoa_Click(object sender, EventArgs e)
    {
        HocVien.XoaHocVien(this.txt_IDHocVien.Text);
        this.lbl_ThongBao.Text = "Đã xóa thành công dữ liệu!!!";

        HienThi();  //Load lại dữ liệu trên GridView
    }
}
