using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace FathersAlbum
{
    /// <summary>
    /// 扩展方法们
    /// </summary>
    public static class ExtendMethod
    {
        /// <summary>
        /// 在组链表中按照名称寻找相应的FaceGroup
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static FaceGroup GetGroupByname(this List<FaceGroup> model,string name)
        {
            foreach (var group in model)
            {
                if (group.name.Equals(name))
                    return group;
            }
            return null;
        }

        /// <summary>
        /// 在用户链表中根据名称寻找相应的FaceUser
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static FaceUser GetUserByName(this List<FaceUser> model, string name)
        {
            foreach (var user in model)
            {
                if (user.name.Equals(name))
                    return user;
            }
            return null;
        }

        /// <summary>
        /// 修复因为Json反序列化而丢失的自引用关系
        /// </summary>
        /// <param name="model"></param>
        public static void FixU_Grelation(this List<FaceGroup> model)
        {
            foreach (var group in model)
            {
                foreach (var user in group.UserList)
                {
                    user.BelongGroup = group;
                }
            }
        }

        /// <summary>
        /// 检测这个API返回的ErrorCode是不是0
        /// </summary>
        /// <param name="model"></param>
        public static bool CheckErrorCodeZero(this JObject model)
        {
            int errorcode = model.GetValue("error_code").ToObject<int>();
            if (errorcode == 0)
                return true;
            return false;
        }

        public static int GetErrorCode(this JObject model)
        {
            try
            {
                return model.GetValue("error_code").ToObject<int>();
            }
            catch 
            {
                return -1;
            }
        }


        /// <summary>
        /// 扩展方法让string对象可以直接进行IsNullorEmpty判断
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool IsNullorEmpty(this string model)
        {
            if (String.IsNullOrEmpty(model))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
