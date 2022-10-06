namespace PictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBx1
            // 
            this.picBx1.Image = global::PictureBox.Properties.Resources.slikaP;
            this.picBx1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBx1.InitialImage")));
            this.picBx1.Location = new System.Drawing.Point(232, 99);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(100, 50);
            this.picBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx1.TabIndex = 0;
            this.picBx1.TabStop = false;
            this.picBx1.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(232, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Prikazi sliku";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.picBx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.Button btn1;
    }
}

