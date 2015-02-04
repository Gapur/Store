using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Managers
{
    using EntityModels;

    public class BuildEntity
    {
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
                Images = (IEnumerable<Models.Image>)product.Device.Images.Select(img => NewImageEntity(img)),
                Power = product.Device.refPower == null ? null : NewPowerEntity(product.Device.Power),
                VideoCard = product.Device.refVideoCard == null ? null : NewVideoCard(product.Device.VideoCard),
                HadrDisk = product.Device.refHardDisk == null ? null : NewHardDisk(product.Device.HardDisk),
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

        private enum DictionaryProductType
        {
            Phone = 1,
            Notebook,
            TV
        }
    }
}