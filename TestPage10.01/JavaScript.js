var user = {};
function getUser() {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        user = JSON.parse(this.responseText);
        if (user.userName != null) {
            login.style.display = 'none';
           
        }
        if (user.isAdmin) {
            add.style.display = 'block';
        }
        getItem();
    }
    xhttp.open("GET", "HtmlPage1.aspx?action=GetUser");
    xhttp.send();
}
var items = [];
function showMenu() {
    document.getElementById('main').innerHTML = '';
    document.getElementById('drinks').innerHTML = '';
    for (var i = 0; i < items.length; i++) {
       
        var cell = document.createElement("div");
        cell.className = "item";
        var grid = document.getElementById(items[i].pos);
        grid.appendChild(cell);
        var img = document.createElement("div");
        img.className = "img";
        img.style.backgroundImage = "url(" + items[i].src + ")";
        cell.appendChild(img);
        var name = document.createElement("div");
        name.className = "name";
        cell.appendChild(name);
        var hname = document.createElement("h1");
        name.appendChild(hname);
        hname.innerHTML = items[i].name;
        var price = document.createElement("div");
        price.className = "price";
        cell.appendChild(price);
        var pprice = document.createElement("p");
        price.appendChild(pprice);
        pprice.innerHTML = items[i].price + " ILS";
        if (user.isAdmin) {
            cell.style.height = '560px';
            var butbox = document.createElement("div");
            butbox.className = "butbox1";
            cell.appendChild(butbox);
            var button = document.createElement("button");
            butbox.appendChild(button);
            button.setAttribute("onclick", `deleteItem('${items[i].src}')`);
            button.innerHTML = "Delete";
        }
    }
}

function getItem() {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        items = JSON.parse(this.responseText);
        showMenu();
    }
    xhttp.open("GET", "Menu.aspx?action=getItem");
    xhttp.send();

}
function addItem() {
    var name = document.getElementById('name').value;
    var src = document.getElementById('src').value;
    var pos = document.getElementById('pos').value;
    var price = document.getElementById('price').value;

    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        if (this.responseText == 'ok') {
            getItem();
        }
        else {
            alert("Addition failed");
        }
    }
    xhttp.open("GET", `Menu.aspx?action=addItem&name=${name}&src=${src}&pos=${pos}&price=${price}`);
    xhttp.send();

}
function deleteItem(src) {
    if (confirm('Are you sure?')) {
        const xhttp = new XMLHttpRequest();
        xhttp.onload = function () {
            if (this.responseText == 'ok') {
                getItem();
            }
            else {
                alert("Delete failed");
            }
        }
        xhttp.open("GET", `Menu.aspx?action=deleteItem&src=${src}`);
        xhttp.send();
    }
}