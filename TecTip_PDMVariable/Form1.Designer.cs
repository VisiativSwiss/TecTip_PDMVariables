﻿namespace TecTip_PDMVariable
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
            this.Button_Read = new System.Windows.Forms.Button();
            this.TextBox_Read_Variable = new System.Windows.Forms.TextBox();
            this.Label_Read_Value = new System.Windows.Forms.Label();
            this.TextBox_Update_Variable = new System.Windows.Forms.TextBox();
            this.TextBox_Update_Value = new System.Windows.Forms.TextBox();
            this.Button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Read
            // 
            this.Button_Read.Location = new System.Drawing.Point(118, 12);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(75, 23);
            this.Button_Read.TabIndex = 0;
            this.Button_Read.Text = "Read";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // TextBox_Read_Variable
            // 
            this.TextBox_Read_Variable.Location = new System.Drawing.Point(12, 12);
            this.TextBox_Read_Variable.Name = "TextBox_Read_Variable";
            this.TextBox_Read_Variable.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Read_Variable.TabIndex = 1;
            // 
            // Label_Read_Value
            // 
            this.Label_Read_Value.AutoSize = true;
            this.Label_Read_Value.Location = new System.Drawing.Point(200, 16);
            this.Label_Read_Value.Name = "Label_Read_Value";
            this.Label_Read_Value.Size = new System.Drawing.Size(75, 13);
            this.Label_Read_Value.TabIndex = 2;
            this.Label_Read_Value.Text = "Variable Value";
            // 
            // TextBox_Update_Variable
            // 
            this.TextBox_Update_Variable.Location = new System.Drawing.Point(12, 38);
            this.TextBox_Update_Variable.Name = "TextBox_Update_Variable";
            this.TextBox_Update_Variable.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Update_Variable.TabIndex = 3;
            // 
            // TextBox_Update_Value
            // 
            this.TextBox_Update_Value.Location = new System.Drawing.Point(118, 38);
            this.TextBox_Update_Value.Name = "TextBox_Update_Value";
            this.TextBox_Update_Value.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Update_Value.TabIndex = 4;
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(224, 38);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(75, 23);
            this.Button_Update.TabIndex = 5;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 81);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.TextBox_Update_Value);
            this.Controls.Add(this.TextBox_Update_Variable);
            this.Controls.Add(this.Label_Read_Value);
            this.Controls.Add(this.TextBox_Read_Variable);
            this.Controls.Add(this.Button_Read);
            this.Name = "Form1";
            this.Text = "PDM Variable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Read;
        private System.Windows.Forms.TextBox TextBox_Read_Variable;
        private System.Windows.Forms.Label Label_Read_Value;
        private System.Windows.Forms.TextBox TextBox_Update_Variable;
        private System.Windows.Forms.TextBox TextBox_Update_Value;
        private System.Windows.Forms.Button Button_Update;
    }
}

