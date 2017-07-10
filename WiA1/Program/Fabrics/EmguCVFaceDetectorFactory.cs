using System;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Program.Fabrics
{
    public static class  EmguCVFaceDetectorFactory
    {
        public static EmguCVFaceDetector Get(Bitmap image, string full_name_of_xml)
        {
            Image<Bgr, Byte> image1 = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> grayImage = image1.Convert<Gray, Byte>();
            Emgu.CV.HaarCascade faceCascade;
            if (full_name_of_xml == "\0")
            {
               faceCascade = new Emgu.CV.HaarCascade("haarcascade_frontalface_alt.xml");
            }
            else
            {
                faceCascade = new Emgu.CV.HaarCascade(full_name_of_xml);
            }
            return new EmguCVFaceDetector(grayImage,image1, faceCascade);
        }
    }
}
