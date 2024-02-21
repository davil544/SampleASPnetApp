<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegistration.aspx.cs" Inherits="SampleASPnetApp.EmployeeRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Registration</title>
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
				<h2>Employee Registration</h2>
			</div>
        </div>

		<div class="panel-body">
			<div class="form-group">
				<label>First Name: </label>
				<asp:TextBox ID="txtFname" runat="server" CssClass="form-control"></asp:TextBox>

				<label>Last Name: </label>
				<asp:TextBox ID="txtLname" runat="server" CssClass="form-control"></asp:TextBox>

				<label>Address 1: </label>
				<asp:TextBox ID="txtAdd1" runat="server" CssClass="form-control"></asp:TextBox>

				<label>Address 2: </label>
				<asp:TextBox ID="txtAdd2" runat="server" CssClass="form-control"></asp:TextBox>

				<label>City: </label>
				<asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>

				<label>State: </label>
				<asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>

				<label>Zip (Postal) Code: </label>
				<asp:TextBox ID="txtZip" runat="server" CssClass="form-control"></asp:TextBox>
			</div>

			<div class="form-group text-center">
				<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
				<asp:Button ID="btnClear" runat="server" Text="Clear Form" OnClick="btnClear_Click" />
			</div>
		</div>
    </form>

	  <div id="divOutput" runat="server"></div>
  </div>
</body>
</html>
