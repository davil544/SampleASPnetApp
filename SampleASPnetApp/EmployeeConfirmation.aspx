<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeConfirmation.aspx.cs" Inherits="SampleASPnetApp.EmployeeConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Registration</title>
	<link href="Content/bootstrap.css" rel="stylesheet" />
	<link href="Content/bootstrap-theme.css" rel="stylesheet" />
	<script src="Scripts/jquery-1.9.1.js"></script>
	<script src="Scripts/bootstrap.js"></script>
</head>
<body>
  <div class="container">
    <form id="form1" runat="server">
        <div class="panel panel-danger">
			<div class="panel-heading">
				<h2>Confirm employee information</h2>
			</div>
        </div>

		<div class="panel-body">
			<div class="form-group">
				<label>First Name: </label>
				<asp:Label ID="lblFname" runat="server" Text="FirstName" CssClass="form-control"></asp:Label>

				<label>Last Name: </label>
				<asp:Label ID="lblLname" runat="server" Text="LastName" CssClass="form-control"></asp:Label>

				<label>Address 1: </label>
				<asp:Label ID="lblAdd1" runat="server" Text="Address1" CssClass="form-control"></asp:Label>

				<label>Address 2: </label>
				<asp:Label ID="lblAdd2" runat="server" Text="Address2" CssClass="form-control"></asp:Label>

				<label>City: </label>
				<asp:Label ID="lblCity" runat="server" Text="City" CssClass="form-control"></asp:Label>

				<label>State: </label>
				<asp:Label ID="lblState" runat="server" Text="State" CssClass="form-control"></asp:Label>

				<label>Zip (Postal) Code: </label>
				<asp:Label ID="lblZip" runat="server" Text="12345" CssClass="form-control"></asp:Label>
			</div>

			<div class="form-group text-center">
				<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
				<asp:Button ID="btnBack" runat="server" Text="Go Back" OnClick="btnBack_Click" />
			</div>

		</div>
    </form>
  </div>
</body>
</html>
