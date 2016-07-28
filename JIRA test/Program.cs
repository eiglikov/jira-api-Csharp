using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIRA_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to a Jira Example application!");

            //Console.Write("Username: ");
            //string username = Console.ReadLine();
            string username = "";
            string password = "";
            //Console.Write("Password: ");
            //string password = Console.ReadLine();

            JiraManager manager = new JiraManager(username, password);
            manager.RunQuery(JiraResource.project);

            Console.Read();
        }
    }
}
