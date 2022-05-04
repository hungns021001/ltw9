<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimKiem.aspx.cs" Inherits="TimKiem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>[</strong><a href="Default.aspx"><strong>Về Trang chủ</strong></a><strong>]<br />
        </strong>
        <br />
        Họ tên:
        <asp:TextBox ID="txt_HoTen" runat="server"></asp:TextBox>
        <asp:Button ID="btn_TimKiem" runat="server" OnClick="btn_TimKiem_Click" Text="Tìm học viên" /><br />
        <br />
        <asp:GridView ID="grv_HocVien" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
