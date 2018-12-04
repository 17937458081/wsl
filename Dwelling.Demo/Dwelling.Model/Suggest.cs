using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
  public  class Suggest
    {
        /// <summary>
        /// 建议ID
        /// </summary>
        public int Suggest_ID { get; set; }
        /// <summary>
        /// 建议类型
        /// </summary>
        public int Suggest_Type { get; set; }
        /// <summary>
        /// 建议内容
        /// </summary>
        public string Suggest_Content { get; set; }
        /// <summary>
        /// 建议图片
        /// </summary>
        public string Suggest_Img { get; set; }
        /// <summary>
        /// 建议所属用户
        /// </summary>
        public int Users_ID { get; set; }
    }
}
