using BicycleStore.Model.Enums;
using FileStore;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Media.Imaging;
namespace BicycleStore.Model
{
    public class Bicycle
    {
        public string Brand { get; set; }

        private string model;

        private ImagePathHelper helper = new ImagePathHelper();

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
                this.Image = helper.GetImageByModel(value);
            }
        }

        public BitmapImage Image { get; private set; }

        public decimal Price { get; set; }

        public Country OriginCountry { get; set; }

        public FrameSize BicycleFrameSize { get; set; }

        public int Year { get; set; }

        public Bicycle(string brand, string model, decimal price, Country originCountry, FrameSize size, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
            this.OriginCountry = originCountry;
            this.BicycleFrameSize = size;
            this.Year = year;
            this.Image = this.helper.GetImageByModel(model);
        }
    }

}
