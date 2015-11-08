using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTickets
    {
    class Program
        {
        static void Main(string[] args)
            {
            System.Net.WebClient wc = new System.Net.WebClient();
            string websiteName = "http://www.ramesar.net/"; // Put the website name here. I think it has to have the http://
            string webData = wc.DownloadString(websiteName);

            // Writes the website data to the console.
            Console.WriteLine(webData);
            }
        }
    }
