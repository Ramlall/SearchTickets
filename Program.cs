using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SearchTickets
    {
    class Program
        {
        static void Main(string[] args)
            {
            // From https://msdn.microsoft.com/en-us/library/9w7b4fz7(v=vs.110).aspx 
            Console.Write("\nPlease enter the URI to post data to : ");
            string uriString = Console.ReadLine();

            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();

            // Create a new NameValueCollection instance to hold some custom parameters to be posted to the URL.
            NameValueCollection myNameValueCollection = new NameValueCollection();

            Console.WriteLine("Please enter the following parameters to be posted to the URL");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Age:");
            string age = Console.ReadLine();

            Console.Write("Address:");
            string address = Console.ReadLine();

            // Add necessary parameter/value pairs to the name/value container.
            myNameValueCollection.Add("Name", name);
            myNameValueCollection.Add("Address", address);
            myNameValueCollection.Add("Age", age);

            Console.WriteLine("\nUploading to {0} ...", uriString);
            // 'The Upload(String,NameValueCollection)' implicitly method sets HTTP POST as the request method.            
            byte[] responseArray = myWebClient.UploadValues(uriString, myNameValueCollection);

            // Decode and display the response.
            Console.WriteLine("\nResponse received was :\n{0}", Encoding.ASCII.GetString(responseArray));


            /*
            // From https://www.youtube.com/watch?v=bo6lLEHo3ZM
            using (WebClient client = new WebClient())
                {
                try
                    {
                    NameValueCollection collection = new NameValueCollection();
                    collection.Add("numA", "43");
                    collection.Add("numB", "22");
                    client.Proxy = null;
                    byte[] result = client.UploadValues("http://www.abelski.com/courses/csharp/sumform.php", "POST", collection);
                    //System.IO.File.WriteAllBytes("results.html", result);
                    //System.Diagnostics.Process.Start("results.html");
                    //string newWebsiteName = "";
                    //string webData = client.DownloadString(newWebsiteName);

                    // Writes the website data to the console.
                    Console.WriteLine(result);
                    }
                catch(WebException e)
                    { Console.WriteLine(e.Status); }

                }
            */
            /*
            System.Net.WebClient wc = new System.Net.WebClient();
            string websiteName = "http://www.jetblue.com/#/"; // Put the website name here. I think it has to have the http://

            NameValueCollection values = new NameValueCollection();
            values.Add("TextBox1", "value1");
            values.Add("TextBox2", "value2");
            values.Add("TextBox3", "value3");

            wc.UploadValues(websiteName, values);

            string newWebsiteName = "";
            string webData = wc.DownloadString(newWebsiteName);

            // Writes the website data to the console.
            Console.WriteLine(webData);
            */
            /*
            // From 
            webBrowser1.Document.GetElementById("c_Username").InnerText = "username";
            webBrowser1.Document.GetElementById("c_Password").InnerText = "pass";
            //login in to account(fire a login button promagatelly)
            webBrowser1.Document.GetElementById("c_LoginBtn_c_CommandBtn").InvokeMember("click");
            */
        }
        }
    }