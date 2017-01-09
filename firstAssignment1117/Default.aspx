<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Tip Calculator</h1>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Meal Amount"></asp:Label>  
            <!-- Renamed text box because it will be used in code -->  
            <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="TipPercentsRBL" runat="server"></asp:RadioButtonList>
            <asp:TextBox ID="OtherTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
            <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </p>

    </form>
</body>
</html>
