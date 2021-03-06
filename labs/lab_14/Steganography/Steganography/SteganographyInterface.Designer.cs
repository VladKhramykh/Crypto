﻿namespace Steganography
{
    partial class SteganographyInterface
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
            this.inputImage = new System.Windows.Forms.PictureBox();
            this.imageSelectionLink = new System.Windows.Forms.Label();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.encodeRadio = new System.Windows.Forms.RadioButton();
            this.decodeRadio = new System.Windows.Forms.RadioButton();
            this.convertImageButton = new System.Windows.Forms.Button();
            this.saveImageLink = new System.Windows.Forms.Label();
            this.imageCapacity = new System.Windows.Forms.Label();
            this.secretMessageText = new System.Windows.Forms.TextBox();
            this.secretMessageSize = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.aesPassword = new System.Windows.Forms.TextBox();
            this.aesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // inputImage
            // 
            this.inputImage.BackColor = System.Drawing.Color.White;
            this.inputImage.Location = new System.Drawing.Point(12, 12);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(315, 284);
            this.inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImage.TabIndex = 1;
            this.inputImage.TabStop = false;
            // 
            // imageSelectionLink
            // 
            this.imageSelectionLink.AutoSize = true;
            this.imageSelectionLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSelectionLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageSelectionLink.ForeColor = System.Drawing.Color.SteelBlue;
            this.imageSelectionLink.Location = new System.Drawing.Point(105, 305);
            this.imageSelectionLink.Name = "imageSelectionLink";
            this.imageSelectionLink.Size = new System.Drawing.Size(124, 20);
            this.imageSelectionLink.TabIndex = 2;
            this.imageSelectionLink.Text = "Select an image...";
            this.imageSelectionLink.Click += new System.EventHandler(this.ImageSelectionLink_Click);
            // 
            // outputImage
            // 
            this.outputImage.BackColor = System.Drawing.Color.White;
            this.outputImage.Location = new System.Drawing.Point(511, 12);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(315, 284);
            this.outputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImage.TabIndex = 1;
            this.outputImage.TabStop = false;
            // 
            // encodeRadio
            // 
            this.encodeRadio.AutoSize = true;
            this.encodeRadio.Checked = true;
            this.encodeRadio.ForeColor = System.Drawing.Color.Black;
            this.encodeRadio.Location = new System.Drawing.Point(486, 367);
            this.encodeRadio.Name = "encodeRadio";
            this.encodeRadio.Size = new System.Drawing.Size(62, 17);
            this.encodeRadio.TabIndex = 4;
            this.encodeRadio.TabStop = true;
            this.encodeRadio.Text = "Encode";
            this.encodeRadio.UseVisualStyleBackColor = true;
            // 
            // decodeRadio
            // 
            this.decodeRadio.AutoSize = true;
            this.decodeRadio.ForeColor = System.Drawing.Color.Black;
            this.decodeRadio.Location = new System.Drawing.Point(486, 390);
            this.decodeRadio.Name = "decodeRadio";
            this.decodeRadio.Size = new System.Drawing.Size(63, 17);
            this.decodeRadio.TabIndex = 4;
            this.decodeRadio.Text = "Decode";
            this.decodeRadio.UseVisualStyleBackColor = true;
            // 
            // convertImageButton
            // 
            this.convertImageButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.convertImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertImageButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertImageButton.ForeColor = System.Drawing.Color.Black;
            this.convertImageButton.Location = new System.Drawing.Point(670, 410);
            this.convertImageButton.Name = "convertImageButton";
            this.convertImageButton.Size = new System.Drawing.Size(156, 77);
            this.convertImageButton.TabIndex = 6;
            this.convertImageButton.Text = "Convert";
            this.convertImageButton.UseVisualStyleBackColor = false;
            this.convertImageButton.Click += new System.EventHandler(this.ConvertImageButton_Click);
            // 
            // saveImageLink
            // 
            this.saveImageLink.AutoSize = true;
            this.saveImageLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImageLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImageLink.ForeColor = System.Drawing.Color.SteelBlue;
            this.saveImageLink.Location = new System.Drawing.Point(562, 299);
            this.saveImageLink.Name = "saveImageLink";
            this.saveImageLink.Size = new System.Drawing.Size(167, 20);
            this.saveImageLink.TabIndex = 2;
            this.saveImageLink.Text = "Save Converted Image...";
            this.saveImageLink.Click += new System.EventHandler(this.SaveImageLink_Click);
            // 
            // imageCapacity
            // 
            this.imageCapacity.AutoSize = true;
            this.imageCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageCapacity.ForeColor = System.Drawing.Color.Black;
            this.imageCapacity.Location = new System.Drawing.Point(452, 344);
            this.imageCapacity.Name = "imageCapacity";
            this.imageCapacity.Size = new System.Drawing.Size(122, 15);
            this.imageCapacity.TabIndex = 2;
            this.imageCapacity.Text = "Max Capacity: 0 bytes";
            // 
            // secretMessageText
            // 
            this.secretMessageText.BackColor = System.Drawing.Color.White;
            this.secretMessageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secretMessageText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretMessageText.ForeColor = System.Drawing.Color.Black;
            this.secretMessageText.Location = new System.Drawing.Point(14, 341);
            this.secretMessageText.Multiline = true;
            this.secretMessageText.Name = "secretMessageText";
            this.secretMessageText.Size = new System.Drawing.Size(313, 143);
            this.secretMessageText.TabIndex = 5;
            this.secretMessageText.Text = "Secret Message";
            this.secretMessageText.TextChanged += new System.EventHandler(this.SecretMessageText_TextChanged);
            // 
            // secretMessageSize
            // 
            this.secretMessageSize.AutoSize = true;
            this.secretMessageSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretMessageSize.ForeColor = System.Drawing.Color.Black;
            this.secretMessageSize.Location = new System.Drawing.Point(468, 410);
            this.secretMessageSize.Name = "secretMessageSize";
            this.secretMessageSize.Size = new System.Drawing.Size(97, 15);
            this.secretMessageSize.TabIndex = 7;
            this.secretMessageSize.Text = "Data Size: 0 bytes";
            this.secretMessageSize.Click += new System.EventHandler(this.secretMessageSize_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.BackColor = System.Drawing.Color.Pink;
            this.generateKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateKeyButton.ForeColor = System.Drawing.Color.Black;
            this.generateKeyButton.Location = new System.Drawing.Point(566, 466);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(73, 22);
            this.generateKeyButton.TabIndex = 8;
            this.generateKeyButton.Text = "Generate";
            this.generateKeyButton.UseVisualStyleBackColor = false;
            this.generateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // aesPassword
            // 
            this.aesPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.aesPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aesPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aesPassword.ForeColor = System.Drawing.Color.White;
            this.aesPassword.Location = new System.Drawing.Point(438, 465);
            this.aesPassword.Name = "aesPassword";
            this.aesPassword.Size = new System.Drawing.Size(122, 22);
            this.aesPassword.TabIndex = 5;
            this.aesPassword.Text = "AesKey";
            this.aesPassword.TextChanged += new System.EventHandler(this.aesPassword_TextChanged);
            // 
            // aesCheckBox
            // 
            this.aesCheckBox.AutoSize = true;
            this.aesCheckBox.ForeColor = System.Drawing.Color.Black;
            this.aesCheckBox.Location = new System.Drawing.Point(363, 470);
            this.aesCheckBox.Name = "aesCheckBox";
            this.aesCheckBox.Size = new System.Drawing.Size(69, 17);
            this.aesCheckBox.TabIndex = 3;
            this.aesCheckBox.Text = "Use AES";
            this.aesCheckBox.UseVisualStyleBackColor = true;
            // 
            // SteganographyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(863, 527);
            this.Controls.Add(this.generateKeyButton);
            this.Controls.Add(this.secretMessageSize);
            this.Controls.Add(this.convertImageButton);
            this.Controls.Add(this.secretMessageText);
            this.Controls.Add(this.aesPassword);
            this.Controls.Add(this.decodeRadio);
            this.Controls.Add(this.encodeRadio);
            this.Controls.Add(this.aesCheckBox);
            this.Controls.Add(this.saveImageLink);
            this.Controls.Add(this.imageCapacity);
            this.Controls.Add(this.imageSelectionLink);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.inputImage);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SteganographyInterface";
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.SteganographyInterface_Load);
            this.Shown += new System.EventHandler(this.SteganographyInterface_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inputImage;
        private System.Windows.Forms.Label imageSelectionLink;
        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.RadioButton encodeRadio;
        private System.Windows.Forms.RadioButton decodeRadio;
        private System.Windows.Forms.Button convertImageButton;
        private System.Windows.Forms.Label saveImageLink;
        private System.Windows.Forms.Label imageCapacity;
        private System.Windows.Forms.TextBox secretMessageText;
        private System.Windows.Forms.Label secretMessageSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.TextBox aesPassword;
        private System.Windows.Forms.CheckBox aesCheckBox;
    }
}

