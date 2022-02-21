using System;
using ImageMagick;

namespace ImageProcessor.Operations
{
    public class FlipVertical : IOperation
    {
        public FlipVertical()
        {
        }

        public void PerformOperation(byte[] source)
        {
            string testSource = "./inputs/niel.jpeg";

            var image = new MagickImage(testSource);
            image.Flop();

            image.Write("flopped.png");

        }
    }
}
