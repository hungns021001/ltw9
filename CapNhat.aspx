<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CapNhat.aspx.cs" Inherits="CapNhat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>[<a href="index.html">Về Trang chủ</a>]<br />
            <br />
            CẬP NHẬT DỮ LIỆU HỌC VIÊN<br />
            <br />
            <span style="color: #00cc00">Nhập ID của Học viên đã có để cập nhật nội dung mới</span><br />
        </strong>
        <table style="font-weight: bold">
            <tr>
                <td style="width: 100px">
                    ID Học viên:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txt_IDHocVien" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Họ tên:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txt_HoTen" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Quê quán</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txt_QueQuan" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btn_CapNhat" runat="server" OnClick="btn_CapNhat_Click" Text="Cập nhật" /></td>
            </tr>
        </table>
        <strong>
            <br />
            <br />
        </strong>
        <asp:Label ID="lbl_ThongBao" runat="server" Font-Bold="False" ForeColor="Red"></asp:Label><br />
        <br />
        <asp:GridView ID="grv_HocVien" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
