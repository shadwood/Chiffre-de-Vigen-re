namespace VigenerCihperWF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenTextBox = new System.Windows.Forms.TextBox();
            this.CloseTextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LanguageButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицаВижинераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взломПоМаскеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenTextBox
            // 
            this.OpenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenTextBox.Location = new System.Drawing.Point(13, 69);
            this.OpenTextBox.Multiline = true;
            this.OpenTextBox.Name = "OpenTextBox";
            this.OpenTextBox.Size = new System.Drawing.Size(410, 350);
            this.OpenTextBox.TabIndex = 0;
            this.OpenTextBox.TextChanged += new System.EventHandler(this.OpenTextBox_Leave);
            // 
            // CloseTextBox
            // 
            this.CloseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseTextBox.Location = new System.Drawing.Point(626, 69);
            this.CloseTextBox.Multiline = true;
            this.CloseTextBox.Name = "CloseTextBox";
            this.CloseTextBox.Size = new System.Drawing.Size(410, 350);
            this.CloseTextBox.TabIndex = 1;
            this.CloseTextBox.TextChanged += new System.EventHandler(this.CloseTextBox_Leave);
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button.Location = new System.Drawing.Point(428, 230);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(192, 53);
            this.button.TabIndex = 2;
            this.button.Text = "Преобразовать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeyBox.Location = new System.Drawing.Point(428, 153);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(192, 20);
            this.KeyBox.TabIndex = 4;
            this.KeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Открытый текст";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(754, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Закрытый текст";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(428, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.Location = new System.Drawing.Point(428, 288);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(192, 53);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Очистить области";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LanguageButton
            // 
            this.LanguageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LanguageButton.Location = new System.Drawing.Point(428, 346);
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.Size = new System.Drawing.Size(192, 53);
            this.LanguageButton.TabIndex = 11;
            this.LanguageButton.Text = "Сменить язык\n Текущий язык русский";
            this.LanguageButton.UseVisualStyleBackColor = true;
            this.LanguageButton.Click += new System.EventHandler(this.LanguageButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаВижинераToolStripMenuItem,
            this.взломПоМаскеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицаВижинераToolStripMenuItem
            // 
            this.таблицаВижинераToolStripMenuItem.Name = "таблицаВижинераToolStripMenuItem";
            this.таблицаВижинераToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.таблицаВижинераToolStripMenuItem.Text = "Таблица Вижинера";
            this.таблицаВижинераToolStripMenuItem.Click += new System.EventHandler(this.таблицаВижинераToolStripMenuItem_Click);
            // 
            // взломПоМаскеToolStripMenuItem
            // 
            this.взломПоМаскеToolStripMenuItem.Name = "взломПоМаскеToolStripMenuItem";
            this.взломПоМаскеToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.взломПоМаскеToolStripMenuItem.Text = "Взлом по маске";
            this.взломПоМаскеToolStripMenuItem.Click += new System.EventHandler(this.взломПоМаскеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::VigenerCihperWF.Properties.Resources.стрелка_для_дешифратора2;
            this.pictureBox1.Location = new System.Drawing.Point(428, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.ClearButton;
            this.ClientSize = new System.Drawing.Size(1044, 431);
            this.Controls.Add(this.LanguageButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.CloseTextBox);
            this.Controls.Add(this.OpenTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpenTextBox;
        private System.Windows.Forms.TextBox CloseTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button LanguageButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицаВижинераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem взломПоМаскеToolStripMenuItem;
    }
}

