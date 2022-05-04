<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Xoa.aspx.cs" Inherits="Xoa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>[</strong><a href="index.html"><strong>Về Trang chủ</strong></a><strong>]<br />
        </strong>
        <br />
        ID Học viên:
        <asp:TextBox ID="txt_IDHocVien" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Xoa" runat="server" OnClick="btn_Xoa_Click" Text="Xóa học viên" />
        <br />
        <br />
        <asp:Label ID="lbl_ThongBao" runat="server" ForeColor="Red"></asp:Label><br />
        <br />
        <asp:GridView ID="grv_HocVien" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
