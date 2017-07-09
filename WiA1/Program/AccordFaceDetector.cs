using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using Accord.Imaging.Filters;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;

using System.Diagnostics;

namespace Program
{
    class AccordFaceDetector : Detektor
    {
        Bitmap image;
        int SearchMode;
        int ScalingMode;

        public AccordFaceDetector()
        {

        }
        public AccordFaceDetector(Bitmap image1, int SearchMode1, int ScalingMode1)
        {
            image = image1;
            SearchMode = SearchMode1;
            ScalingMode = ScalingMode1;
        }
        public override Bitmap SRt(string ol)
        {
            HaarObjectDetector detector;
            Accord.Vision.Detection.HaarCascade cascade = new FaceHaarCascade();
            detector = new HaarObjectDetector(cascade, 30);

            if (SearchMode == 0) detector.SearchMode = ObjectDetectorSearchMode.Default;
            if (SearchMode == 1) detector.SearchMode = ObjectDetectorSearchMode.Single;
            if (SearchMode == 2) detector.SearchMode = ObjectDetectorSearchMode.NoOverlap;

            if (ScalingMode == 0) detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller;
            if (ScalingMode == 1) detector.ScalingMode = ObjectDetectorScalingMode.SmallerToGreater;

            detector.ScalingFactor = 1.5f;
            detector.UseParallelProcessing = true;


            // Process frame to detect objects
            Rectangle[] objects = detector.ProcessFrame(image);


            if (objects.Length > 0)
            {
                RectanglesMarker marker = new RectanglesMarker(objects, Color.Black);
                image = marker.Apply(image);
            }

            return image;
        }
    }
}
