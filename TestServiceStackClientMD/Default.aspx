<%@ Page Language="C#" Inherits="TestServiceStackClientMD.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Repeater runat="server" id="rptrTests">
		<ItemTemplate>
		<h2>UserName: <asp:Label runat="server" id="hUsername" /></h2>
		<table border="1" width="400">
			<tr>
				<td>Message:</td>
				<td><asp:Label runat="server" id="lMessage" /></td>
			</tr>
			<tr>
				<td>Success:</td>
				<td><asp:Label runat="server" id="lSuccess" /></td>
			</tr>
			<tr>
				<td>User:</td>
				<td><asp:Label runat="server" id="lUser" /></td>
			</tr>
			<tr>
				<td>Username</td>
				<td><asp:Label runat="server" id="lUsername" /></td>
			</tr>
			<tr>
				<td>First Name</td>
				<td><asp:Label runat="server" id="lFirstName" /></td>
			</tr>
			<tr>
				<td>Last Name</td>
				<td><asp:Label runat="server" id="lLastName" /></td>
			</tr>
			<tr>
				<td>Address</td>
				<td><asp:Label runat="server" id="lAddress" /></td>
			</tr>
			<asp:PlaceHolder id="phAddress" runat="server">
				<tr>
					<td>Street</td>
					<td><asp:Label runat="server" id="lAddressStreet" /></td>
				</tr>
				<tr>
					<td>City</td>
					<td><asp:Label runat="server" id="lCity" /></td>
				</tr>
				<tr>
					<td>State</td>
					<td><asp:Label runat="server" id="lState" /></td>
				</tr>
				<tr>
					<td>Zip</td>
					<td><asp:Label runat="server" id="lZip" /></td>
				</tr>
			</asp:PlaceHolder>
		</table>
		</ItemTemplate>
		</asp:Repeater>
	</form>
</body>
</html>
