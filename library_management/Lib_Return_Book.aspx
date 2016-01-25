<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lib_Return_Book.aspx.cs" Inherits="library_management.Lib_Return_Book" %>

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
            <asp:Button ID="logout_btn" runat="server" Text="Log Out" Style="float: right" OnClick="logout_btn_Click" />
            <asp:Label ID="profile_lbl" runat="server" Style="float: right"></asp:Label>
            
            <asp:Button ID="search_btn" runat="server" Text="Search" OnClick="search_btn_Click" />
            <asp:Button ID="add_btn" runat="server" Text="Add New Books" OnClick="add_btn_Click" />
            <asp:Button ID="return_btn" runat="server" Text="Return Books" />
        </div>
        
            
        <div style="height: 383px; margin-top: 7%; margin-bottom:auto; margin-left:12%; margin-right:12%; border-width: 2px; border-color: blueviolet; width: 721px;" id="search_div">           
            <asp:TextBox ID="search_box" runat="server" CssClass="form-control"  Placeholder="User ID"></asp:TextBox>

                    <asp:Button ID="srch_btn" runat="server" Text="Search" OnClick="srch_btn_Click" />
                    <br />
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            <asp:Label ID="name_lbl" runat="server"></asp:Label>
            <br />
            <asp:Label ID="label3" runat="server" Text="ID:"></asp:Label>
            <asp:Label ID="ID_lbl" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Account:"></asp:Label>
            <asp:Label ID="acc_lbl" runat="server"></asp:Label>
                    <br />
                    <asp:GridView ID="result_grid" runat="server" AutoGenerateColumns="False"
                        onrowcancelingedit="result_grid_OnRowCancelingEdit" 
            onrowdeleting="result_grid_OnRowDeleting" 
            onrowediting="result_grid_RowEditing" 
            onrowupdating="result_grid_RowUpdating" OnSelectedIndexChanged="result_grid_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="BrID" HeaderText="ID" />
                            <asp:BoundField DataField="BName" HeaderText="Book Name" />
                            <asp:BoundField HeaderText="Issue Date" DataField="Issued" />
                            <asp:CommandField EditText="Return" SelectText="Return" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
            
            
            
            <asp:HiddenField ID="BID_field" runat="server" />
            <br />
            <asp:Label ID="msg_lbl" runat="server"></asp:Label>
            <br />
            <asp:HiddenField ID="uid_field" runat="server" />
            
            
            
            </div>
    </center>
    </div>
    </form>
</body>
</html>
