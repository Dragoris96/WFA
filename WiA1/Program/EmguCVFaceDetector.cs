using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace Program
{
    class EmguCVFaceDetector : Detektor
    {
        Image<Bgr, Byte> image1;
        private Bitmap image;

        public EmguCVFaceDetector()
        {
        }
        public EmguCVFaceDetector(Bitmap image)
        {
            image1 = new Image<Bgr, Byte>(image);
        }

        public override Bitmap SRt(string b)
        {
            Image<Gray, Byte> grayImage = image1.Convert<Gray, Byte>();

            //for face
            if (b == "\0")
            {
                Emgu.CV.HaarCascade faceCascade = new Emgu.CV.HaarCascade("haarcascade_frontalface_alt.xml");
                var Face = grayImage.DetectHaarCascade(faceCascade)[0];
                foreach (var face in Face)
                {
                    //Если таковы найдены, то рисуем вокруг них круг, с заданным цветом и толщиной линии.
                    image1.Draw(face.rect, new Bgr(0, 0, 0), 5);
                }
            }
            else
            {
                Emgu.CV.HaarCascade faceCascade = new Emgu.CV.HaarCascade(b);
                var Face = grayImage.DetectHaarCascade(faceCascade)[0];
                foreach (var face in Face)
                {
                    //Если таковы найдены, то рисуем вокруг них круг, с заданным цветом и толщиной линии.
                    image1.Draw(face.rect, new Bgr(0, 0, 0), 5);
                }
            }
            return image1.ToBitmap();
        }

    }
}
