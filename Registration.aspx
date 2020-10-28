<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Password_Complexity.Registration" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Tooltips</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    <link rel="stylesheet" href="Style.css">    
</head>
<body>

 <form  style="border:1px solid #ccc" runat="server">
  <div class="container">
    <h1>Sign Up</h1>
    <p>Please fill in this form to create an account.</p>
    <hr>

    <label for="txtusername"><b>Username</b></label>
    <asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
  
    <label for="txtpassword"><b>Password</b></label>
    <asp:TextBox ID="txtpassword" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>

    <label for="txtconfirmpass"><b>Repeat Password</b></label>
   <asp:TextBox ID="txtconfirmpass" runat="server" placeholder="Reapet Password" TextMode="Password"></asp:TextBox>
      <asp:Label ID="Label1" runat="server" Text="Label" Visible="false" ForeColor="red"  ></asp:Label>
  

    <div class="clearfix">

    
     <asp:Button ID="Button1" runat="server" Text="submit" CssClass="btn" OnClick="Button1_Click1"/>
      
    </div>
  </div>
</form>
</body>
</html>