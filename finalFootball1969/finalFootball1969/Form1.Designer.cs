namespace finalFootball1969
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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quarterbackLabel = new System.Windows.Forms.Label();
            this.runningbackLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quarterback = new System.Windows.Forms.PictureBox();
            this.receiver = new System.Windows.Forms.PictureBox();
            this.runningback = new System.Windows.Forms.PictureBox();
            this.sacked = new System.Windows.Forms.PictureBox();
            this.blitz = new System.Windows.Forms.PictureBox();
            this.received = new System.Windows.Forms.PictureBox();
            this.labelY = new System.Windows.Forms.Label();
            this.yardsgainedlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.TextBox();
            this.aiLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.strt1 = new System.Windows.Forms.PictureBox();
            this.strt = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.quarterback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blitz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.received)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "seconds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // quarterbackLabel
            // 
            this.quarterbackLabel.AutoSize = true;
            this.quarterbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterbackLabel.Location = new System.Drawing.Point(467, 34);
            this.quarterbackLabel.Name = "quarterbackLabel";
            this.quarterbackLabel.Size = new System.Drawing.Size(114, 18);
            this.quarterbackLabel.TabIndex = 2;
            this.quarterbackLabel.Text = "Quarterback XP";
            // 
            // runningbackLabel
            // 
            this.runningbackLabel.AutoSize = true;
            this.runningbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningbackLabel.Location = new System.Drawing.Point(467, 60);
            this.runningbackLabel.Name = "runningbackLabel";
            this.runningbackLabel.Size = new System.Drawing.Size(118, 18);
            this.runningbackLabel.TabIndex = 3;
            this.runningbackLabel.Text = "Runningback XP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Receiver XP";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "180";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(406, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(405, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(405, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 26);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "0";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(52, 58);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(149, 58);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(606, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Throw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(606, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Location = new System.Drawing.Point(606, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Pass";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quarterback
            // 
            this.quarterback.Image = ((System.Drawing.Image)(resources.GetObject("quarterback.Image")));
            this.quarterback.Location = new System.Drawing.Point(330, 188);
            this.quarterback.Name = "quarterback";
            this.quarterback.Size = new System.Drawing.Size(249, 148);
            this.quarterback.TabIndex = 14;
            this.quarterback.TabStop = false;
            // 
            // receiver
            // 
            this.receiver.Image = ((System.Drawing.Image)(resources.GetObject("receiver.Image")));
            this.receiver.Location = new System.Drawing.Point(329, 133);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(242, 208);
            this.receiver.TabIndex = 15;
            this.receiver.TabStop = false;
            // 
            // runningback
            // 
            this.runningback.Image = ((System.Drawing.Image)(resources.GetObject("runningback.Image")));
            this.runningback.Location = new System.Drawing.Point(329, 136);
            this.runningback.Name = "runningback";
            this.runningback.Size = new System.Drawing.Size(252, 205);
            this.runningback.TabIndex = 16;
            this.runningback.TabStop = false;
            // 
            // sacked
            // 
            this.sacked.Image = ((System.Drawing.Image)(resources.GetObject("sacked.Image")));
            this.sacked.Location = new System.Drawing.Point(23, 131);
            this.sacked.Name = "sacked";
            this.sacked.Size = new System.Drawing.Size(240, 210);
            this.sacked.TabIndex = 17;
            this.sacked.TabStop = false;
            // 
            // blitz
            // 
            this.blitz.Image = ((System.Drawing.Image)(resources.GetObject("blitz.Image")));
            this.blitz.Location = new System.Drawing.Point(23, 97);
            this.blitz.Name = "blitz";
            this.blitz.Size = new System.Drawing.Size(185, 244);
            this.blitz.TabIndex = 18;
            this.blitz.TabStop = false;
            // 
            // received
            // 
            this.received.Image = ((System.Drawing.Image)(resources.GetObject("received.Image")));
            this.received.Location = new System.Drawing.Point(23, 168);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(278, 173);
            this.received.TabIndex = 19;
            this.received.TabStop = false;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(493, 357);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(41, 19);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Yards";
            // 
            // yardsgainedlabel
            // 
            this.yardsgainedlabel.AutoSize = true;
            this.yardsgainedlabel.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yardsgainedlabel.Location = new System.Drawing.Point(553, 357);
            this.yardsgainedlabel.Name = "yardsgainedlabel";
            this.yardsgainedlabel.Size = new System.Drawing.Size(16, 19);
            this.yardsgainedlabel.TabIndex = 21;
            this.yardsgainedlabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(37, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Yards Gained:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(51, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yards Lost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(26, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Same Yard Line:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "ai_invisible";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(139, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(139, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 30;
            // 
            // stats
            // 
            this.stats.Location = new System.Drawing.Point(597, 156);
            this.stats.Multiline = true;
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(163, 108);
            this.stats.TabIndex = 32;
            // 
            // aiLabel
            // 
            this.aiLabel.AutoSize = true;
            this.aiLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiLabel.Location = new System.Drawing.Point(25, 347);
            this.aiLabel.Name = "aiLabel";
            this.aiLabel.Size = new System.Drawing.Size(23, 21);
            this.aiLabel.TabIndex = 33;
            this.aiLabel.Text = "AI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(22, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 126);
            this.panel1.TabIndex = 34;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(506, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Restart Game!";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(594, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Game Announcements:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(725, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 60);
            this.label15.TabIndex = 37;
            this.label15.Text = "X";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // strt1
            // 
            this.strt1.Image = ((System.Drawing.Image)(resources.GetObject("strt1.Image")));
            this.strt1.Location = new System.Drawing.Point(23, 137);
            this.strt1.Name = "strt1";
            this.strt1.Size = new System.Drawing.Size(256, 199);
            this.strt1.TabIndex = 38;
            this.strt1.TabStop = false;
            // 
            // strt
            // 
            this.strt.Image = ((System.Drawing.Image)(resources.GetObject("strt.Image")));
            this.strt.Location = new System.Drawing.Point(329, 138);
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(248, 198);
            this.strt.TabIndex = 39;
            this.strt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Activity";
            // 
            // credits
            // 
            this.credits.Appearance = System.Windows.Forms.Appearance.Button;
            this.credits.AutoSize = true;
            this.credits.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.credits.Location = new System.Drawing.Point(597, 298);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(49, 23);
            this.credits.TabIndex = 41;
            this.credits.TabStop = true;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.CheckedChanged += new System.EventHandler(this.credits_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.strt);
            this.Controls.Add(this.strt1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aiLabel);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yardsgainedlabel);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.received);
            this.Controls.Add(this.blitz);
            this.Controls.Add(this.sacked);
            this.Controls.Add(this.runningback);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.quarterback);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.runningbackLabel);
            this.Controls.Add(this.quarterbackLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " 1969 Studded Diamond Champhionship Cup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quarterback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blitz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.received)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label quarterbackLabel;
        private System.Windows.Forms.Label runningbackLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox quarterback;
        private System.Windows.Forms.PictureBox receiver;
        private System.Windows.Forms.PictureBox runningback;
        private System.Windows.Forms.PictureBox sacked;
        private System.Windows.Forms.PictureBox blitz;
        private System.Windows.Forms.PictureBox received;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label yardsgainedlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox stats;
        private System.Windows.Forms.Label aiLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox strt1;
        private System.Windows.Forms.PictureBox strt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton credits;
    }
}

