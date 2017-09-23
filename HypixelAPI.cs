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
         public static string getPlayerByName(string name)
         {
             var reply = "";

             var URL = API_URL + "player?key=" + API_KEY + "&name=" + name;

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
         public static string getFriendsByUuid(string uuid)
         {
             var reply = "";

             var URL = API_URL + "friends?key=" + API_KEY + "&uuid=" + uuid;

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
         public static string getFriendsByPlayer(string player)
         {
             var reply = "";

             var URL = API_URL + "friends?key=" + API_KEY + "&uuid=" + player;

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
         public static string getFriendsByName(string name)
         {
             var reply = "";

             var URL = API_URL + "friends?key=" + API_KEY + "&uuid=" + name;

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

         public static string getGuildInfo(String guildID)
         {
             var reply = "";
             string URL = API_URL + "guild?key=" + API_KEY + "&id=" + guildID;
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
         public static string findGuildByUuid(String uuid)
         {
             var reply = "";
             string URL = API_URL + "findGuild?key=" + API_KEY + "&byUuid=" + uuid;
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
         public static string findGuildByPlayer(String player)
         {
             var reply = "";
             string URL = API_URL + "findGuild?key=" + API_KEY + "&bbyPlayer=" + player;
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
         public static string findGuildByName(String name)
         {
             var reply = "";
             string URL = API_URL + "findGuild?key=" + API_KEY + "&byName=" + name;
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
         public static string getBoostersByName(string name)
         {
             var reply = "";
             string URL = API_URL + "boosters?key=" + API_KEY + "&id=" + name;
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
         public static string getBoostersByUuid(String uuid)
         {
             var reply = "";
             string URL = API_URL + "boosters?key=" + API_KEY + "&id=" + uuid;
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