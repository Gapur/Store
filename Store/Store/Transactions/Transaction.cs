using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Transactions;

namespace Store.Transactions
{
    using EntityModels;
    using Managers;

    public class Transaction
    {

        public Models.BaseEntity GetManufacturer()
        {
            Entities context = new Entities();
            try
            {
                Models.BaseEntity entities = new Models.BaseEntity();
                entities.ManufacturerList = context.Manufacturers.Select(m => m);
                entities.CameraList = context.Cameras.Select(camera => camera);
                entities.HardDiskList = context.HardDisks.Select(disk => disk);
                entities.ProcessorList = context.Processors.Select(pro => pro);
                entities.OperSystemList = context.OperatingSystems.Select(sys => sys);
                entities.VideoCardList = context.VideoCards.Select(videoCard => videoCard);
                entities.DisplayList = context.Displays.Select(dis => dis);
                entities.PowerList = context.Powers.Select(power => power);

                return entities;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                //context.Dispose();
            }
            return null;
        }
    }
}