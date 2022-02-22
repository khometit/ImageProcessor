using System;
using ImageMagick;

namespace ImageProcessor.Operations
{
    public class FlipHorizontal : IOperation
    {
        public FlipHorizontal()
        {
        }

        public void PerformOperation(byte[] source)
        {
            //todo: now find out how to use a byte array instead

            string testSource = "./inputs/niel.jpeg";

            var image = new MagickImage(testSource);
            image.Flip();

            image.Write("flipped.png");
        }
    }
}
