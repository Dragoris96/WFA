using System;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Program
{
    public class EmguCVFaceDetector:IDetektor
    {
        Image<Gray, Byte> grayimage;
        Image<Bgr, Byte> image;
        Emgu.CV.HaarCascade faceCascade;

        public EmguCVFaceDetector(Image<Gray, Byte> grayimage1,Image<Bgr, Byte> image1,Emgu.CV.HaarCascade faceCascade1)
        {
            grayimage = grayimage1;
            image = image1;
            faceCascade=faceCascade1;
        }
        public Bitmap Detect()
        {
                var Face = grayimage.DetectHaarCascade(faceCascade)[0];
                foreach (var face in Face)
                {
                    //Если таковы найдены, то рисуем вокруг них круг, с заданным цветом и толщиной линии.
                    image.Draw(face.rect, new Bgr(0, 255, 0), 5);
                }
             return image.ToBitmap();
        }

    }
}
