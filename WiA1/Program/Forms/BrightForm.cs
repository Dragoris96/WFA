using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class BrightForm : Form
    {
        DetektorForm OwnerForm;
        public BrightForm(DetektorForm ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
        }

        //изменение яркости
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                UInt32 p;
                for (int i = 0; i < DetektorForm.image.Height; i++)
                    for (int j = 0; j < DetektorForm.image.Width; j++)
                    {
                        p = BrightnessContrast.Brightness(DetektorForm.pixel[i, j], trackBar1.Value, trackBar1.Maximum);
                        DetektorForm.FromOnePixelToBitmap(i, j, p);
                    }

                FromBitmapToScreen();
            }
        }

        //изменение контрастности
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                UInt32 p;
                for (int i = 0; i < DetektorForm.image.Height; i++)
                    for (int j = 0; j < DetektorForm.image.Width; j++)
                    {
                        p = BrightnessContrast.Contrast(DetektorForm.pixel[i, j], trackBar2.Value, trackBar2.Maximum);
                        DetektorForm.FromOnePixelToBitmap(i, j, p);
                    }

                FromBitmapToScreen();
            }
        }

        //сохранение изменений яркости или контрастности
        private void button_Click(object sender, EventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                for (int i = 0; i < DetektorForm.image.Height; i++)
                    for (int j = 0; j < DetektorForm.image.Width; j++)
                        DetektorForm.pixel[i, j] = (UInt32)(DetektorForm.image.GetPixel(j, i).ToArgb());
                trackBar1.Value = 0;
                trackBar2.Value = 0;
            }
        }

        //вывод изображения на экран
        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

        //обновление изображения в Bitmap и pictureBox при закрытии окна
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                DetektorForm.FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

    }
}
