<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Donate! GIVE US MONEY!!</h1>
        <p>
            Enter donation Amount. More is better
        </p>
        <p>
            $<asp:TextBox ID="DonationTextBox" runat="server" ></asp:TextBox>
        </p>
        <asp:Button ID="DonateButton" runat="server" Text="Donate" OnClick="DonateButton_Click" />
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
