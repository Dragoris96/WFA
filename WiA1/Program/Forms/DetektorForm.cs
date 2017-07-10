using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    public partial class DetektorForm : Form
    {
        public static Bitmap image;

        public DetektorForm()
        {
            InitializeComponent();
            LeftFlipButton.Visible = false;
            RightFlipButton.Visible = false;
        }
        public static string full_name_of_image = "\0";
        string[] full_name_of_img = new string[100];
        int count = 0,cont=0;
        public static string full_name_of_xml = "\0";
        public static UInt32[,] pixel;

        //яркость контрастность
        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrightForm BrightnessForm = new BrightForm(this);
            BrightnessForm.ShowDialog(); //just 'Show' for the control Form1
        }

        //цветовой Баланс
        private void toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorBalanceSettingsForm ColorBalanceForm = new ColorBalanceSettingsForm(this);
            ColorBalanceForm.ShowDialog();
        }

        //Повышение резкости
        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N1, Filter.sharpness);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        //размыть
        private void fiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N2, Filter.blur);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        //преобразование из UINT32 to Bitmap
        public static void FromPixelToBitmap()
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
        }

        //преобразование из UINT32 to Bitmap по одному пикселю
        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            image.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            Defaultpicture.Image = image;
        }

        private void openfilebutton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    full_name_of_img[count] = open_dialog.FileName;
                    count++;
                    cont++;
                    image = new Bitmap(full_name_of_img[count-1]);
                    Defaultpicture.Image = image;
                    Defaultpicture.SizeMode = PictureBoxSizeMode.Zoom;
                    Defaultpicture.Invalidate();
                    LeftFlipButton.Visible = true;
                    RightFlipButton.Visible = true;
                    //получение матрицы с пикселями
                    pixel = new UInt32[image.Height, image.Width];
                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                            pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());

                    label1.Text = Convert.ToString(count) + "/" + Convert.ToString(cont);
                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void savefilebutton_Click(object sender, EventArgs e)
        {

            if (EmguPicture.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Workbutton_Click(object sender, EventArgs e)
        {
            IDetektor CV1 = Fabrics.EmguCVFaceDetectorFactory.Get(image, full_name_of_xml);
            image = CV1.Detect();
            EmguPicture.Image = image;
            EmguPicture.SizeMode = PictureBoxSizeMode.Zoom;
            EmguPicture.Invalidate();

            int a=0,b=0;
            if (SearchModebox.SelectedItem == null) a = 0;
            else
            if (SearchModebox.SelectedItem.ToString() == "Будет просмотрено все изображение.") a = 0;
            else
                if (SearchModebox.SelectedItem.ToString() == "Будет извлечен только один объект.") a = 1;
                else
                    if (SearchModebox.SelectedItem.ToString() == "Если объект уже обнаружен внутри области, он не будет проверяться дважды") a = 2;
                    else
                        if (SearchModebox.SelectedItem.ToString() == "Если несколько объектов расположены внутри друг друга, они будут усреднены.") a = 3; else a = 0;

            if (ScalingModebox.SelectedItem == null) b = 0;
            else
            if (ScalingModebox.SelectedItem.ToString() == "Начнется с большого окна поиска и постепенно масштабируется в более мелкие.") b = 0;
            else
                if (ScalingModebox.SelectedItem.ToString() == "Начнется с небольших окон поиска и постепенно масштабируется в более крупные.") b = 1; else b = 0;

            IDetektor CV2 = Fabrics.AccordFaceDetectorFactory.Get(image,a,b);
            AccordPicture.Image= CV2.Detect();
            AccordPicture.SizeMode = PictureBoxSizeMode.Zoom;
            AccordPicture.Invalidate();
        }

        private void LeftFlipButton_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Defaultpicture.Image = image;
            Defaultpicture.SizeMode = PictureBoxSizeMode.Zoom;
            Defaultpicture.Invalidate();
            
        }

        private void RightFlipButton_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Defaultpicture.Image = image;
            Defaultpicture.SizeMode = PictureBoxSizeMode.Zoom;
            Defaultpicture.Invalidate();
        }

        private void xmlbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "XML Files|*.xml;*.XML;|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_xml = open_dialog.FileName;
                }
                catch
                {
                    full_name_of_xml = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LeftFileButton_Click(object sender, EventArgs e)
        {

            if (count > 1)
            {
                count--;
                image = new Bitmap(full_name_of_img[count-1]);
                Defaultpicture.Image = image;
                Defaultpicture.SizeMode = PictureBoxSizeMode.Zoom;
                Defaultpicture.Invalidate();
            }
            label1.Text = Convert.ToString(count) + "/" + Convert.ToString(cont);
        }

        private void RightFileButton_Click(object sender, EventArgs e)
        {
            if (count < cont)
            {
                count++;
                image = new Bitmap(full_name_of_img[count-1]);
                Defaultpicture.Image = image;
                Defaultpicture.SizeMode = PictureBoxSizeMode.Zoom;
                Defaultpicture.Invalidate();
            }
            label1.Text = Convert.ToString(count) + "/" + Convert.ToString(cont);
        }


    }
}
