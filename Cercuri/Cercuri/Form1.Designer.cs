namespace Cercuri
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Generate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YResult = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(662, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(126, 46);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(662, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 160);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max points:";
            // 
            // MaxPoints
            // 
            this.MaxPoints.AutoSize = true;
            this.MaxPoints.Location = new System.Drawing.Point(725, 214);
            this.MaxPoints.Name = "MaxPoints";
            this.MaxPoints.Size = new System.Drawing.Size(61, 13);
            this.MaxPoints.TabIndex = 3;
            this.MaxPoints.Text = "Max points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // XResult
            // 
            this.XResult.AutoSize = true;
            this.XResult.Location = new System.Drawing.Point(685, 237);
            this.XResult.Name = "XResult";
            this.XResult.Size = new System.Drawing.Size(12, 13);
            this.XResult.TabIndex = 3;
            this.XResult.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "y";
            // 
            // YResult
            // 
            this.YResult.AutoSize = true;
            this.YResult.Location = new System.Drawing.Point(735, 237);
            this.YResult.Name = "YResult";
            this.YResult.Size = new System.Drawing.Size(12, 13);
            this.YResult.TabIndex = 3;
            this.YResult.Text = "y";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(662, 77);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(124, 46);
            this.Go.TabIndex = 4;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sau";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(659, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 58);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pentru Go se adauga puncte dand click pe picturebox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.MaxPoints);
            this.Controls.Add(this.YResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.XResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label XResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label YResult;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

