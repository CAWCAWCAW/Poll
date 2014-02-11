namespace Poll
{
    partial class Gui
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
            this.buttonquestion = new System.Windows.Forms.Button();
            this.textBoxquestion = new System.Windows.Forms.TextBox();
            this.buttonanswer = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelquestion = new System.Windows.Forms.Label();
            this.labelanswercount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelinterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonquestion
            // 
            this.buttonquestion.Location = new System.Drawing.Point(309, 9);
            this.buttonquestion.Name = "buttonquestion";
            this.buttonquestion.Size = new System.Drawing.Size(102, 23);
            this.buttonquestion.TabIndex = 0;
            this.buttonquestion.Text = "Set Question";
            this.buttonquestion.UseVisualStyleBackColor = true;
            this.buttonquestion.Click += new System.EventHandler(this.buttonquestion_Click);
            // 
            // textBoxquestion
            // 
            this.textBoxquestion.Location = new System.Drawing.Point(12, 11);
            this.textBoxquestion.Name = "textBoxquestion";
            this.textBoxquestion.Size = new System.Drawing.Size(291, 20);
            this.textBoxquestion.TabIndex = 1;
            // 
            // buttonanswer
            // 
            this.buttonanswer.Location = new System.Drawing.Point(309, 38);
            this.buttonanswer.Name = "buttonanswer";
            this.buttonanswer.Size = new System.Drawing.Size(102, 23);
            this.buttonanswer.TabIndex = 2;
            this.buttonanswer.Text = "Add answer";
            this.buttonanswer.UseVisualStyleBackColor = true;
            this.buttonanswer.Click += new System.EventHandler(this.buttonanswer_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(12, 41);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(291, 20);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 121);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question:";
            // 
            // labelquestion
            // 
            this.labelquestion.AutoSize = true;
            this.labelquestion.Location = new System.Drawing.Point(70, 81);
            this.labelquestion.Name = "labelquestion";
            this.labelquestion.Size = new System.Drawing.Size(35, 13);
            this.labelquestion.TabIndex = 6;
            this.labelquestion.Text = "empty";
            // 
            // labelanswercount
            // 
            this.labelanswercount.AutoSize = true;
            this.labelanswercount.Location = new System.Drawing.Point(9, 110);
            this.labelanswercount.Name = "labelanswercount";
            this.labelanswercount.Size = new System.Drawing.Size(65, 13);
            this.labelanswercount.TabIndex = 7;
            this.labelanswercount.Text = "Answers (0):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Start poll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(399, 153);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Results:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 94);
            this.button3.TabIndex = 12;
            this.button3.Text = "Broadcast Results";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "End";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(153, 203);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(230, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labelinterval
            // 
            this.labelinterval.AutoSize = true;
            this.labelinterval.Location = new System.Drawing.Point(153, 187);
            this.labelinterval.Name = "labelinterval";
            this.labelinterval.Size = new System.Drawing.Size(145, 13);
            this.labelinterval.TabIndex = 15;
            this.labelinterval.Text = "Repeat interval in seconds: 0\r\n";
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 258);
            this.Controls.Add(this.labelinterval);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelanswercount);
            this.Controls.Add(this.labelquestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonanswer);
            this.Controls.Add(this.textBoxquestion);
            this.Controls.Add(this.buttonquestion);
            this.Name = "Gui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poll - Gui";
            this.Load += new System.EventHandler(this.Gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonquestion;
        private System.Windows.Forms.TextBox textBoxquestion;
        private System.Windows.Forms.Button buttonanswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelquestion;
        private System.Windows.Forms.Label labelanswercount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelinterval;


    }
}