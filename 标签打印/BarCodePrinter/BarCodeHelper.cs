using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Spire.Barcode;

namespace BarCodePrinter
{
    public class BarCodeHelper
    {
        public static Image Generate(string strcontent)
        {
             BarcodeSettings settings=new BarcodeSettings();
             settings.BarHeight = 15;
             settings.Data = strcontent;
             settings.Data2D = strcontent;
             settings.Type = BarCodeType.Pdf417;
             settings.X =6;
             settings.ShowText = false;
             settings.ShowTextOnBottom = false;
             settings.ShowCheckSumChar = false;
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image barcode = generator.GenerateImage();
            return barcode;
        }
    }
}
