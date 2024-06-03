<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
     <link href="./css/styleLogin.css" rel="stylesheet" type="text/css" />
    <title>Login</title>
</head>
<body >
    <form id="form1" runat="server">
           <div class="bgimj"> <img src="img/slider4.jpg" /> </div>
       <div class="block1">
           <div class="conteiner">
                <div class="toplink">
    <div class="logo"> <img src="img/logo.png" width="60" height="50" /> </div>
    <div class="libox">
        <a href="HtmlPage1.html">HOME PAGE</a>
        <a href="Menu.html">SEE MENU & ORDER</a>
        <a href="HtmlPage1.html#block3">OUR RESTAURANTS</a>
        <a href="HtmlPage1.html#block4">CONTACT</a>
        <a href="HtmlPage2.html">COOK-CHEF</a>
    </div>
    <div class="butbox">
          
         <button> <a href="Table.aspx">RESERVE A TABLE</a></button>
        
    </div>
</div>
               <div class="conteiner2">
               <div class="contentbox">
                   <div class="h">
                       <h1>Sign in</h1>
                   </div>
                 <label for="userName"><b>Username</b></label>
                 <input type="text" placeholder="Enter Username" name="userName" id="userName" />

                <label for="password"><b>Password</b></label>
                <input type="password" placeholder="Enter Password" name="password" id="password"/>

                <button type="submit">Login</button>
                <div class="p">
                    <p> Don't have an account?.. </p> <a href="Register.aspx">Sign up!</a>

                </div>
               </div>
               </div>
           </div>
       </div>
    </form>
     <% =errorMessage %>
</body>
</html>
