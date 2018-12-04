using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
  public  class Collect
    {
        /// <summary>
        /// 收藏ID
        /// </summary>
        public int Collect_ID { get; set; }
        /// <summary>
        /// 所属用户
        /// </summary>
        public int Users_ID { get; set; }
        /// <summary>
        /// 房源编号
        /// </summary>
        public int House_ID { get; set; }
    }
}
