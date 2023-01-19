using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect3
{
    public static class LoginState
    {
        public static bool isLoggedIn { get; set; } = true;
        public static bool isAdmin { get; set; } = true;
        public static int Id { get; set; }
        public static string Username { get; set; }
    }
}