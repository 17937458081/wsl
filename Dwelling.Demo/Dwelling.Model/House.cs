using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
  public  class House
    {
        /// <summary>
        /// 房源ID
        /// </summary>
        public int House_ID { get; set; }
        /// <summary>
        /// 房源名
        /// </summary>
        public string House_Name { get; set; }
        /// <summary>
        /// 房源价格
        /// </summary>
        public decimal House_Price { get; set; }
        /// <summary>
        /// 居室户型
        /// </summary>
        public int HabitableRoom_ID { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        public double House_Area { get; set; }
        /// <summary>
        /// 朝向
        /// </summary>
        public int Orientation_ID { get; set; }
        /// <summary>
        /// 房源风格
        /// </summary>
        public int Style_ID { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string House_Address { get; set; }
        /// <summary>
        /// 出租类型
        /// </summary>
        public int LeaseType_ID { get; set; }
        /// <summary>
        /// 楼层
        /// </summary>
        public int House_Floor { get; set; }
        /// <summary>
        /// 总楼层
        /// </summary>
        public int House_SumFloor { get; set; }
        /// <summary>
        /// 楼房类型
        /// </summary>
        public int BuildingType_ID { get; set; }
        /// <summary>
        /// 房屋设施
        /// </summary>
        public string House_Facility { get; set; }
        /// <summary>
        /// 租房开始日期
        /// </summary>
        public DateTime House_RentTimeBegin { get; set; }
        /// <summary>
        /// 租房结束日期
        /// </summary>
        public DateTime House_RentTimeEnd { get; set; }
        /// <summary>
        /// 房源所属人
        /// </summary>
        public int House_Owner { get; set; }
        /// <summary>
        /// 房源所属人电话
        /// </summary>
        public string House_OwnerTel { get; set; }
        /// <summary>
        /// 房源所属人微信
        /// </summary>
        public string House_OwnerWx { get; set; }
        /// <summary>
        /// 租金
        /// </summary>
        public decimal House_RentMoney { get; set; }
        /// <summary>
        /// 租房付款方式
        /// </summary>
        public string House_Payment { get; set; }
        /// <summary>
        /// 点击数
        /// </summary>
        public int House_ClickNum { get; set; }
        /// <summary>
        /// 房源图片
        /// </summary>
        public int House_Image { get; set; }
    
}
}
