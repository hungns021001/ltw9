using System;
using System.Data;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public class cls_DataAccessLayer
{
    SqlConnection Conn = new SqlConnection();

    public cls_DataAccessLayer()
    {
        Conn.ConnectionString = "Server=HNS\\HUNGNGUYEN;Database=QLHV;"
            + "Trusted_Connection=True;";
    }

    public DataTable Select(string strSQL)
    {
        DataTable dt = new DataTable();

        try
        {
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Conn);
            Conn.Open();
            da.Fill(dt);
            Conn.Close();
        }
        catch (Exception ex)
        {
            showErr(ex);
        }

        return dt;
    }
    public DataTable Select(string strSQL, SqlParameter[] ThamSo)
    {
        DataTable dt = new DataTable();

        try
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(strSQL, Conn);
            da.SelectCommand = command;

            // Add parameters and set values.
            for (int i = 0; i < ThamSo.Length; i++)
            {
                command.Parameters.Add(ThamSo[i]);
            }

            //command.Parameters.Add("@Country", SqlDbType.NVarChar, 15).Value = "UK";
            //ccommandmd.Parameters.Add("@City", SqlDbType.NVarChar, 15).Value = "London";

            //DataSet custDS = new DataSet();

            da.Fill(dt);
            //da.Fill(custDS, "Customers");

            //SqlDataAdapter da = new SqlDataAdapter(strSQL, Conn);
            //DataTable dt = new DataTable();
            //Conn.Open();
            //da.Fill(dt);
            //Conn.Close();


            //Conn.Open();
            //SqlCommand command = new SqlCommand(strSQL, Conn);
            //for (int i = 0; i < ThamSo.Length; i++)
            //{
            //    command.Parameters.Add(ThamSo[i]);
            //}
            //command.ExecuteReader();// .ExecuteNonQuery();
            //Conn.Close();
        }
        catch (Exception ex)
        {
            showErr(ex);
        }

        return dt;
    }

    public void Execute(string strSQL)
    {
        try
        {
            Conn.Open();
            SqlCommand command = new SqlCommand(strSQL, Conn);
            command.ExecuteNonQuery();
            Conn.Close();
        }
        catch (Exception ex)
        {
            showErr(ex);
        }
    }
    public void Execute(string strSQL, SqlParameter[] ThamSo)
    {
        try  //Bảy lỗi
        {
            Conn.Open();
            SqlCommand command = new SqlCommand(strSQL, Conn);
            for (int i = 0; i < ThamSo.Length; i++)
            {
                command.Parameters.Add(ThamSo[i]);
            } 
            command.ExecuteNonQuery();
            Conn.Close();
        }
        catch (Exception ex)    //Tìm thấy lỗi
        {
            showErr(ex);
        }
    }

    public void Fill_DropDownList(ref DropDownList ddl, string strSQL, string DataTextField, string DataValueField)
    {
        try
        {
            ddl.DataSource = Select(strSQL);
            ddl.DataTextField = DataTextField;
            ddl.DataValueField = DataValueField;
            ddl.DataBind();
        }
        catch (Exception ex)
        {
            showErr(ex);
        }
    }

    public void Fill_GridView(ref GridView grv, string strSQL)
    {
        try
        {
            grv.DataSource = Select(strSQL);
            grv.DataBind();
        }
        catch (Exception ex)
        {
            showErr(ex);
        }
    }
    public void Fill_GridView(ref GridView grv, string strSQL, SqlParameter[] ThamSo)
    {
        try
        {
            grv.DataSource = Select(strSQL, ThamSo);
            grv.DataBind();
        }
        catch (Exception ex)
        {
            showErr(ex);
        }
    }

    public void showErr(Exception ex)   //Thông báo lỗi khi xuất hiện
    {
        //Them ham de ghi Nhat ky loi
        HttpContext.Current.Response.Write("Tìm thấy lỗi: " + ex.Message);
    }
}
