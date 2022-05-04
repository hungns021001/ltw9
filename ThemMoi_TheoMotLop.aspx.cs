using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ThemMoi_Click(object sender, EventArgs e)
    {
        //Tạo kết nối đến CSDL vật lý
        SqlDataSource SqlDS = new SqlDataSource();
        SqlDS.ConnectionString = "Server=NGOCNHAN;Database=QLHV;"
                    + "User ID=sa;Password=thuynt;Trusted_Connection=False;";
        
        //Phát biểu Insert
        SqlDS.InsertCommand = "INSERT INTO HOCVIEN (HOTEN, QUEQUAN) "
            + " VALUES (@HoTen, @QueQuan)";
        //Thêm tham số cho phát biểu SQL
        SqlDS.InsertParameters.Add("HoTen",TypeCode.String,this.txt_HoTen.Text);
        SqlDS.InsertParameters.Add("QueQuan", TypeCode.String, this.txt_QueQuan.Text);
        //Thực thi Insert dữ liệu
        SqlDS.Insert();
        
        this.lbl_ThongBao.Text = "Đã thêm mới thành công dữ liệu!!!";
        this.txt_HoTen.Text = "";
        this.txt_QueQuan.Text = "";
    }
}
