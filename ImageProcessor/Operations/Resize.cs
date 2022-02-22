using System;
using ImageMagick;

namespace ImageProcessor.Operations
{
    public class Resize : IOperation
    {
        public Resize()
        {
        }

        public void PerformOperation(byte[] source)
        {
            //TODO: resize per ratio

            var testSource = "/Users/averydinh/Projects/ImageProcessor/ImageProcessor/inputs/niel.jpeg";
            //throw new NotImplementedException();
            var image = new MagickImage(testSource);

            var size = new MagickGeometry(100, 100);
            // This will resize the image to a fixed size without maintaining the aspect ratio.
            // Normally an image will be resized to fit inside the specified size.
            size.IgnoreAspectRatio = true;

            //image.Resize(size);

            // Save the result
            //image.Write("test.png");

            //var data = LoadImageBytes();
            //using (var image = new MagickImage(data))
            //{
            //}
            image.Rotate(90);
            image.Write("rotateRight.png");

            image.Rotate(-90);
            image.Write("rotateLeft.png");
        }
    }
}
