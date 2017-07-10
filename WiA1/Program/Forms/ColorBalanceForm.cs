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
    public partial class ColorBalanceSettingsForm : Form
    {
        DetektorForm OwnerForm;
        public ColorBalanceSettingsForm(DetektorForm ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
        }

        //цветовой баланс R
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                UInt32 p;
                for (int i = 0; i < DetektorForm.image.Height; i++)
                    for (int j = 0; j < DetektorForm.image.Width; j++)
                    {
                        p = ColorBalance.ColorBalance_R(DetektorForm.pixel[i, j], trackBar1.Value, trackBar1.Maximum);
                        DetektorForm.FromOnePixelToBitmap(i, j, p);
                    }

                FromBitmapToScreen();
            }
        }

        //цветовой баланс G
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                UInt32 p;
                for (int i = 0; i < DetektorForm.image.Height; i++)
                    for (int j = 0; j < DetektorForm.image.Width; j++)
                    {
                        p = ColorBalance.ColorBalance_G(DetektorForm.pixel[i, j], trackBar2.Value, trackBar2.Maximum);
                        DetektorForm.FromOnePixelToBitmap(i, j, p);
                    }

                FromBitmapToScreen();
            }
        }

        //цветовой баланс B
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                UInt32 p;
                for (int i = 0; i < DetektorForm.image.Height; i++)
                    for (int j = 0; j < DetektorForm.image.Width; j++)
                    {
                        p = ColorBalance.ColorBalance_B(DetektorForm.pixel[i, j], trackBar3.Value, trackBar3.Maximum);
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
                trackBar3.Value = 0;
            }
        }

        //вывод изображения на экран
        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

        //обновление изображения в Bitmap и pictureBox при закрытии окна

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DetektorForm.full_name_of_image != "\0")
            {
                DetektorForm.FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

    }
}
