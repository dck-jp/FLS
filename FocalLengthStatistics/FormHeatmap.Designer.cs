using System;

namespace FocalLengthStatistics
{
    partial class FormHeatmap
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
            this.labelRightEdge = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.labelLeftEdge = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.pictureBoxColorBar = new System.Windows.Forms.PictureBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.metroLabelTitle = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(65, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelRightEdge
            // 
            this.labelRightEdge.AutoSize = true;
            this.labelRightEdge.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRightEdge.Location = new System.Drawing.Point(515, 525);
            this.labelRightEdge.Name = "labelRightEdge";
            this.labelRightEdge.Size = new System.Drawing.Size(29, 17);
            this.labelRightEdge.TabIndex = 4;
            this.labelRightEdge.Text = "300";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(183, 556);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(222, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Focal Length (35mm film equivalent)";
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDateBegin.Location = new System.Drawing.Point(12, 85);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(55, 17);
            this.labelDateBegin.TabIndex = 7;
            this.labelDateBegin.Text = "****-**";
            // 
            // labelLeftEdge
            // 
            this.labelLeftEdge.AutoSize = true;
            this.labelLeftEdge.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLeftEdge.Location = new System.Drawing.Point(63, 525);
            this.labelLeftEdge.Name = "labelLeftEdge";
            this.labelLeftEdge.Size = new System.Drawing.Size(15, 17);
            this.labelLeftEdge.TabIndex = 8;
            this.labelLeftEdge.Text = "1";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelEndDate.Location = new System.Drawing.Point(12, 510);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 17);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "****-**";
            // 
            // pictureBoxColorBar
            // 
            this.pictureBoxColorBar.Location = new System.Drawing.Point(156, 583);
            this.pictureBoxColorBar.Name = "pictureBoxColorBar";
            this.pictureBoxColorBar.Size = new System.Drawing.Size(281, 14);
            this.pictureBoxColorBar.TabIndex = 10;
            this.pictureBoxColorBar.TabStop = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMax.Location = new System.Drawing.Point(443, 583);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(31, 17);
            this.labelMax.TabIndex = 4;
            this.labelMax.Text = "max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMin.Location = new System.Drawing.Point(100, 583);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(50, 17);
            this.labelMin.TabIndex = 4;
            this.labelMin.Text = "min (0)";
            // 
            // metroLabelTitle
            // 
            this.metroLabelTitle.AutoSize = true;
            this.metroLabelTitle.Location = new System.Drawing.Point(65, 60);
            this.metroLabelTitle.Name = "metroLabelTitle";
            this.metroLabelTitle.Size = new System.Drawing.Size(81, 19);
            this.metroLabelTitle.TabIndex = 11;
            this.metroLabelTitle.Text = "metroLabel1";
            // 
            // FormHeatmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 617);
            this.Controls.Add(this.metroLabelTitle);
            this.Controls.Add(this.pictureBoxColorBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelRightEdge);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelDateBegin);
            this.Controls.Add(this.labelLeftEdge);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHeatmap";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Statistics";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRightEdge;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelDateBegin;
        private System.Windows.Forms.Label labelLeftEdge;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.PictureBox pictureBoxColorBar;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private MetroFramework.Controls.MetroLabel metroLabelTitle;
    }
}