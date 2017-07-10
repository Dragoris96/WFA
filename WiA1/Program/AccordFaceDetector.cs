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
    public class AccordFaceDetector : IDetektor
    {
        Bitmap image;

        private HaarObjectDetector _detector;
        
        public int ScallingMode1
        {
            get
            {
                switch (_detector.ScalingMode)
                {
                    case ObjectDetectorScalingMode.GreaterToSmaller: return 0; break;
                    case ObjectDetectorScalingMode.SmallerToGreater: return 1; break;
                    default: return 0;
                }

            }

            set
            {
                switch (value)
                {
                    case 0: _detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller; break;
                    case 1: _detector.ScalingMode = ObjectDetectorScalingMode.SmallerToGreater; break;
                    default: _detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller; break;
                }
               
            }
        }

        public int SearchMode1
        {
            get
            {
                switch (_detector.SearchMode)
                {
                    case ObjectDetectorSearchMode.Default: return 0; 
                    case ObjectDetectorSearchMode.Single: return 1; 
                    case ObjectDetectorSearchMode.NoOverlap: return 2;
                    default: return 0;
                }

            }

            set
            {
                switch (value)
                {
                    case 0: _detector.SearchMode = ObjectDetectorSearchMode.Default; break;
                    case 1: _detector.SearchMode = ObjectDetectorSearchMode.Single; break;
                    case 2: _detector.SearchMode = ObjectDetectorSearchMode.NoOverlap; break;
                    default: _detector.SearchMode = ObjectDetectorSearchMode.Default; break;
                }

            }
        }

        public AccordFaceDetector(Bitmap image1)
        {
            Accord.Vision.Detection.HaarCascade cascade = new FaceHaarCascade();
            _detector = new HaarObjectDetector(cascade, 30);
            image = image1;
        }
        public Bitmap Detect()
        {
            _detector.ScalingFactor = 1.5f;
            _detector.UseParallelProcessing = true;

           Rectangle[] objects = _detector.ProcessFrame(image);


            if (objects.Length > 0)
            {
                RectanglesMarker marker = new RectanglesMarker(objects, Color.Yellow);
                image = marker.Apply(image);
            }

            return image;
        }
    }
}
