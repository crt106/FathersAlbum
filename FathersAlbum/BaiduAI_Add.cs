using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FathersAlbum
{
    /// <summary>
    /// 提供百度AI 中的一些辅助或者扩展功能
    /// </summary>
    public class BaiduAI_Add
    {
        public const string MultiIdentifyUrl = "https://aip.baidubce.com/rest/2.0/face/v2/multi-identify";

        public static string API_key = AppConfig.GetValue("APIkey");
        public static string Secret_key = AppConfig.GetValue("Secretkey");
        

        public static JObject MultiIdentify(string token,string groupId,string image_base64)
        {
            try
            {
                // 调用M:N 识别，可能会抛出网络等异常，请使用try/catch捕获
                //创建http客户端
                HttpWebRequest request = WebRequest.CreateHttp(MultiIdentifyUrl+ "?access_token="+token);
                request.Timeout = 20000;
                request.Method = "post";
                request.KeepAlive = true;
                request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");  //设置请求头

                
                var options = new Dictionary<string, object>
                {
                    {"ext_fields", "faceliveness"},
                    {"detect_top_num", 3},
                    {"user_top_num", 2}
                };
                // 带参数调用M:N 识别
                result = client.MultiIdentify(groupId, image, options);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
