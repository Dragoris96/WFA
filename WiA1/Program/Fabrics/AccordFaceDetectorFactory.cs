using System.Drawing;

namespace Program.Fabrics
{
    public static class AccordFaceDetectorFactory
    {
       public static AccordFaceDetector Get(Bitmap image,int a,int b)
        {
            AccordFaceDetector detector = new AccordFaceDetector(image);
            detector.SearchMode1 = a;
            detector.ScallingMode1 = b;

            return detector;
        }
    }
}

