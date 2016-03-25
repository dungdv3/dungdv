<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="demoRadio.aspx.vb" Inherits="Demo.demoRadio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
               <asp:Label ID="lblRespond" runat="server" Text="lblRespond"></asp:Label>
&nbsp;<br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="btnClick" runat="server" Text="Button" />
    		test test test
    </div>
    </form>
</body>
</html>
