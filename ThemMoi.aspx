<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="ThemMoi.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <b>[<a href="index.html">Về Trang chủ</a>]</b></p>
        <p>
            <b>THÊM MỚI HỌC VIÊN</b></p>
        <p>
            <table>
                <tr>
                    <td style="width: 100px">
                        <strong>Họ tên:</strong>&nbsp;</td>
                    <td style="width: 100px">
        <asp:TextBox ID="txt_HoTen" runat="server" Width="195px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <strong>Quê quán:</strong>&nbsp;
                    </td>
                    <td style="width: 100px">
        <asp:TextBox ID="txt_QueQuan" runat="server" Width="195px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 26px">
                    </td>
                    <td style="width: 100px; height: 26px">
        <asp:Button ID="btn_ThemMoi" runat="server" Text="Thêm mới" 
            onclick="btn_ThemMoi_Click" /></td>
                </tr>
            </table>
            <b></b>
        </p>
    <p>
        &nbsp;<asp:Label ID="lbl_ThongBao" runat="server" ForeColor="Red"></asp:Label></p>
        <p>
        <b>DANH SÁCH HỌC VIÊN</b></p>
    <p>
        <asp:GridView ID="grv_HocVien" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="IDHOCVIEN" HeaderText="ID" />
                <asp:BoundField DataField="HOTEN" HeaderText="Họ t&#234;n" />
                <asp:BoundField DataField="QUEQUAN" HeaderText="Qu&#234; qu&#225;n" />
            </Columns>
        </asp:GridView>
    </p>
</form>
</body>
</html>
