using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNS
{
    public class Exercise1
    {
        public bool login(String username, String password)
        {
            // check parameters are not in blank
            if (username.CompareTo("") == 0)
            {
                return false;
            }
            if (password.CompareTo("") == 0)
            {
                return false;
            }
            // check parameters lenght < 30
            if (username.Length > 30)
            {
                return false;
            }
            if (password.Length > 30)
            {
                return false;
            }

            // call to mock DB method
            return checkLogininDB(username, password);
        }
        public bool checkLogininDB
         (String username, String password)
        {
            // método mock (simulado)
            if (username == "user" && password == "pass")
                return true;
            else
                return false;
        }

    }
}
