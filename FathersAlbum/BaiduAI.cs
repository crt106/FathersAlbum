using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Baidu.Aip.Face;
using Newtonsoft.Json.Linq;

namespace FathersAlbum
{
    /// <summary>
    /// 提供百度AI 中的一些辅助或者扩展功能
    /// </summary>
    public class BaiduAI
    {
        private const string MultiIdentifyUrl = "https://aip.baidubce.com/rest/2.0/face/v2/multi-identify";
        private const string GetTokenUrl = "https://aip.baidubce.com/oauth/2.0/token";
        private static string access_token = "";
        private static string APP_ID;
        private static string API_key;
        private static string Secret_key;

        public static Face BaiduClient;                               //百度AI客户端

        /// <summary>
        /// 构造函数兼初始化
        /// </summary>
        public BaiduAI()
        {
            APP_ID= AppConfig.GetValue("AppID");
            API_key = AppConfig.GetValue("APIkey");
            Secret_key = AppConfig.GetValue("Secretkey");
            BaiduClient = new Face(API_key,Secret_key);
            //Refreshtoken();
        }

        /// <summary>
        /// 刷新应用使用的token
        /// </summary>
        public async void Refreshtoken()
        {
            using (HttpClient client = new HttpClient())
            {
                List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
                paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                paraList.Add(new KeyValuePair<string, string>("client_id", API_key));
                paraList.Add(new KeyValuePair<string, string>("client_secret", Secret_key));
                FormUrlEncodedContent bodyform=new FormUrlEncodedContent(paraList);
                HttpResponseMessage response = null;
                await Task.Run(() => { response = client.PostAsync(GetTokenUrl, bodyform).Result;});

                string resultstr = response.Content.ReadAsStringAsync().Result;
                //将返回的Json中的token获取出来
                JObject resultJson=JObject.Parse(resultstr);
                access_token = (string)resultJson.GetValue("refresh_token");

                Debug.WriteLine("access_token刷新为"+access_token);
                FormMain.statusLabelchange("access_token刷新完毕");
            }
        }

        /// <summary>
        /// 进行M:N人脸查找
        /// </summary>
        /// <param name="token">access_token</param>
        /// <param name="groupId">用户组id</param>
        /// <param name="image_base64">要查找的图片的base64</param>
        /// <param name="detect_top_num">检测多少个人脸进行比对 默认3</param>
        /// <param name="user_top_num">返回识别结果top数 默认2</param>
        /// <returns></returns>
        [Obsolete]
        public static JObject MultiIdentify(string groupId, string image_base64, int detect_top_num = 3,
            int user_top_num = 2)
        {
            Uri requestUri = new Uri(MultiIdentifyUrl + "?access_token=" + access_token);          //设置Uri


            try
            {
                // 调用M:N 识别，可能会抛出网络等异常，请使用try/catch捕获

                //创建http客户端
                /*using (HttpClient client = new HttpClient())
                {
                   
                    client.Timeout = new TimeSpan(0, 0, 10);                                                  //设置超时时间

                    List<KeyValuePair<string, string>> bodylist = new List<KeyValuePair<string, string>>();

                    //这里对ImageBase64进行urlEncode
                    image_base64 = System.Web.HttpUtility.UrlEncode(image_base64);
                    bodylist.Add(new KeyValuePair<string, string>("image", image_base64));
                    bodylist.Add(new KeyValuePair<string, string>("group_id", groupId));
                    bodylist.Add(new KeyValuePair<string, string>("detect_top_num", detect_top_num.ToString()));
                    bodylist.Add(new KeyValuePair<string, string>("user_top_num", user_top_num.ToString()));  //设置body内容

                    //                var options = new Dictionary<string, object>
                    //                {
                    //                    {"ext_fields", "faceliveness"},
                    //                    {"detect_top_num", 3},
                    //                    {"user_top_num", 2}
                    //                };
                    HttpRequestMessage request=new HttpRequestMessage(HttpMethod.Post, requestUri);
                    request.Content = new FormUrlEncodedContent(bodylist);
                    request.Content.Headers.ContentType=new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                    //FormUrlEncodedContent bodyform = new FormUrlEncodedContent(bodylist);

                    //HttpResponseMessage response = client.PostAsync(requestUri, bodyform).Result;

                    HttpResponseMessage response = client.SendAsync(request).Result;
                    string jsondata = response.Content.ReadAsStringAsync().Result;
                    //返回Json字符串
                    return new JObject(jsondata);
                }*/

                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUri);
                //设置Header
                request.Method = WebRequestMethods.Http.Post;
                request.KeepAlive = true;
                request.ContentType = "application/x-www-form-urlencoded";

                //这里对ImageBase64进行urlEncode
                image_base64 = System.Web.HttpUtility.UrlEncode(image_base64);
                //构建body
                string body = "image=" + image_base64 + "&group_id=" + groupId + "&detect_top_num=" + detect_top_num +
                              "&user_top_num=" + user_top_num;
                byte[] bodybuffer = Encoding.UTF8.GetBytes(body);
                //继续设置头
                request.ContentLength = bodybuffer.LongLength;
                request.GetRequestStream().Write(bodybuffer,0,bodybuffer.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sreader = new StreamReader(response.GetResponseStream(),Encoding.UTF8);
                string resultJson = sreader.ReadToEnd();
                return JObject.Parse(resultJson);

            }
            catch (Exception e)
            {
                Debug.WriteLine("M:N识别抛出异常\n"+e.ToString());
                return null;  
            }
        }

        
    }
}
