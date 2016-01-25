<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="library_management.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Management System</title>
    <link rel="stylesheet"  href="css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-bottom: auto">
        <center style="height: 872px"><h1>LIBRARY MANAGEMENT SYSTEM</h1>
        
        <div style="height: 336px; margin-top:7%; margin-bottom:auto; margin-left:20%; margin-right:20%; border-width: 2px; border-color: blueviolet; width: 518px;">
            <div style="float: left; height: 267px; width: 133px">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Account Type"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Password" CssClass="width: 100px"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Confirm Password" CssClass="width: 100px"></asp:Label>
            </div>
        
            <div style="height: 265px; float: left; width: 380px;">
                <asp:TextBox ID="Name_box" runat="server" CssClass="float: left"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="ID_box" runat="server" CssClass="float: left"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="email_box" runat="server" CssClass="float: left"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:RadioButtonList ID="Acc_type_radio" runat="server" CssClass="float: left" Height="25px" RepeatDirection="Horizontal" Width="294px">
                    <asp:ListItem>Librarian</asp:ListItem>
                    <asp:ListItem>Faculty</asp:ListItem>
                    <asp:ListItem>Student</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:TextBox ID="pwd_box" runat="server" CssClass="float: left" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="cpwd_box" runat="server" CssClass="float: left" TextMode="Password"></asp:TextBox>
            </div>
         
            <asp:Label ID="warning_lbl" runat="server"></asp:Label>
         
        </div>
        <asp:Button ID="Register_btn" runat="server" Text="Register" OnClick="Register_btn_Click"></asp:Button>
        
        </center>
        
    </div>
    </form>
</body>
</html>
