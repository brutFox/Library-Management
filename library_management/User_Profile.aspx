<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Profile.aspx.cs" Inherits="library_management.User_Profile" %>

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
            <asp:Button ID="logout_btn" runat="server" Text="Log Out" Style="float: right" OnClick="logout_btn_Click"/>
            <asp:Label ID="profile_lbl" runat="server" Style="float: right"></asp:Label>
            
        </div>
            
        <div>
            <asp:GridView ID="History_Grid" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="Book" DataField="BName" />
                    <asp:BoundField HeaderText="Issue Date" DataField="Issued" />
                </Columns>
            </asp:GridView>        
            <br />
            <asp:Label ID="msg_lbl" runat="server"></asp:Label>
        </div>
    </center>
    </div>
    </form>
</body>
</html>
