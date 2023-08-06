namespace WF_StudentDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stu_Id = new System.Windows.Forms.TextBox();
            this.Stu_name = new System.Windows.Forms.TextBox();
            this.Stu_Per = new System.Windows.Forms.TextBox();
            this.BtnBinary = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percentage";
            // 
            // Stu_Id
            // 
            this.Stu_Id.Location = new System.Drawing.Point(310, 74);
            this.Stu_Id.Multiline = true;
            this.Stu_Id.Name = "Stu_Id";
            this.Stu_Id.Size = new System.Drawing.Size(100, 34);
            this.Stu_Id.TabIndex = 3;
            // 
            // Stu_name
            // 
            this.Stu_name.Location = new System.Drawing.Point(310, 122);
            this.Stu_name.Multiline = true;
            this.Stu_name.Name = "Stu_name";
            this.Stu_name.Size = new System.Drawing.Size(100, 34);
            this.Stu_name.TabIndex = 4;
            // 
            // Stu_Per
            // 
            this.Stu_Per.Location = new System.Drawing.Point(310, 170);
            this.Stu_Per.Multiline = true;
            this.Stu_Per.Name = "Stu_Per";
            this.Stu_Per.Size = new System.Drawing.Size(100, 34);
            this.Stu_Per.TabIndex = 5;
            // 
            // BtnBinary
            // 
            this.BtnBinary.Location = new System.Drawing.Point(220, 254);
            this.BtnBinary.Name = "BtnBinary";
            this.BtnBinary.Size = new System.Drawing.Size(116, 37);
            this.BtnBinary.TabIndex = 6;
            this.BtnBinary.Text = "BinaryWriter";
            this.BtnBinary.UseVisualStyleBackColor = true;
            this.BtnBinary.Click += new System.EventHandler(this.BtnBinary_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(354, 254);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(116, 37);
            this.BtnRead.TabIndex = 7;
            this.BtnRead.Text = "BinaryWriter";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnBinary);
            this.Controls.Add(this.Stu_Per);
            this.Controls.Add(this.Stu_name);
            this.Controls.Add(this.Stu_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Stu_Id;
        private System.Windows.Forms.TextBox Stu_name;
        private System.Windows.Forms.TextBox Stu_Per;
        private System.Windows.Forms.Button BtnBinary;
        private System.Windows.Forms.Button BtnRead;
    }
}

