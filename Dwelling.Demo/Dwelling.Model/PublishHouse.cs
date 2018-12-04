using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwelling.Model
{
  public  class PublishHouse
    {
        /// <summary>
        /// 发布房源表ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 户型
        /// </summary>
        public int HabitableRoom_ID { get; set; }
        /// <summary>
        /// 房间号
        /// </summary>
        public string PublishHouse_Num { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        public double PublishHouse_Area { get; set; }
        /// <summary>
        /// 朝向
        /// </summary>
        public int Orientation_ID { get; set; }
        /// <summary>
        /// 风格
        /// </summary>
        public int Style_ID { get; set; }
        /// <summary>
        /// 租金
        /// </summary>
        public decimal PublishHouse_RentMoney { get; set; }
        /// <summary>
        /// 楼层
        /// </summary>
        public int PublishHouse_Floor { get; set; }
        /// <summary>
        /// 总楼层
        /// </summary>
        public int PublishHouse_SumFloor { get; set; }
        /// <summary>
        /// 楼房类型
        /// </summary>
        public int BuildingType_ID { get; set; }
        /// <summary>
        /// 起租开始日期
        /// </summary>
        public DateTime PublishHouse_RentTimeBegin { get; set; }
        /// <summary>
        /// 起租结束日期
        /// </summary>
        public DateTime PublishHouse_RentTimeEnd { get; set; }
        /// <summary>
        /// 房源图片
        /// </summary>
        public string PublishHouse_Img { get; set; }
        /// <summary>
        /// 房源描述
        /// </summary>
        public string PublishHouse_Description { get; set; }
        /// <summary>
        /// 房源设施
        /// </summary>
        public string PublishHouse_Facility { get; set; }
        /// <summary>
        /// 出租类型
        /// </summary>
        public int LeaseType_ID { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string PublishHouse__Payment { get; set; }
    }
}
