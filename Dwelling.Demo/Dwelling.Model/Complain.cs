using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
   public class Complain
    {
        /// <summary>
        /// 投诉表ID
        /// </summary>
        public int Complain_ID { get; set; }
        /// <summary>
        /// 投诉内容
        /// </summary>
        public string Complain_Content { get; set; }
        /// <summary>
        /// 投诉阶段
        /// </summary>
        public string Complain_Phases { get; set; }
        /// <summary>
        /// 投诉结果
        /// </summary>
        public string Complain_Result { get; set; }
        /// <summary>
        /// 投诉所属用户
        /// </summary>
        public int Users_ID { get; set; }
    }
}
