<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table.aspx.cs" Inherits="Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
    <title>Reserve a table</title>
     <link href="./css/styleTable.css" rel="stylesheet" type="text/css" />
</head>
<body>
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
  
</div>
                       <div class="conteiner2">
        <div class="contentbox">
            <div class="h">
                <h1>Reserve a table</h1>
            </div>
          <label for="name"><b>Name</b></label>
          <input type="text" placeholder="Enter Name" name="name" id="name" />

         <label for="date"><b>Date</b></label>
         <input type="date" placeholder="Enter Date" name="date" id="date"/>

             <label for="time"><b>Time</b></label>
 <input type="text" placeholder="Enter time" name="time" id="time"/>

             <label for="guests"><b>Number of guests</b></label>
         <input type="number" placeholder="Enter number of guests" name="guests" id="guests"/>

         <div id="phone">  <label for="phoneNumber"><b>Phone number</b></label>
 <input type="tel" placeholder="Enter Phone number" name="phoneNumber" id="phoneNumber"/></div>

         <button type="submit">Reserve</button>

        
        </div>
        </div>
    </div>
</div>
    </form>
</body>
</html>
