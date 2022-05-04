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

public partial class TimKiem : System.Web.UI.Page
{
    cls_HocVien HocVien = new cls_HocVien();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_TimKiem_Click(object sender, EventArgs e)
    {
        HocVien.TimHocVien(this.txt_HoTen.Text, ref this.grv_HocVien);
    }
}
