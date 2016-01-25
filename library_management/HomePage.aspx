<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="library_management.HomePage" %>

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
            <asp:LinkButton ID="SignIn_btn" runat="server" OnClick="SignIn_btn_Click">Sign In</asp:LinkButton>
        &nbsp;
            <asp:LinkButton ID="register_btn" runat="server" OnClick="register_btn_Click">Register</asp:LinkButton>
                
                <div style="height: 246px; margin-top:7%; margin-bottom:auto; margin-left:20%; margin-right:20%; width: 620px;">


        <asp:TextBox ID="search_box" runat="server" CssClass="form-control"  Placeholder="Search by Book Name or Author Name"></asp:TextBox>

                    <asp:Button ID="Search_btn" runat="server" Text="Search" OnClick="Search_btn_Click" />
                    <br />
                    <asp:GridView ID="result_grid" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField HeaderText="Book" DataField="BName" />
                            <asp:BoundField HeaderText="Authors" DataField="Authors" />
                            <asp:BoundField HeaderText="Total Copies" DataField="Total_Copies" />
                            <asp:BoundField HeaderText="Available Copies" DataField="Available_copies" />
                        </Columns>
                    </asp:GridView>

                </div>
                <br />
            </center>


        </div>
        </form>
    
</body>
</html>
