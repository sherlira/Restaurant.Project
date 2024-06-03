using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public string userName { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public string phoneNumber { get; set; }

    public bool isAdmin { get; set; }
    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public User(string userName, string password, string email, string phoneNumber, bool isAdmin)
    {
        this.userName = userName;
        this.password = password;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.isAdmin = isAdmin;
    }
}