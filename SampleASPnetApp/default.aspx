<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SampleASPnetApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
<div class="container">
    <form id="form1" runat="server">
        <div>
            <div class="panel panel-success">
                <div class="panel-heading"> 
                    <h2>Customer Registration</h2>
                </div>
            </div>

            <div class="panel-body">

                <div class="form-group">
                    <label>First Name: </label>
                    <asp:TextBox ID="txtFname" runat="server" CssClass="form-control"></asp:TextBox>

                    <label>Middle Name: </label>
                    <asp:TextBox ID="txtMname" runat="server" CssClass="form-control"></asp:TextBox>

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
                    <asp:Button ID="btnOK" runat="server" Text="Ok" OnClick="btnOK_Click" />
                    <asp:Button ID="BtnClr" runat="server" Text=":P" />
                </div>

				<div id="EmployeeLink">
					<a href="EmployeeRegistration.aspx">Employees Click Here</a>
				</div>

            </div> <%--Closes Panel Body --%>
        </div>
    </form>

    <div id="divOutput" runat="server"></div>
</div>
</body>
</html>
