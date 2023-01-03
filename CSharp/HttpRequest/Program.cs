using System.Net;
using System.Text;
using System.IO;



string url = "https://oapi.dingtalk.com/robot/send?access_token=442c3cf741b100d24e724e14e2cabf3efdee1cccd67ada8d880ff41198fed82b";
var request = (HttpWebRequest)WebRequest.Create(url);


var postData = File.ReadAllText("F:\\Code\\CSharp\\HttpRequest\\POSTData.json");
var data = Encoding.ASCII.GetBytes(postData);

request.Method = "POST";
request.ContentType = "application/json";
request.ContentLength = postData.Length;



using (var stream = request.GetRequestStream()) {
    stream.Write(data, 0, data.Length);
}
var response = (HttpWebResponse)request.GetResponse();