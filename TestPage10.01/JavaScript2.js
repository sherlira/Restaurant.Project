//var items = []; 
//function showMenu() {
//    for (var i = 0; i < items.length; i++) {
//        var cell = document.createElement("div");
//        cell.className = "item";
//        var grid = document.getElementById(items[i].pos);
//        grid.appendChild(cell);
//        var img = document.createElement("div");
//        img.className = "img";
//        img.style.backgroundImage = "url(" + items[i].src + ")";
//        cell.appendChild(img);
//        var name = document.createElement("div");
//        name.className = "name";
//        cell.appendChild(name);
//        var hname = document.createElement("h1");
//        name.appendChild(hname);
//        hname.innerHTML = items[i].name;
//        var price = document.createElement("div");
//        price.className = "price";
//        cell.appendChild(price);
//        var pprice = document.createElement("p");
//        price.appendChild(pprice);
//        pprice.innerHTML = items[i].price + " ILS";
//    }
//}

//function getItem() {
//    const xhttp = new XMLHttpRequest();
//    xhttp.onload = function () {
//        items = JSON.parse(this.responseText);
//        showMenu();
//    }
//    xhttp.open("GET", "Menu.aspx?action=getItem");
//    xhttp.send();

//}
//function chekUser() {
//    // if user loged in
//    if (user.userName) {
//        login1.style.display = 'none';
//    }
//}
//var user = {};
//function getUser() {
//    const xhttp = new XMLHttpRequest();
//    xhttp.onload = function () {
//        user = JSON.parse(this.responseText);
//        if (user.userName != null) {
//            login1.style.display = 'none';

//        }

//    }
//    xhttp.open("GET", "HtmlPage1.aspx?action=GetUser");
//    xhttp.send();
//}
