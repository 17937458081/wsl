using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dwelling.Api.Controllers
{
    using Dwelling.IDAL;
    using Unity.Attributes;
    using Unity;
    public class HouseController : ApiController
    {
        //IHouseDAL houseDAL = null;
        //public HouseController(IHouseDAL hDAL)
        //{
        //    houseDAL = hDAL;
        //}
        [Dependency]
        public IHouseDAL houseDAL { get; set; }
        [HttpGet]
        public int Add()
        {
            return houseDAL.Add();
        }
    }
}
