namespace WFALee
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
            this.mazeGenerate = new System.Windows.Forms.Button();
            this.mazeRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mazeCols = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wallsPercentage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startCol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.finishRow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.finishCol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 437);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mazeGenerate
            // 
            this.mazeGenerate.Location = new System.Drawing.Point(784, 172);
            this.mazeGenerate.Name = "mazeGenerate";
            this.mazeGenerate.Size = new System.Drawing.Size(207, 32);
            this.mazeGenerate.TabIndex = 8;
            this.mazeGenerate.Text = "Generate";
            this.mazeGenerate.UseVisualStyleBackColor = true;
            this.mazeGenerate.Click += new System.EventHandler(this.mazeGenerate_Click);
            // 
            // mazeRows
            // 
            this.mazeRows.Location = new System.Drawing.Point(784, 31);
            this.mazeRows.Name = "mazeRows";
            this.mazeRows.Size = new System.Drawing.Size(55, 20);
            this.mazeRows.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(781, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maze rows";
            // 
            // mazeCols
            // 
            this.mazeCols.Location = new System.Drawing.Point(860, 31);
            this.mazeCols.Name = "mazeCols";
            this.mazeCols.Size = new System.Drawing.Size(55, 20);
            this.mazeCols.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maze cols";
            // 
            // wallsPercentage
            // 
            this.wallsPercentage.Location = new System.Drawing.Point(936, 31);
            this.wallsPercentage.Name = "wallsPercentage";
            this.wallsPercentage.Size = new System.Drawing.Size(55, 20);
            this.wallsPercentage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Walls %";
            // 
            // startRow
            // 
            this.startRow.Location = new System.Drawing.Point(784, 81);
            this.startRow.Name = "startRow";
            this.startRow.Size = new System.Drawing.Size(55, 20);
            this.startRow.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(781, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start row";
            // 
            // startCol
            // 
            this.startCol.Location = new System.Drawing.Point(860, 81);
            this.startCol.Name = "startCol";
            this.startCol.Size = new System.Drawing.Size(55, 20);
            this.startCol.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(857, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start col";
            // 
            // finishRow
            // 
            this.finishRow.Location = new System.Drawing.Point(784, 133);
            this.finishRow.Name = "finishRow";
            this.finishRow.Size = new System.Drawing.Size(55, 20);
            this.finishRow.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(781, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Finish row";
            // 
            // finishCol
            // 
            this.finishCol.Location = new System.Drawing.Point(860, 133);
            this.finishCol.Name = "finishCol";
            this.finishCol.Size = new System.Drawing.Size(55, 20);
            this.finishCol.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(857, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Finish col";
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(785, 417);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(207, 32);
            this.go.TabIndex = 9;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(785, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 160);
            this.listBox1.TabIndex = 10;
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(784, 210);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(206, 32);
            this.Random.TabIndex = 11;
            this.Random.Text = "Generate random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 461);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wallsPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mazeCols);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finishCol);
            this.Controls.Add(this.startCol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finishRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mazeRows);
            this.Controls.Add(this.mazeGenerate);
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
        private System.Windows.Forms.Button mazeGenerate;
        private System.Windows.Forms.TextBox mazeRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mazeCols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wallsPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startCol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox finishRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox finishCol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Random;
    }
}

