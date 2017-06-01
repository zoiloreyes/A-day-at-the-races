namespace A_Day_at_the_races
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.dogNumeric = new System.Windows.Forms.NumericUpDown();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.raceButton = new System.Windows.Forms.Button();
            this.currentBetterLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.raceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 42);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 42);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 42);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.dogNumeric);
            this.groupBox1.Controls.Add(this.betNumeric);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.currentBetterLabel);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "bucks on dog number";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(67, 105);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(72, 23);
            this.betButton.TabIndex = 17;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // dogNumeric
            // 
            this.dogNumeric.Location = new System.Drawing.Point(326, 106);
            this.dogNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumeric.Name = "dogNumeric";
            this.dogNumeric.Size = new System.Drawing.Size(68, 20);
            this.dogNumeric.TabIndex = 16;
            this.dogNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betNumeric
            // 
            this.betNumeric.Location = new System.Drawing.Point(145, 106);
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(59, 20);
            this.betNumeric.TabIndex = 15;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(625, 16);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(261, 107);
            this.raceButton.TabIndex = 14;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // currentBetterLabel
            // 
            this.currentBetterLabel.AutoSize = true;
            this.currentBetterLabel.Location = new System.Drawing.Point(26, 110);
            this.currentBetterLabel.Name = "currentBetterLabel";
            this.currentBetterLabel.Size = new System.Drawing.Size(24, 13);
            this.currentBetterLabel.TabIndex = 6;
            this.currentBetterLabel.Text = "Joe";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(310, 80);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(161, 15);
            this.alBetLabel.TabIndex = 13;
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(310, 57);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(161, 15);
            this.bobBetLabel.TabIndex = 12;
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(310, 34);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(161, 15);
            this.joeBetLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bets";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(6, 78);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 9;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(6, 55);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 8;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(6, 32);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 7;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 16);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(0, 13);
            this.minimumBetLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // raceTrack
            // 
            this.raceTrack.BackColor = System.Drawing.SystemColors.Window;
            this.raceTrack.Location = new System.Drawing.Point(12, 0);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(892, 198);
            this.raceTrack.TabIndex = 5;
            this.raceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.raceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label currentBetterLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown dogNumeric;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button betButton;
    }
}

