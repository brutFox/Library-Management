<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="library_management.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/login_less.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-bottom: auto">
        <center style="height: 872px"><h1>LIBRARY MANAGEMENT SYSTEM</h1>
        
        <div style="height: 139px; margin-top:7%; margin-bottom:auto; margin-left:20%; margin-right:20%; border-width: 2px; border-color: blueviolet; width: 518px;">
            <div style="float: left; height: 88px; width: 168px; margin-left: 77px;" class="padding_element">
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <div style="width: 358px; height: 39px">
                    <asp:Label ID="msg_lbl" runat="server"></asp:Label>
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
        
            <div style="height: 94px; float: left; width: 189px;">
                <asp:TextBox ID="id_box" runat="server" CssClass="txtInput padding_element"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="pwd_box" runat="server" CssClass="txtInput padding_element" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
         
        </div>
        <asp:Button ID="SignIn_btn" runat="server" CssClass="button_submit" Text="Sign In" OnClick="SignIn_btn_Click"></asp:Button>
        
        </center>
        
    </div>
    </form>
</body>
</html>

