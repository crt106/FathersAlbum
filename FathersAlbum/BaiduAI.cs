using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public const string MultiIdentifyUrl = "https://aip.baidubce.com/rest/2.0/face/v2/multi-identify";

        public static string APP_ID = AppConfig.GetValue("AppID");
        public static string API_key = AppConfig.GetValue("APIkey");
        public static string Secret_key = AppConfig.GetValue("Secretkey");

        public static Face BaiduClient;                               //百度AI客户端

        /// <summary>
        /// 构造函数兼初始化
        /// </summary>
        public BaiduAI()
        {
            BaiduClient = new Face(API_key,Secret_key);
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
        public static JObject MultiIdentify(string token,string groupId,string image_base64,int detect_top_num=3,int user_top_num=2)
        {
            try
            {
                // 调用M:N 识别，可能会抛出网络等异常，请使用try/catch捕获

                //创建http客户端
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");  //添加请求头
                    client.Timeout = new TimeSpan(0, 0, 10);                                                  //设置超时时间
                    Uri requestUri = new Uri(MultiIdentifyUrl + "?access_token=" + token);                       //设置Uri

                    List<KeyValuePair<string, string>> bodylist = new List<KeyValuePair<string, string>>();
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
                    FormUrlEncodedContent bodyform = new FormUrlEncodedContent(bodylist);
                    HttpResponseMessage response = client.PostAsync(requestUri, bodyform).Result;
                    string jsondata = response.Content.ReadAsStringAsync().Result;
                    return new JObject(jsondata);
                }               
            }
            catch (Exception e)
            {
                Debug.WriteLine("M:N识别抛出异常\n"+e.ToString());
                return null;  
            }
        }
    }
}
