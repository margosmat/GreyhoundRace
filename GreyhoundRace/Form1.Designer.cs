namespace GreyhoundRace
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.houndNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.arekBetLabel = new System.Windows.Forms.Label();
            this.bartekBetLabel = new System.Windows.Forms.Label();
            this.janekBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.arekRadioButton = new System.Windows.Forms.RadioButton();
            this.bartekRadioButton = new System.Windows.Forms.RadioButton();
            this.janekRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houndNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.InitialImage = ((System.Drawing.Image)(resources.GetObject("raceTrack.InitialImage")));
            this.raceTrack.Location = new System.Drawing.Point(13, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(600, 200);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.houndNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betAmount);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.arekBetLabel);
            this.groupBox1.Controls.Add(this.bartekBetLabel);
            this.groupBox1.Controls.Add(this.janekBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.arekRadioButton);
            this.groupBox1.Controls.Add(this.bartekRadioButton);
            this.groupBox1.Controls.Add(this.janekRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(439, 46);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(124, 90);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "START!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // houndNumeric
            // 
            this.houndNumeric.Location = new System.Drawing.Point(307, 121);
            this.houndNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.houndNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.houndNumeric.Name = "houndNumeric";
            this.houndNumeric.Size = new System.Drawing.Size(28, 20);
            this.houndNumeric.TabIndex = 12;
            this.houndNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "zł na charta nr";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(178, 121);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(38, 20);
            this.betAmount.TabIndex = 10;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.AutoSize = true;
            this.betButton.Location = new System.Drawing.Point(83, 118);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "stawia";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name";
            // 
            // arekBetLabel
            // 
            this.arekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arekBetLabel.Location = new System.Drawing.Point(209, 89);
            this.arekBetLabel.Name = "arekBetLabel";
            this.arekBetLabel.Size = new System.Drawing.Size(180, 17);
            this.arekBetLabel.TabIndex = 7;
            this.arekBetLabel.Text = "arekBetLabel";
            // 
            // bartekBetLabel
            // 
            this.bartekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bartekBetLabel.Location = new System.Drawing.Point(209, 65);
            this.bartekBetLabel.Name = "bartekBetLabel";
            this.bartekBetLabel.Size = new System.Drawing.Size(180, 17);
            this.bartekBetLabel.TabIndex = 6;
            this.bartekBetLabel.Text = "bartekBetLabel";
            // 
            // janekBetLabel
            // 
            this.janekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.janekBetLabel.Location = new System.Drawing.Point(209, 42);
            this.janekBetLabel.Name = "janekBetLabel";
            this.janekBetLabel.Size = new System.Drawing.Size(180, 17);
            this.janekBetLabel.TabIndex = 5;
            this.janekBetLabel.Text = "janekBetLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zakłady";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(21, 16);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 3;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // arekRadioButton
            // 
            this.arekRadioButton.AutoSize = true;
            this.arekRadioButton.Location = new System.Drawing.Point(11, 89);
            this.arekRadioButton.Name = "arekRadioButton";
            this.arekRadioButton.Size = new System.Drawing.Size(105, 17);
            this.arekRadioButton.TabIndex = 2;
            this.arekRadioButton.TabStop = true;
            this.arekRadioButton.Text = "arekRadioButton";
            this.arekRadioButton.UseVisualStyleBackColor = true;
            // 
            // bartekRadioButton
            // 
            this.bartekRadioButton.AutoSize = true;
            this.bartekRadioButton.Location = new System.Drawing.Point(11, 65);
            this.bartekRadioButton.Name = "bartekRadioButton";
            this.bartekRadioButton.Size = new System.Drawing.Size(114, 17);
            this.bartekRadioButton.TabIndex = 1;
            this.bartekRadioButton.TabStop = true;
            this.bartekRadioButton.Text = "bartekRadioButton";
            this.bartekRadioButton.UseVisualStyleBackColor = true;
            // 
            // janekRadioButton
            // 
            this.janekRadioButton.AutoSize = true;
            this.janekRadioButton.Location = new System.Drawing.Point(11, 41);
            this.janekRadioButton.Name = "janekRadioButton";
            this.janekRadioButton.Size = new System.Drawing.Size(110, 17);
            this.janekRadioButton.TabIndex = 0;
            this.janekRadioButton.TabStop = true;
            this.janekRadioButton.Text = "janekRadioButton";
            this.janekRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raceTrack);
            this.Name = "Form1";
            this.Text = "Dzień na wyścigach";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houndNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown houndNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label arekBetLabel;
        private System.Windows.Forms.Label bartekBetLabel;
        private System.Windows.Forms.Label janekBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton arekRadioButton;
        private System.Windows.Forms.RadioButton bartekRadioButton;
        private System.Windows.Forms.RadioButton janekRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
    }
}

