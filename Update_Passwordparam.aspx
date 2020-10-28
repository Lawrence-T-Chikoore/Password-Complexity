<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Passwordparam.aspx.cs" Inherits="Password_Complexity.Update_Passwordparam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parameters</title>
     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
  

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    <link rel="stylesheet" href="Style.css">  
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
    <h1>Password Parameters</h1>
    
    <hr>

    <label for="TextBox1"><b>Password Length</b></label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
  
    <label for="TextBox2"><b>Minimum Uppercases</b></label>
   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <label for="TextBox3"><b>Minimum Lowercases</b></label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

    <label for="TextBox4"><b>Minimum Letters</b></label>
    <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>

     <label for="TextBox5"><b>Minimum Numbers</b></label>
     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    

     <label for="TextBox6"><b>Minimum Special Characters</b></label>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>


    <div class="clearfix">
 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" CssClass="btn" />
    
      
    </div>
  
             
            
           
             
             
        
       
    </form>
</body>
</html>
