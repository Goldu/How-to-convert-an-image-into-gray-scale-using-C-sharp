namespace Imageprocessing
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
            this.PicOriginal = new System.Windows.Forms.PictureBox();
            this.PicResult = new System.Windows.Forms.PictureBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.Btngray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicResult)).BeginInit();
            this.SuspendLayout();
            // 
            // PicOriginal
            // 
            this.PicOriginal.Location = new System.Drawing.Point(76, 46);
            this.PicOriginal.Name = "PicOriginal";
            this.PicOriginal.Size = new System.Drawing.Size(347, 281);
            this.PicOriginal.TabIndex = 0;
            this.PicOriginal.TabStop = false;
            // 
            // PicResult
            // 
            this.PicResult.Location = new System.Drawing.Point(578, 46);
            this.PicResult.Name = "PicResult";
            this.PicResult.Size = new System.Drawing.Size(347, 281);
            this.PicResult.TabIndex = 1;
            this.PicResult.TabStop = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(157, 355);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(114, 33);
            this.BtnOpen.TabIndex = 2;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Btngray
            // 
            this.Btngray.Location = new System.Drawing.Point(675, 355);
            this.Btngray.Name = "Btngray";
            this.Btngray.Size = new System.Drawing.Size(114, 33);
            this.Btngray.TabIndex = 3;
            this.Btngray.Text = "Gray";
            this.Btngray.UseVisualStyleBackColor = true;
            this.Btngray.Click += new System.EventHandler(this.btngray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.Btngray);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.PicResult);
            this.Controls.Add(this.PicOriginal);
            this.Name = "Form1";
            this.Text = "ImageProcessing";
            ((System.ComponentModel.ISupportInitialize)(this.PicOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicOriginal;
        private System.Windows.Forms.PictureBox PicResult;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button Btngray;
    }
}

