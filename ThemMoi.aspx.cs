using System;

public partial class _Default : System.Web.UI.Page 
{
    cls_HocVien BL_HocVien = new cls_HocVien();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BL_HocVien.load_DSHocVien(ref this.grv_HocVien);
        }
    }
    protected void btn_ThemMoi_Click(object sender, EventArgs e)
    {
        //Tạo mới một bản ghi Hồ Sơ
        cls_HocVien.HSHV HOSO = new cls_HocVien.HSHV();
        HOSO.HoTen = this.txt_HoTen.Text;
        HOSO.QueQuan = this.txt_QueQuan.Text;
        
        //Gọi phương thức để ghi dữ liệu
        BL_HocVien.ThemMoiHocVien(HOSO);

        BL_HocVien.load_DSHocVien(ref this.grv_HocVien);//Load du lieu moi len GridView

        //Xoa het du lieu da nhap tren cac TextBox
        this.txt_HoTen.Text = "";
        this.txt_QueQuan.Text = "";

        this.lbl_ThongBao.Text = "Đã hoàn thành thêm mới dữ liệu !!!";
    }
}
