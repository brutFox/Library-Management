<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Librarian_Add_Books.aspx.cs" Inherits="library_management.Librarian_Add_Books" %>

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
            
            <asp:Button ID="search_btn" runat="server" Text="Search" OnClick="search_btn_Click" />
            <asp:Button ID="add_btn" runat="server" Text="Add New Books" />
            <asp:Button ID="return_btn" runat="server" Text="Return Books" OnClick="return_btn_Click" />
        </div>
        <div style="height: 474px; margin-top: 7%; margin-bottom:auto; margin-left:12%; margin-right:12%; border-width: 2px; border-color: blueviolet; width: 721px;">           
            <asp:Label ID="Label1" runat="server" Text="Book Name:" Style="float: left"></asp:Label>
            <br />
            <asp:TextBox ID="BookNm_txt" runat="server" Style="float: left" Width="349px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="bk_msg" runat="server" Text="" Style="float: left"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Author(s) [If multiple authors, write their names separating  comma(,)]" Style="float: left"></asp:Label>
            <br />
            <asp:TextBox ID="auth_txt" runat="server" Style="float: left" Width="349px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="auth_msg" runat="server" Text="" Style="float: left"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Category:" Style="float: left"></asp:Label>
            <br />
            <asp:DropDownList ID="category_list" runat="server" Style="float: left">
                
            </asp:DropDownList>
            <asp:Label ID="Label4" runat="server" Text="or add new category:" Style="float: left"></asp:Label>
            <asp:TextBox ID="cat_txt" runat="server" Style="float: left" Width="240px"></asp:TextBox>
            <asp:Button ID="Add_Cat_btn" runat="server" Text="Add" OnClick="Add_Cat_btn_Click"></asp:Button>
            <br />
            <asp:Label ID="Cat_lbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Number of Copies:" Style="float: left"></asp:Label>
            <br />
            <asp:TextBox ID="copies_txt" runat="server" Style="float: left" Width="349px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="cpy_msg" runat="server" Text="" Style="float: left"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Publisher:" Style="float: left"></asp:Label>
            <br />
            <asp:DropDownList ID="publisher_list" runat="server" Style="float: left">
            </asp:DropDownList>
            <asp:Label ID="Label8" runat="server" Text="or add new publisher:" Style="float: left"></asp:Label>
            <asp:TextBox ID="pub_txt" runat="server" Style="float: left" Width="240px"></asp:TextBox>
            <asp:Button ID="Add_Pub_btn" runat="server" Text="Add" OnClick="Add_Pub_btn_Click"></asp:Button>
            <br />
            <asp:Label ID="Pub_lbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Additional Info:" Style="float: left; width: 349px; "></asp:Label>
            <br />
            <asp:TextBox ID="info_txt" runat="server" Style="float: left" Width="349px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="info_msg" runat="server" Text="" Style="float: left"></asp:Label>
            <br />
            <asp:Button ID="Add_Books_btn" runat="server" Text="Add" OnClick="Add_Books_btn_Click" />
            <br />
            <asp:Label ID="msg_lbl" runat="server" Text=""></asp:Label>
            
        </div>
        </center>    
    </div>
    </form>
</body>
</html>
