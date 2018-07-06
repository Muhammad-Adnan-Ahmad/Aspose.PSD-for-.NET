﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.PSD.Examples.Aspose.Conversion;
using Aspose.PSD.Examples.Aspose.DrawingAndFormattingImages;
using Aspose.PSD.Examples.Licensing;

namespace Aspose.PSD.Examples
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");


            // Uncomment the one you want to try out


            //Metered Licensing
            //MeteredLicensing.Run();
            String licPath = GetDataDir_PSD() + @"Aspose.PSD.NET.lic";
            //License lic = new License();
            //lic.SetLicense(licPath);
            //bool isLicensd = lic.IsLicensed;

            //// =====================================================
            //// =====================================================
            ////            Conversion to Rasters Images
            //// =====================================================
            //// =====================================================

            //PSDToRasterImageFormats.Run();
            //CroppingPSDWhenConvertingToPNG.Run();
            //ApplyMedianAndWienerFilters.Run();
            //ApplyGausWienerFilters.Run();
            //ApplyGausWienerFiltersForColorImage.Run();
            //ApplyMotionWienerFilters.Run();
            //BinarizationWithFixedThreshold.Run();
            //BinarizationWithOtsuThreshold.Run();
            //Garysacling.Run();
            //GIFImageLayersToTIFF.Run();
            //CMYKPSDtoCMYKTiff.Run();
            //SettingforReplacingMissingFonts.Run();
            //SavingtoDisk.Run();
            //SavingtoStream.Run();
            //ExportImagesinMultiThreadEnv.Run();


            //// =====================================================
            //// =====================================================
            ////            Drawing and Formatting Images
            //// =====================================================
            //// =====================================================
            //CombiningImages.Run();
            //ExpandandCropImages.Run();
            //CreateXMPMetadata.Run();
            //CreatingbySettingPath.Run();



            //This one failed
           // CreatingUsingStream.Run();


            //CroppingbyShifts.Run();
            //CroppingbyRectangle.Run();
            //RotatinganImage.Run();
            //RotatinganImageonaSpecificAngle.Run();
            //SimpleResizing.Run();
            //ResizingwithResizeTypeEnumeration.Run();
            //ResizeImageProportionally.Run();
            //DitheringforRasterImages.Run();
            //AdjustingBrightness.Run();
            //AdjustingContrast.Run();
            //AdjustingGamma.Run();
            //BluranImage.Run();
            //VerifyImageTransparency.Run();
            //ImplementLossyGIFCompressor.Run();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static String GetDataDir_Export(string path)
        {
            return System.IO.Path.GetFullPath(GetDataDir_Data() + "Export/" + path + "/");
        }

        public static String GetDataDir_Files()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Files/");
        }

        public static String GetDataDir_Images(string path)
        {
            return Path.GetFullPath(GetDataDir_Data() + "Images/" + path + "/");
        }

        public static String GetDataDir_PNG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "PNG/");
        }

        public static String GetDataDir_DrawingAndFormattingImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DrawingAndFormattingImages/");
        }

        public static String GetDataDir_DICOM()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DICOM/");
        }

        public static String GetDataDir_JPEG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "JPEG/");
        }

        public static String GetDataDir_ModifyingAndConvertingImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ModifyingAndConvertingImages/");
        }

        public static String GetDataDir_Cache()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Cache/");
        }

        public static String GetDataDir_MetaFiles()
        {
            return Path.GetFullPath(GetDataDir_Data() + "MetaFiles/");
        }

        public static String GetDataDir_PSD()
        {
            return Path.GetFullPath(GetDataDir_Data() + "PSD/");
        }

        public static String GetDataDir_WebPImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "WebPImage/");
        }

        public static String GetDataDir_DjVu()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DjVu/");
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return System.IO.Path.Combine(startDirectory, "Data\\");
        }
    }
}