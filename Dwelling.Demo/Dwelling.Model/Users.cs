using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
    public class Users
    {
        /// <summary>
        /// 用户名ID
        /// </summary>
        [Key]
        public int Users_ID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Users_Name { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Users_HeadImg { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        public int Users_Gender { get; set; }
        /// <summary>
        /// 用户手机
        /// </summary>
        public string Users_Tel { get; set; }
        /// <summary>
        /// 用户SessionKey
        /// </summary>
        public string Users_SessionKey { get; set; }

    }
    
}
