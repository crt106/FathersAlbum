using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

//注意需要引用 System.Configuration
/// <summary>
/// 管理程序设置的类
/// </summary>
namespace FathersAlbum
{

    public class AppConfig
    {
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            string strReturn = null;
            if (config.AppSettings.Settings[key] != null)
            {
                strReturn = config.AppSettings.Settings[key].Value;
            }
            return strReturn;
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValue(string key, string value)
        {
            if (config.AppSettings.Settings[key] != null)
            {
                config.AppSettings.Settings[key].Value = value;
            }
            else
            {
                config.AppSettings.Settings.Add(key, value);
            }
            config.Save(ConfigurationSaveMode.Modified);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        public static void DelValue(string key)
        {
            config.AppSettings.Settings.Remove(key);
        }
    }
}


