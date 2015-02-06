using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    using EntityModels;

    public class BaseEntity
    {
        public IEnumerable<EntityModels.Manufacturer> ManufacturerList { get; set; }
        public IEnumerable<EntityModels.OperatingSystem> OperSystemList { get; set; }
        public IEnumerable<EntityModels.Camera> CameraList { get; set; }
        public IEnumerable<EntityModels.Display> DisplayList { get; set; }
        public IEnumerable<EntityModels.HardDisk> HardDiskList { get; set; }
        public IEnumerable<EntityModels.Processor> ProcessorList { get; set; }
        public IEnumerable<EntityModels.VideoCard> VideoCardList { get; set; }
        public IEnumerable<EntityModels.Power> PowerList { get; set; }
    }
}