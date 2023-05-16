using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Common.Application;

public static class ImageConvertor
{
    public static void CreateBitMap(string inputImagePath, string outputPath, int newWidth, int new_height)
    {
        var inputDirectory = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{inputImagePath.Replace("/", "\\")}");
        var pathSplit = inputImagePath.Split('/');
        var imageName = pathSplit[^1];
        var folderName = Path.Combine(Directory.GetCurrentDirectory(), outputPath.Replace("/", "\\"));
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        var outputDirectory = Path.Combine(folderName, imageName);
        Image_resize(inputDirectory, outputDirectory, newWidth, new_height);
    }

    private static void Image_resize(string input_Image_Path, string output_Image_Path, int new_Width, int new_Height)
    {
        const long quality = 50L;
        var source_Bitmap = new Bitmap(input_Image_Path);
        double dblWidth_origial = source_Bitmap.Width;
        double dblHeigth_origial = source_Bitmap.Height;
        var relation_heigth_width = dblHeigth_origial / dblWidth_origial;
        var new_DrawArea = new Bitmap(new_Width, new_Height);

        using (var graphic_of_DrawArea = Graphics.FromImage(new_DrawArea))
        {
            graphic_of_DrawArea.CompositingQuality = CompositingQuality.HighSpeed;
            graphic_of_DrawArea.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic_of_DrawArea.CompositingMode = CompositingMode.SourceCopy;
            graphic_of_DrawArea.DrawImage(source_Bitmap, 0, 0, new_Width, new_Height);

            using (var output = System.IO.File.Open(output_Image_Path, FileMode.Create))
            {
                var qualityParamId = System.Drawing.Imaging.Encoder.Quality;
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(qualityParamId, quality);
                var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
                new_DrawArea.Save(output, codec, encoderParameters);
                output.Close();
            }

            graphic_of_DrawArea.Dispose();
        }

        source_Bitmap.Dispose();
    }

    public static void CompressImage(string imagePath, string destPath, long quality)
    {
        using (var bmp1 = new Bitmap(imagePath))
        {
            var jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            var qualityEncoder = Encoder.Quality;
            var myEncoderParameters = new EncoderParameters(1);
            var myEncoderParameter = new EncoderParameter(qualityEncoder, quality);

            myEncoderParameters.Param[0] = myEncoderParameter;
            bmp1.Save(destPath, jpgEncoder, myEncoderParameters);
        }
    }

    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        var codecs = ImageCodecInfo.GetImageDecoders();
        foreach (var codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}