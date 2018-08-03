using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms.VisualStyles;

//注意需要引用 System.Configuration

/// <summary>
/// 管理程序设置的类
/// </summary>
namespace FathersAlbum
{

    public class AppConfig
    {
        private static Configuration config;

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            string strReturn = (string)Properties.Settings.Default[key];
            return strReturn;
        }

        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValue(string key, string value)
        {
            if (Properties.Settings.Default[key] != null) 
            Properties.Settings.Default[key] = value;
        }

        
    }
}


