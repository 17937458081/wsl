using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
   public class LeaseType
    {
        /// <summary>
        /// 出租ID
        /// </summary>
        public int LeaseType_ID { get; set; }
        /// <summary>
        /// 出租类型
        /// </summary>
        public string LeaseType_Name { get; set; }
    }
}
