using System.Web.UI.WebControls;
using System.Data.SqlClient;

public class cls_HocVien
{
    //Khai báo sử dụng lớp DataAccessLayer
    cls_DataAccessLayer DAL = new cls_DataAccessLayer();

    //Khai báo Bản ghi các thuộc tính trong CSDL QLHV - Bảng HOCVIEN
    public class HSHV
    {
        public string IdHocVien { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
    }

    public void load_DSHocVien(ref GridView grv)
    {
        string strSQL = "SELECT * FROM HOCVIEN";

        DAL.Fill_GridView(ref grv, strSQL);
    }

    public void ThemMoiHocVien(HSHV HOSO)
    {
        string strSQL = "INSERT INTO HOCVIEN (HOTEN, QUEQUAN) VALUES (@HoTen, @QueQuan)";
        SqlParameter[] ThamSo ={ 
            new SqlParameter("HoTen",HOSO.HoTen),
            new SqlParameter("QueQuan",HOSO.QueQuan)
        };

        DAL.Execute(strSQL, ThamSo);
    }

    public void XoaHocVien(string idHocVien)
    {
        string strSQL = "DELETE FROM HOCVIEN WHERE IDHOCVIEN = @ID";

        //Thêm tham số cho vấn tin
        SqlParameter[] ThamSo ={ 
            new SqlParameter("@ID",idHocVien)
        };

        DAL.Execute(strSQL, ThamSo);
    }

    public void TimHocVien(string strHoTen, ref GridView grv)
    {
        string strSQL = "SELECT * FROM HOCVIEN WHERE HOTEN LIKE '%' + @HOTEN + '%'";

        //Thêm tham số cho vấn tin
        SqlParameter[] ThamSo ={ 
            new SqlParameter("@HoTen",strHoTen)
        };

        DAL.Fill_GridView(ref grv, strSQL, ThamSo);
    }

    public void CapNhat(HSHV HoSo)
    {
        string strSQL = "UPDATE HOCVIEN SET HOTEN=@HOTEN, "
            + " QUEQUAN=@QUEQUAN WHERE IDHOCVIEN=@IDHOCVIEN";

        SqlParameter[] ThamSo ={ 
            new SqlParameter("HOTEN",HoSo.HoTen),
            new SqlParameter("QUEQUAN",HoSo.QueQuan),
            new SqlParameter("IDHOCVIEN",HoSo.IdHocVien),
        };

        DAL.Execute(strSQL, ThamSo);
    }
}
