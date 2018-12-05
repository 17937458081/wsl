using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
    public class Admin
    {
        /// <summary>
        ///管理员ID  王帅磊
        /// </summary>
        [Key]
        public int Admin_ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Admin_Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Admin_Password { get; set; }
        /// <summary>
        /// 身份
        /// </summary>
        public int Admin_Permission { get; set; }
    }
}
