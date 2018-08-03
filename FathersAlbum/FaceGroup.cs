using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FathersAlbum
{
    /// <summary>
    /// 本文件内是人脸组和人脸用户的相关包装和方法
    /// </summary>
    [Serializable]
    public class FaceGroup
    {
        public static List<FaceGroup> GroupList=new List<FaceGroup>(); //总的分组列表


        public List<FaceUser> UserList=new List<FaceUser>();         //该分组的用户列表
        public string name { get; set; }                             //该分组的名字
        public string id { get; set; }                               //该分组的id


        public FaceGroup(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(FaceUser user)
        {
            if (user != null)
            {
                //将待添加的用户所属组别设置好
                user.BelongGroup = this;
                UserList.Add(user);
            }
        }

        /// <summary>
        /// 删除用户,若用户不存在则无动作
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUser(FaceUser user)
        {
            int index = UserList.IndexOf(user);
            if (index >= 0)
            {
                UserList.RemoveAt(index);
            }
        }
    }

    [Serializable]
    public class FaceUser
    {
        public string name { get; set; }                      //用户名称
        public string uid { get; set; }                       //用户uid
        public string imagebase64 { get; set; }               //用户照片base64
        [JsonIgnore]
        public FaceGroup BelongGroup { get; set; }            //属于的分组
        public string UserInfo { get; set; }

        public FaceUser(string name, string uid, string imagebase64,FaceGroup belongGroup = null,string userInfo="")
        {
            this.name = name;
            this.uid = uid;
            this.imagebase64 = imagebase64;
            BelongGroup = belongGroup;
            UserInfo = userInfo;
        }
    }
}
