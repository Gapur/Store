using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Managers
{
    using EntityModels;

    public class BuildEntity
    {
        #region ConvertFromEntityModelsToModels

        public Models.Product NewProductEntity(Product product)
        {
            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Date = product.DateOfCreate,
                Color = product.Color,
                RAM = (product.Device.RAM == null ? 0 : (int)product.Device.RAM),
                OperatingSystem = product.Device.refOperatingSystem == null ? null : product.Device.OperatingSystem.Name,
                WiFi = (product.Device.WiFi == null ? false : (bool)product.Device.WiFi),
                Manufacturers = NewManufacturerEntity(product.Device.Manufacturer),
                Bluetooth = (product.Device.Bluetooth == null ? false : (bool)product.Device.Bluetooth),
                BuildMemory = (product.Device.BuildMemory == null ? String.Empty : product.Device.BuildMemory),
                Processor = product.Device.refProcessor == null ? null : NewProcessorEntity(product.Device.Processor),
                Images = NewImageEntity(product.Device.Images.FirstOrDefault(img => img.refDevice == product.Id)),
                Power = product.Device.refPower == null ? null : NewPowerEntity(product.Device.Power),
                VideoCard = product.Device.refVideoCard == null ? null : NewVideoCard(product.Device.VideoCard),
                HardDisk = product.Device.refHardDisk == null ? null : NewHardDisk(product.Device.HardDisk),
                Display = product.Device.refDisplay == null ? null : NewDisplayEntity(product.Device.Display),
                Camera = product.Device.refCamera == null ? null : NewCameraEntity(product.Device.Camera),
                TypeProduct = product.Device.DicProdType.Id
            };
        }

        public Models.HardDisk NewHardDisk(HardDisk hardDisk)
        {
            return new Models.HardDisk
            {
                Id = hardDisk.Id,
                HDD = hardDisk.HDD,
                SSD = hardDisk.SSD
            };
        }

        public Models.Display NewDisplayEntity(Display display)
        {
            return new Models.Display
            {
                Id = display.Id,
                FormatScreen = display.FormatScreen,
                ScreenResolution = display.ScreenResolution,
                Width = display.Width,
                Height = display.Height
            };
        }

        public Models.Camera NewCameraEntity(Camera camera)
        {
            return new Models.Camera
            {
                Id = camera.Id,
                MaxResolution = camera.MaxResolution,
                ResolutionMatrix = camera.ResolutionMatrix
            };
        }

        public Models.Image NewImageEntity(Image image)
        {
            return new Models.Image
            {
                Id = image.Id,
                Url = image.Url,
                refDevice = image.refDevice
            };
        }

        public Models.Manufacturer NewManufacturerEntity(Manufacturer manufacturer)
        {
            return new Models.Manufacturer
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                Country = manufacturer.Country
            };
        }

        public Models.Processor NewProcessorEntity(Processor processor)
        {
            return new Models.Processor
            {
                Id = processor.Id,
                Type = processor.Type,
                ClockSpeed = processor.ClockSpeed,
                CountCore = processor.CountCore
            };
        }

        public Models.Power NewPowerEntity(Power power)
        {
            return new Models.Power
            {
                Id = power.Id,
                BatteryType = power.BatteryType,
                BatteryWork = power.BatteryWork,
                ChargeTime = power.ChargeTime
            };
        }

        public Models.VideoCard NewVideoCard(VideoCard videoCard)
        {
            return new Models.VideoCard
            {
                Id = videoCard.Id,
                Name = videoCard.Name,
                Memory = videoCard.Memory,
                GraphicsController = videoCard.GraphicsController
            };
        }

        #endregion ConvertFromEntityModelsToModels

        #region ConvertFromModelsToEntityModels

        public EntityModels.Device EntityModelsDevice(Models.Product product, System.Guid ID)
        {
            return new EntityModels.Device
            {
                Id = ID,
                Bluetooth = product.Bluetooth,
                refCamera = product.Camera.Id,
                refDicProdType = product.TypeProduct,
                refDisplay = product.Display.Id,
                refHardDisk = product.HardDisk.Id,
                refManufacturer = product.Manufacturers.Id,
                refOperatingSystem = int.Parse(product.OperatingSystem),
                refProcessor = product.Processor.Id,
                BuildMemory = product.BuildMemory,
                refVideoCard = product.VideoCard.Id,
                RAM = product.RAM,
                WiFi = product.WiFi
            };
        }

        public EntityModels.Product EntityModelsProduct(Models.Product product, System.Guid ID)
        {
            return new Product
            {
                Id = ID,
                Name = product.Name,
                Price = product.Price,
                Color = product.Color,
                DateOfCreate = product.Date,
            };
        }

        #endregion ConvertFromModelsToEntityModels

        private enum DictionaryProductType
        {
            Phone = 1,
            Notebook,
            TV
        }
    }
}