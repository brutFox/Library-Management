<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibrarianProfile.aspx.cs" Inherits="library_management.LibrarianProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Management System</title>
    <link rel="stylesheet"  href="css/bootstrap.min.css" />
    <style>
        .form-control:focus {
            box-shadow: #008B8B ;
            border: 1px solid #008B8B;
        }
        table {
            margin-left: 0px;
        }
        th {
            text-align: center;
            padding: 5px 12px;
            width: 10%;
            background: cornflowerblue;
            color: #fff;
            border: 1px solid #aaa;
            font-size: 1.15em;
        }
        td {
            padding: 5px 12px;
            text-align: left;
            border: 1px solid #aaa;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-bottom: auto">
        <center style="height: 872px"><h1>LIBRARY MANAGEMENT SYSTEM</h1>
        <div style="height: 40px; margin-bottom:auto; margin-left:12%; margin-right:12%; border-width: 2px; border-color: blueviolet; width: 721px;">           
            <asp:Button ID="logout_btn" runat="server" Text="Log Out" Style="float: right" OnClick="logout_btn_Click1"/>
            <asp:Label ID="profile_lbl" runat="server" Style="float: right"></asp:Label>
            
            <asp:Button ID="search_btn" runat="server" Text="Search" OnClick="search_btn_Click" />
            <asp:Button ID="add_btn" runat="server" Text="Add New Books" OnClick="add_btn_Click" />
            <asp:Button ID="return_btn" runat="server" Text="Return Book" OnClick="issue_btn_Click" />
        </div>

        <div style="height: 383px; margin-top: 7%; margin-bottom:auto; margin-left:12%; margin-right:12%; border-width: 2px; border-color: blueviolet; width: 721px;" id="search_div">           
            <asp:TextBox ID="search_box" runat="server" CssClass="form-control"  Placeholder="Search by Book Name, Author Name"></asp:TextBox>

                    <asp:Button ID="srch_btn" runat="server" Text="Search" OnClick="srch_btn_Click" />
                    <br />
                    <asp:GridView ID="result_grid" runat="server" AutoGenerateColumns="False"
                        onrowcancelingedit="result_grid_OnRowCancelingEdit" 
            onrowdeleting="result_grid_OnRowDeleting" 
            onrowediting="result_grid_RowEditing" 
            onrowupdating="result_grid_RowUpdating" OnSelectedIndexChanged="result_grid_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="BID" HeaderText="ID" />
                            <asp:BoundField HeaderText="Book" DataField="BName" />
                            <asp:BoundField HeaderText="Authors" DataField="Authors" />
                            <asp:BoundField DataField="Info" HeaderText="Description" />
                            <asp:BoundField HeaderText="Total Copies" DataField="Total_Copies" />
                            <asp:BoundField HeaderText="Available Copies" DataField="Available_copies" />
                            <asp:CommandField HeaderText="Action" ShowSelectButton="True" InsertText="" NewText="" ShowInsertButton="True" SelectText="Issue" />
                        </Columns>
                    </asp:GridView>
            
                    <div id="issue_div">
                        
                        
                        <asp:Label ID="Label1" runat="server" Text="ID:" Visible="False"></asp:Label>
                        <br />
                        <asp:TextBox ID="ID_box" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:Label ID="id_msg" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="issue_book_btn" runat="server" OnClick="issue_book_btn_Click" Text="Issue" Visible="False" />
                        <br />
                        <asp:Label ID="msg_lbl" runat="server"></asp:Label>
                        <asp:HiddenField ID="bid_field" runat="server"></asp:HiddenField>
                        
                        
                        <br />
                        <asp:HiddenField ID="Bname_field" runat="server" />
                        
                        
                    </div>
            

        </div>
        </center>
    </div>
    </form>
</body>
</html>
