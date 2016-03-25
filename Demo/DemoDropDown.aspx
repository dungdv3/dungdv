<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DemoDropDown.aspx.vb" Inherits="Demo.DemoDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
