﻿namespace OOPBasic_02_BackAccountApp
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
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(175, 83);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 0;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(175, 113);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(175, 152);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(118, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Balance";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // noTextBox
            // 
            this.noTextBox.Location = new System.Drawing.Point(54, 31);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTextBox.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(175, 31);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(59, 116);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(54, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
    }
}

