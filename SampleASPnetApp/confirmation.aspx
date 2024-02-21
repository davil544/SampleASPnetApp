<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmation.aspx.cs" Inherits="SampleASPnetApp.confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="panel panel-success">
                <div class="panel-heading"> 
                    <h2>Customer Info Confirmation</h2>
                </div>
            </div>

            <div class="panel-body">

                <div class="form-group">
                    <label>First Name: </label>
                    <asp:Label ID="lblFname" runat="server" Text="FirstName" CssClass="form-control"></asp:Label>
                    
                    <label>Middle Name: </label>
                    <asp:Label ID="lblMname" runat="server" Text="Middle Name" CssClass="form-control"></asp:Label>

                    <label>Last Name: </label>
                     <asp:Label ID="lblLname" runat="server" Text="LastName" CssClass="form-control"></asp:Label>
                    
                    <label>Address 1: </label>
                     <asp:Label ID="lblAdd1" runat="server" Text="Address 1" CssClass="form-control"></asp:Label>
                   

                    <label>Address 2: </label>
                     <asp:Label ID="lblAdd2" runat="server" Text="Address 2" CssClass="form-control"></asp:Label>
                 

                    <label>City: </label>
                     <asp:Label ID="lblCity" runat="server" Text="City" CssClass="form-control"></asp:Label>
                    

                    <label>State: </label>
                     <asp:Label ID="lblState" runat="server" Text="State" CssClass="form-control"></asp:Label>
                   

                    <label>Zip (Postal) Code: </label>
                     <asp:Label ID="lblZip" runat="server" Text="12345" CssClass="form-control"></asp:Label>
                    
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="BtnBack" runat="server" Text="Back" OnClick="BtnBack_Click" />
                </div>

            </div> <%--Closes Panel Body --%>
        </div>
    </form>
</body>
</html>
