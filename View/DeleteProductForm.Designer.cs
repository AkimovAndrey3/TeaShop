﻿namespace TeaShop
{
    partial class DeleteProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.IndexTxtBox = new System.Windows.Forms.TextBox();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Индекс товара:";
            // 
            // IndexTxtBox
            // 
            this.IndexTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexTxtBox.Location = new System.Drawing.Point(176, 31);
            this.IndexTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IndexTxtBox.Name = "IndexTxtBox";
            this.IndexTxtBox.Size = new System.Drawing.Size(180, 26);
            this.IndexTxtBox.TabIndex = 3;
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductBtn.Location = new System.Drawing.Point(99, 73);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(160, 33);
            this.DeleteProductBtn.TabIndex = 4;
            this.DeleteProductBtn.Text = "Удалить";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // DeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 119);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.IndexTxtBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteProductForm";
            this.Text = "Удалить продукт";
            this.Load += new System.EventHandler(this.DeleteProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IndexTxtBox;
        private System.Windows.Forms.Button DeleteProductBtn;
    }
}