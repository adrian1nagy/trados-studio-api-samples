﻿namespace Sdl.Verification.Sdk.IdenticalCheck.Extended
{
    partial class IdenticalVerifierUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Context = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ConsiderTags = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ConsiderTags);
            this.groupBox1.Controls.Add(this.txt_Context);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identical Check";
            // 
            // txt_Context
            // 
            this.txt_Context.Location = new System.Drawing.Point(10, 51);
            this.txt_Context.Name = "txt_Context";
            this.txt_Context.Size = new System.Drawing.Size(217, 20);
            this.txt_Context.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check segment pairs with the following context:";
            // 
            // cb_ConsiderTags
            // 
            this.cb_ConsiderTags.AutoSize = true;
            this.cb_ConsiderTags.Location = new System.Drawing.Point(14, 92);
            this.cb_ConsiderTags.Name = "cb_ConsiderTags";
            this.cb_ConsiderTags.Size = new System.Drawing.Size(90, 17);
            this.cb_ConsiderTags.TabIndex = 2;
            this.cb_ConsiderTags.Text = "Consider tags";
            this.cb_ConsiderTags.UseVisualStyleBackColor = true;
            // 
            // IdenticalVerifierUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "IdenticalVerifierUI";
            this.Size = new System.Drawing.Size(342, 383);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Context;
        private System.Windows.Forms.CheckBox cb_ConsiderTags;
    }
}
