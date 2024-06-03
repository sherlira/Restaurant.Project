using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{
    public string name { get; set; }
    public string src {  get; set; } 
    public string pos { get; set; }
    public int price {  get; set; } 
    public Item()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Item(string name, string src, string pos, int price)
    {
        this.name = name;
        this.src = src;
        this.pos = pos;
        this.price = price;
    }
}