namespace DispatchCameraUploader
{
    partial class frmCameraUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCameraUpload));
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rd_packing_bsc = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdo_slimline_dispatch = new System.Windows.Forms.RadioButton();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnPacking = new System.Windows.Forms.Button();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(227, 156);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(6, 130);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(296, 20);
            this.txtSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source File:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 185);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(296, 23);
            this.progressBar2.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dispatch";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rd_packing_bsc
            // 
            this.rd_packing_bsc.AutoSize = true;
            this.rd_packing_bsc.Location = new System.Drawing.Point(116, 51);
            this.rd_packing_bsc.Name = "rd_packing_bsc";
            this.rd_packing_bsc.Size = new System.Drawing.Size(143, 17);
            this.rd_packing_bsc.TabIndex = 5;
            this.rd_packing_bsc.TabStop = true;
            this.rd_packing_bsc.Text = "Slimline - Packing (black)";
            this.rd_packing_bsc.UseVisualStyleBackColor = true;
            this.rd_packing_bsc.CheckedChanged += new System.EventHandler(this.Rd_packing_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(153, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Slimline - Production (silver)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Packing";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Welding ";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // rdo_slimline_dispatch
            // 
            this.rdo_slimline_dispatch.AutoSize = true;
            this.rdo_slimline_dispatch.Location = new System.Drawing.Point(116, 90);
            this.rdo_slimline_dispatch.Name = "rdo_slimline_dispatch";
            this.rdo_slimline_dispatch.Size = new System.Drawing.Size(111, 17);
            this.rdo_slimline_dispatch.TabIndex = 9;
            this.rdo_slimline_dispatch.TabStop = true;
            this.rdo_slimline_dispatch.Text = "Slimline - Dispatch";
            this.rdo_slimline_dispatch.UseVisualStyleBackColor = true;
            this.rdo_slimline_dispatch.CheckedChanged += new System.EventHandler(this.rdo_slimline_dispatch_CheckedChanged);
            // 
            // btnProduction
            // 
            this.btnProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Image = ((System.Drawing.Image)(resources.GetObject("btnProduction.Image")));
            this.btnProduction.Location = new System.Drawing.Point(265, 4);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(37, 33);
            this.btnProduction.TabIndex = 12;
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnPacking
            // 
            this.btnPacking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacking.Image = ((System.Drawing.Image)(resources.GetObject("btnPacking.Image")));
            this.btnPacking.Location = new System.Drawing.Point(265, 43);
            this.btnPacking.Name = "btnPacking";
            this.btnPacking.Size = new System.Drawing.Size(37, 33);
            this.btnPacking.TabIndex = 13;
            this.btnPacking.UseVisualStyleBackColor = true;
            this.btnPacking.Click += new System.EventHandler(this.btnPacking_Click);
            // 
            // btnDispatch
            // 
            this.btnDispatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatch.Image = ((System.Drawing.Image)(resources.GetObject("btnDispatch.Image")));
            this.btnDispatch.Location = new System.Drawing.Point(265, 82);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(37, 33);
            this.btnDispatch.TabIndex = 14;
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // frmCameraUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 217);
            this.Controls.Add(this.btnDispatch);
            this.Controls.Add(this.btnPacking);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.rdo_slimline_dispatch);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rd_packing_bsc);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCameraUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Upload - SLIMLINE VER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rd_packing_bsc;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rdo_slimline_dispatch;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnPacking;
        private System.Windows.Forms.Button btnDispatch;
    }
}