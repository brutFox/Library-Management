<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lib_Issue_Books.aspx.cs" Inherits="library_management.Lib_Issue_Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-bottom: auto">
        <center style="height: 872px"><h1>LIBRARY MANAGEMENT SYSTEM</h1>
        <div style="height: 40px; margin-bottom:auto; margin-left:12%; margin-right:12%; border-width: 2px; border-color: blueviolet; width: 721px;">           
            <asp:Button ID="logout_btn" runat="server" Text="Log Out" Style="float: right" />
            <asp:Label ID="profile_lbl" runat="server" Style="float: right"></asp:Label>
            
            <asp:Button ID="search_btn" runat="server" Text="Search" />
            <asp:Button ID="add_btn" runat="server" Text="Add New Books" />
            <asp:Button ID="return_btn" runat="server" Text="Return Books" />
        </div>
        <div>
        
                
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <br />
            <asp:TextBox ID="id_box" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="id_msg" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Book Name:"></asp:Label>
            <br />
            <asp:TextBox ID="book_box" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="bk_msg" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Issued On:"></asp:Label>
            <br />
            <asp:Label ID="issue_date_lbl" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="submit_btn" runat="server" OnClick="submit_btn_Click" Text="Issue" />
            <br />
            <asp:Label ID="issue_msg" runat="server"></asp:Label>
        
                
        </div>
        </center>
    </div>
    </form>
</body>
</html>
