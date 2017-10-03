namespace Lange_Nacht_der_Wissenschaften_Chooser
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
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lnkLblUrl = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAppointmentCount = new System.Windows.Forms.Label();
            this.lblRememberedCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(13, 153);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Padding = new System.Windows.Forms.Padding(10);
            this.lblPlace.Size = new System.Drawing.Size(48, 36);
            this.lblPlace.TabIndex = 0;
            this.lblPlace.Text = "Ort";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 109);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblTitle.Size = new System.Drawing.Size(70, 44);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titel";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(3, 3);
            this.picImage.Name = "picImage";
            this.picImage.Padding = new System.Windows.Forms.Padding(10);
            this.picImage.Size = new System.Drawing.Size(100, 50);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(10);
            this.lblDescription.Size = new System.Drawing.Size(118, 38);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Beschreibung";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(13, 289);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Padding = new System.Windows.Forms.Padding(10);
            this.lblFooter.Size = new System.Drawing.Size(62, 35);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Footer";
            // 
            // lnkLblUrl
            // 
            this.lnkLblUrl.AutoSize = true;
            this.lnkLblUrl.Location = new System.Drawing.Point(13, 76);
            this.lnkLblUrl.Name = "lnkLblUrl";
            this.lnkLblUrl.Padding = new System.Windows.Forms.Padding(10);
            this.lnkLblUrl.Size = new System.Drawing.Size(106, 33);
            this.lnkLblUrl.TabIndex = 5;
            this.lnkLblUrl.TabStop = true;
            this.lnkLblUrl.Text = "URL zum Termin";
            this.lnkLblUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblUrl_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblAppointmentCount);
            this.flowLayoutPanel1.Controls.Add(this.lblRememberedCount);
            this.flowLayoutPanel1.Controls.Add(this.lnkLblUrl);
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Controls.Add(this.lblPlace);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.lblFooter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(889, 565);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblAppointmentCount
            // 
            this.lblAppointmentCount.AutoSize = true;
            this.lblAppointmentCount.Location = new System.Drawing.Point(13, 10);
            this.lblAppointmentCount.Name = "lblAppointmentCount";
            this.lblAppointmentCount.Padding = new System.Windows.Forms.Padding(10);
            this.lblAppointmentCount.Size = new System.Drawing.Size(85, 33);
            this.lblAppointmentCount.TabIndex = 6;
            this.lblAppointmentCount.Text = "Termin 0 / 0";
            // 
            // lblRememberedCount
            // 
            this.lblRememberedCount.AutoSize = true;
            this.lblRememberedCount.Location = new System.Drawing.Point(13, 43);
            this.lblRememberedCount.Name = "lblRememberedCount";
            this.lblRememberedCount.Padding = new System.Windows.Forms.Padding(10);
            this.lblRememberedCount.Size = new System.Drawing.Size(79, 33);
            this.lblRememberedCount.TabIndex = 7;
            this.lblRememberedCount.Text = "Gemerkt: 0";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.picImage);
            this.flowLayoutPanel2.Controls.Add(this.lblDescription);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 192);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(124, 94);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 565);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Lange Nacht der Wissenschaften - Programmauswahl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.LinkLabel lnkLblUrl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblAppointmentCount;
        private System.Windows.Forms.Label lblRememberedCount;
    }
}

