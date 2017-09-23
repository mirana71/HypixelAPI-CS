using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace HypixelCSHARP
{
     class HypixelAPI
     {
         private static string API_URL = "https://api.hypixel.net/";
         private static string API_KEY = "#"; //replace this with your api key

         public static string getPlayerByUuid(string uuid)
         {
             var reply = "";

             var URL = API_URL + "player?key=" + API_KEY + "&uuid=" + uuid;

             WebResponse webResponse = null;
             StreamReader streamReader = null;

             try
             {
                 HttpWebRequest req = (HttpWebRequest) WebRequest.Create(URL);
                 req.Method = "GET";
                 
                 webResponse = req.GetResponse();
                 streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                 reply = streamReader.ReadToEnd();
             }
             catch (WebException e)
             {
                 Console.Write(e);
             }
             if (streamReader != null)
             {
                 streamReader.Close();
                 Console.Write("Streamer closed!");
             } else if (webResponse != null)
             {
                 webResponse.Close();
                 Console.Write("Response closed!");
             }
             return reply;
         }
         public static string getPlayerByPlayer(string player)
         {
             var reply = "";

             var URL = API_URL + "player?key=" + API_KEY + "&player=" + player;

             WebResponse webResponse = null;
             StreamReader streamReader = null;

             try
             {
                 HttpWebRequest req = (HttpWebRequest) WebRequest.Create(URL);
                 req.Method = "GET";
                 
                 webResponse = req.GetResponse();
                 streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                 reply = streamReader.ReadToEnd();
             }
             catch (WebException e)
             {
                 Console.Write(e);
             }
             if (streamReader != null)
             {
                 streamReader.Close();
                 Console.Write("Streamer closed!");
             } else if (webResponse != null)
             {
                 webResponse.Close();
                 Console.Write("Response closed!");
             }
             return reply;
         }
         
     }
}