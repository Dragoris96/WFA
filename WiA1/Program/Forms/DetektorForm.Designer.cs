namespace Program
{
    partial class DetektorForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.oneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Defaultpicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.savefilebutton = new System.Windows.Forms.Button();
            this.Workbutton = new System.Windows.Forms.Button();
            this.openfilebutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.RightFlipButton = new System.Windows.Forms.Button();
            this.LeftFlipButton = new System.Windows.Forms.Button();
            this.AccordPicture = new System.Windows.Forms.PictureBox();
            this.EmguPicture = new System.Windows.Forms.PictureBox();
            this.xmlbutton = new System.Windows.Forms.Button();
            this.LeftFileButton = new System.Windows.Forms.Button();
            this.RightFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchModebox = new System.Windows.Forms.ComboBox();
            this.ScalingModebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Defaultpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmguPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneToolStripMenuItem,
            this.toToolStripMenuItem,
            this.triToolStripMenuItem,
            this.fiToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem2.Text = "Фильтры";
            // 
            // oneToolStripMenuItem
            // 
            this.oneToolStripMenuItem.Name = "oneToolStripMenuItem";
            this.oneToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.oneToolStripMenuItem.Text = "Яркость/контрастность";
            this.oneToolStripMenuItem.Click += new System.EventHandler(this.oneToolStripMenuItem_Click);
            // 
            // toToolStripMenuItem
            // 
            this.toToolStripMenuItem.Name = "toToolStripMenuItem";
            this.toToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.toToolStripMenuItem.Text = "Цветовой баланс";
            this.toToolStripMenuItem.Click += new System.EventHandler(this.toToolStripMenuItem_Click);
            // 
            // triToolStripMenuItem
            // 
            this.triToolStripMenuItem.Name = "triToolStripMenuItem";
            this.triToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.triToolStripMenuItem.Text = "Повысить резкость";
            this.triToolStripMenuItem.Click += new System.EventHandler(this.threeToolStripMenuItem_Click);
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.fiToolStripMenuItem.Text = "Размыть";
            this.fiToolStripMenuItem.Click += new System.EventHandler(this.fiToolStripMenuItem_Click);
            // 
            // Defaultpicture
            // 
            this.Defaultpicture.Location = new System.Drawing.Point(12, 121);
            this.Defaultpicture.Name = "Defaultpicture";
            this.Defaultpicture.Size = new System.Drawing.Size(350, 350);
            this.Defaultpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Defaultpicture.TabIndex = 12;
            this.Defaultpicture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // savefilebutton
            // 
            this.savefilebutton.Location = new System.Drawing.Point(192, 30);
            this.savefilebutton.Name = "savefilebutton";
            this.savefilebutton.Size = new System.Drawing.Size(186, 25);
            this.savefilebutton.TabIndex = 15;
            this.savefilebutton.Text = "Сохранить как";
            this.savefilebutton.UseVisualStyleBackColor = true;
            this.savefilebutton.Click += new System.EventHandler(this.savefilebutton_Click);
            // 
            // Workbutton
            // 
            this.Workbutton.Location = new System.Drawing.Point(413, 30);
            this.Workbutton.Name = "Workbutton";
            this.Workbutton.Size = new System.Drawing.Size(562, 25);
            this.Workbutton.TabIndex = 14;
            this.Workbutton.Text = "Приступить к обнаружению";
            this.Workbutton.UseVisualStyleBackColor = true;
            this.Workbutton.Click += new System.EventHandler(this.Workbutton_Click);
            // 
            // openfilebutton
            // 
            this.openfilebutton.Location = new System.Drawing.Point(29, 30);
            this.openfilebutton.Name = "openfilebutton";
            this.openfilebutton.Size = new System.Drawing.Size(148, 25);
            this.openfilebutton.TabIndex = 13;
            this.openfilebutton.Text = "Открыть как";
            this.openfilebutton.UseVisualStyleBackColor = true;
            this.openfilebutton.Click += new System.EventHandler(this.openfilebutton_Click);
            // 
            // RightFlipButton
            // 
            this.RightFlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightFlipButton.Location = new System.Drawing.Point(60, 482);
            this.RightFlipButton.Name = "RightFlipButton";
            this.RightFlipButton.Size = new System.Drawing.Size(44, 59);
            this.RightFlipButton.TabIndex = 19;
            this.RightFlipButton.Text = "↷";
            this.RightFlipButton.UseVisualStyleBackColor = true;
            this.RightFlipButton.Click += new System.EventHandler(this.RightFlipButton_Click);
            // 
            // LeftFlipButton
            // 
            this.LeftFlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftFlipButton.Location = new System.Drawing.Point(12, 482);
            this.LeftFlipButton.Name = "LeftFlipButton";
            this.LeftFlipButton.Size = new System.Drawing.Size(42, 59);
            this.LeftFlipButton.TabIndex = 18;
            this.LeftFlipButton.Text = "↶";
            this.LeftFlipButton.UseVisualStyleBackColor = true;
            this.LeftFlipButton.Click += new System.EventHandler(this.LeftFlipButton_Click);
            // 
            // AccordPicture
            // 
            this.AccordPicture.Location = new System.Drawing.Point(724, 121);
            this.AccordPicture.Name = "AccordPicture";
            this.AccordPicture.Size = new System.Drawing.Size(350, 350);
            this.AccordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AccordPicture.TabIndex = 17;
            this.AccordPicture.TabStop = false;
            // 
            // EmguPicture
            // 
            this.EmguPicture.Location = new System.Drawing.Point(368, 121);
            this.EmguPicture.Name = "EmguPicture";
            this.EmguPicture.Size = new System.Drawing.Size(350, 350);
            this.EmguPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmguPicture.TabIndex = 16;
            this.EmguPicture.TabStop = false;
            // 
            // xmlbutton
            // 
            this.xmlbutton.Location = new System.Drawing.Point(29, 62);
            this.xmlbutton.Name = "xmlbutton";
            this.xmlbutton.Size = new System.Drawing.Size(148, 23);
            this.xmlbutton.TabIndex = 20;
            this.xmlbutton.Text = "Выбрать XML- файл";
            this.xmlbutton.UseVisualStyleBackColor = true;
            this.xmlbutton.Click += new System.EventHandler(this.xmlbutton_Click);
            // 
            // LeftFileButton
            // 
            this.LeftFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftFileButton.Location = new System.Drawing.Point(214, 80);
            this.LeftFileButton.Name = "LeftFileButton";
            this.LeftFileButton.Size = new System.Drawing.Size(36, 35);
            this.LeftFileButton.TabIndex = 21;
            this.LeftFileButton.Text = "←";
            this.LeftFileButton.UseVisualStyleBackColor = true;
            this.LeftFileButton.Click += new System.EventHandler(this.LeftFileButton_Click);
            // 
            // RightFileButton
            // 
            this.RightFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightFileButton.Location = new System.Drawing.Point(256, 80);
            this.RightFileButton.Name = "RightFileButton";
            this.RightFileButton.Size = new System.Drawing.Size(37, 34);
            this.RightFileButton.TabIndex = 22;
            this.RightFileButton.Text = "→";
            this.RightFileButton.UseVisualStyleBackColor = true;
            this.RightFileButton.Click += new System.EventHandler(this.RightFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(558, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 25;
            // 
            // SearchModebox
            // 
            this.SearchModebox.FormattingEnabled = true;
            this.SearchModebox.Items.AddRange(new object[] {
            "Будет просмотрено все изображение.",
            "Будет извлечен только один объект.",
            "Если объект уже обнаружен внутри области, он не будет проверяться дважды"});
            this.SearchModebox.Location = new System.Drawing.Point(368, 61);
            this.SearchModebox.Name = "SearchModebox";
            this.SearchModebox.Size = new System.Drawing.Size(690, 21);
            this.SearchModebox.TabIndex = 26;
            // 
            // ScalingModebox
            // 
            this.ScalingModebox.FormattingEnabled = true;
            this.ScalingModebox.Items.AddRange(new object[] {
            "Начнется с большого окна поиска и постепенно масштабируется в более мелкие.",
            "Начнется с небольших окон поиска и постепенно масштабируется в более крупные."});
            this.ScalingModebox.Location = new System.Drawing.Point(368, 93);
            this.ScalingModebox.Name = "ScalingModebox";
            this.ScalingModebox.Size = new System.Drawing.Size(690, 21);
            this.ScalingModebox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(136, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Исходное изображение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "С использованием EMGU CV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(749, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "С использованием Accord.NET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScalingModebox);
            this.Controls.Add(this.SearchModebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightFileButton);
            this.Controls.Add(this.LeftFileButton);
            this.Controls.Add(this.xmlbutton);
            this.Controls.Add(this.Defaultpicture);
            this.Controls.Add(this.savefilebutton);
            this.Controls.Add(this.Workbutton);
            this.Controls.Add(this.openfilebutton);
            this.Controls.Add(this.RightFlipButton);
            this.Controls.Add(this.LeftFlipButton);
            this.Controls.Add(this.AccordPicture);
            this.Controls.Add(this.EmguPicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Фильтрация изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Defaultpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmguPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.PictureBox Defaultpicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button savefilebutton;
        private System.Windows.Forms.Button Workbutton;
        private System.Windows.Forms.Button openfilebutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button RightFlipButton;
        private System.Windows.Forms.Button LeftFlipButton;
        private System.Windows.Forms.PictureBox AccordPicture;
        private System.Windows.Forms.PictureBox EmguPicture;
        private System.Windows.Forms.Button xmlbutton;
        private System.Windows.Forms.Button LeftFileButton;
        private System.Windows.Forms.Button RightFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SearchModebox;
        private System.Windows.Forms.ComboBox ScalingModebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

