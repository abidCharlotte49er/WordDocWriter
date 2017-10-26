﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WordDocWriter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word Document Writer</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
</head>
<body>
    <div class="container">

        <form id="Frm_Main" runat="server">
            <div class="form-group">
                <label for="Inp_fName">First Name</label>
                <input class="form-control" id="Inp_fName" placeholder="First Name" runat="server">
            </div>
            <div class="form-group">
                <label for="Inp_lName">Last Name</label>
                <input class="form-control" id="Inp_lName" placeholder="Last Name" runat="server">
            </div>
            <div class="form-group">
                <label for="exampleFormControlTextarea1">Comments</label>
                <textarea class="form-control" id="Txt_Comment" rows="3" runat="server"></textarea>
            </div>
            <div class="form-group">
                <asp:Button ID="Btn_CreateDoc" runat="server" Text="Create Word Doc" OnClick="Btn_CreateDoc_Click" />
            </div>
        </form>
    </div>

</body>
</html>
