namespace PasswordGenerator
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.chkBoxUpper = new System.Windows.Forms.CheckBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.chkBoxNumber = new System.Windows.Forms.CheckBox();
            this.chkBoxSym = new System.Windows.Forms.CheckBox();
            this.groupBoxSym = new System.Windows.Forms.GroupBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.labelCount = new System.Windows.Forms.Label();
            this.chkBoxLower = new System.Windows.Forms.CheckBox();
            this.counter = new System.Windows.Forms.NumericUpDown();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.comboBoxLength = new System.Windows.Forms.ComboBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.radioButtonLetters = new System.Windows.Forms.RadioButton();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelGen = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSort = new System.Windows.Forms.Button();
            this.btntoFile = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.groupBoxSym.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counter)).BeginInit();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxUpper
            // 
            this.chkBoxUpper.AutoSize = true;
            this.chkBoxUpper.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBoxUpper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBoxUpper.Location = new System.Drawing.Point(9, 54);
            this.chkBoxUpper.Name = "chkBoxUpper";
            this.chkBoxUpper.Size = new System.Drawing.Size(189, 23);
            this.chkBoxUpper.TabIndex = 1;
            this.chkBoxUpper.Text = "Upper Case Letters";
            this.chkBoxUpper.UseVisualStyleBackColor = true;
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.Color.White;
            this.textBoxRes.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes.Location = new System.Drawing.Point(9, 53);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(223, 250);
            this.textBoxRes.TabIndex = 2;
            // 
            // chkBoxNumber
            // 
            this.chkBoxNumber.AutoSize = true;
            this.chkBoxNumber.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBoxNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBoxNumber.Location = new System.Drawing.Point(9, 79);
            this.chkBoxNumber.Name = "chkBoxNumber";
            this.chkBoxNumber.Size = new System.Drawing.Size(142, 23);
            this.chkBoxNumber.TabIndex = 3;
            this.chkBoxNumber.Text = "Numbers (0-9)";
            this.chkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // chkBoxSym
            // 
            this.chkBoxSym.AutoSize = true;
            this.chkBoxSym.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBoxSym.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBoxSym.Location = new System.Drawing.Point(9, 104);
            this.chkBoxSym.Name = "chkBoxSym";
            this.chkBoxSym.Size = new System.Drawing.Size(162, 23);
            this.chkBoxSym.TabIndex = 5;
            this.chkBoxSym.Text = "Special symbols";
            this.chkBoxSym.UseVisualStyleBackColor = true;
            // 
            // groupBoxSym
            // 
            this.groupBoxSym.Controls.Add(this.radioButtonCustom);
            this.groupBoxSym.Controls.Add(this.labelCount);
            this.groupBoxSym.Controls.Add(this.chkBoxUpper);
            this.groupBoxSym.Controls.Add(this.chkBoxLower);
            this.groupBoxSym.Controls.Add(this.counter);
            this.groupBoxSym.Controls.Add(this.radioButtonAll);
            this.groupBoxSym.Controls.Add(this.chkBoxNumber);
            this.groupBoxSym.Controls.Add(this.chkBoxSym);
            this.groupBoxSym.Controls.Add(this.comboBoxLength);
            this.groupBoxSym.Controls.Add(this.labelLength);
            this.groupBoxSym.Controls.Add(this.radioButtonLetters);
            this.groupBoxSym.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSym.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSym.Location = new System.Drawing.Point(10, 319);
            this.groupBoxSym.Name = "groupBoxSym";
            this.groupBoxSym.Size = new System.Drawing.Size(571, 219);
            this.groupBoxSym.TabIndex = 7;
            this.groupBoxSym.TabStop = false;
            this.groupBoxSym.Text = "Password parameters";
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonCustom.Location = new System.Drawing.Point(351, 79);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(90, 23);
            this.radioButtonCustom.TabIndex = 17;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioButtonCustom_CheckedChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCount.Location = new System.Drawing.Point(147, 142);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(231, 23);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "Number of passwords ";
            // 
            // chkBoxLower
            // 
            this.chkBoxLower.AutoSize = true;
            this.chkBoxLower.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBoxLower.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBoxLower.Location = new System.Drawing.Point(9, 29);
            this.chkBoxLower.Name = "chkBoxLower";
            this.chkBoxLower.Size = new System.Drawing.Size(190, 23);
            this.chkBoxLower.TabIndex = 9;
            this.chkBoxLower.Text = "Lower Case Letters";
            this.chkBoxLower.UseVisualStyleBackColor = true;
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.Color.White;
            this.counter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.counter.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(151, 168);
            this.counter.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.counter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            this.counter.Size = new System.Drawing.Size(121, 26);
            this.counter.TabIndex = 13;
            this.counter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonAll.Location = new System.Drawing.Point(351, 54);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(145, 23);
            this.radioButtonAll.TabIndex = 16;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All characters";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // comboBoxLength
            // 
            this.comboBoxLength.BackColor = System.Drawing.Color.White;
            this.comboBoxLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLength.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLength.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxLength.FormattingEnabled = true;
            this.comboBoxLength.Items.AddRange(new object[] {
            "6 ",
            "7 ",
            "8 ",
            "9 ",
            "10",
            "11",
            "12",
            "13",
            "14 ",
            "15 ",
            "16"});
            this.comboBoxLength.Location = new System.Drawing.Point(9, 168);
            this.comboBoxLength.Name = "comboBoxLength";
            this.comboBoxLength.Size = new System.Drawing.Size(78, 28);
            this.comboBoxLength.TabIndex = 9;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLength.Location = new System.Drawing.Point(6, 142);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(81, 23);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "Length";
            // 
            // radioButtonLetters
            // 
            this.radioButtonLetters.AutoSize = true;
            this.radioButtonLetters.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonLetters.Location = new System.Drawing.Point(351, 29);
            this.radioButtonLetters.Name = "radioButtonLetters";
            this.radioButtonLetters.Size = new System.Drawing.Size(126, 23);
            this.radioButtonLetters.TabIndex = 15;
            this.radioButtonLetters.TabStop = true;
            this.radioButtonLetters.Text = "Only letters";
            this.radioButtonLetters.UseVisualStyleBackColor = true;
            this.radioButtonLetters.CheckedChanged += new System.EventHandler(this.radioButtonLetters_CheckedChanged);
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(587, 24);
            this.menuStripMenu.TabIndex = 8;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AboutToolStripMenuItem.Image = global::PasswordGenerator.Properties.Resources.about;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGen.Location = new System.Drawing.Point(5, 28);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(227, 23);
            this.labelGen.TabIndex = 12;
            this.labelGen.Text = "Generated passwords";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Image = global::PasswordGenerator.Properties.Resources.sort;
            this.btnSort.Location = new System.Drawing.Point(507, 156);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(76, 44);
            this.btnSort.TabIndex = 20;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            this.btnSort.MouseHover += new System.EventHandler(this.btnSort_MouseHover);
            // 
            // btntoFile
            // 
            this.btntoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btntoFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntoFile.FlatAppearance.BorderSize = 0;
            this.btntoFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btntoFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoFile.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntoFile.Image = global::PasswordGenerator.Properties.Resources.toFile;
            this.btntoFile.Location = new System.Drawing.Point(439, 156);
            this.btntoFile.Name = "btntoFile";
            this.btntoFile.Size = new System.Drawing.Size(76, 44);
            this.btntoFile.TabIndex = 17;
            this.btntoFile.UseVisualStyleBackColor = false;
            this.btntoFile.Click += new System.EventHandler(this.btntoFile_Click);
            this.btntoFile.MouseHover += new System.EventHandler(this.btntoFile_MouseHover);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Image = global::PasswordGenerator.Properties.Resources.clean;
            this.btnClean.Location = new System.Drawing.Point(371, 156);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(72, 42);
            this.btnClean.TabIndex = 16;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            this.btnClean.MouseHover += new System.EventHandler(this.btnClean_MouseHover);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Image = global::PasswordGenerator.Properties.Resources.copy;
            this.btnCopy.Location = new System.Drawing.Point(303, 156);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(72, 42);
            this.btnCopy.TabIndex = 14;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseHover += new System.EventHandler(this.btnCopy_MouseHover);
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRes.FlatAppearance.BorderSize = 0;
            this.btnRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRes.Image = global::PasswordGenerator.Properties.Resources.arrow;
            this.btnRes.Location = new System.Drawing.Point(235, 156);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(72, 42);
            this.btnRes.TabIndex = 0;
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            this.btnRes.MouseHover += new System.EventHandler(this.btnRes_MouseHover);
            // 
            // MainApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(587, 545);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btntoFile);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.groupBoxSym);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.menuStripMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMenu;
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.groupBoxSym.ResumeLayout(false);
            this.groupBoxSym.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counter)).EndInit();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.CheckBox chkBoxUpper;
        private System.Windows.Forms.CheckBox chkBoxNumber;
        private System.Windows.Forms.CheckBox chkBoxSym;
        private System.Windows.Forms.GroupBox groupBoxSym;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkBoxLower;
        private System.Windows.Forms.ComboBox comboBoxLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button btnClean;
        public System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.NumericUpDown counter;
        private System.Windows.Forms.Button btntoFile;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonLetters;
        private System.Windows.Forms.Button btnSort;
    }
}

