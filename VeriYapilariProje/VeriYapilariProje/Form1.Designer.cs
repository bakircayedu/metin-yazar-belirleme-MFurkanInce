
namespace VeriYapilariProje
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
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.rtxtbxResult = new System.Windows.Forms.RichTextBox();
            this.rtxtbxResultwords = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHashBTN = new System.Windows.Forms.Button();
            this.txtHashInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Enabled = false;
            this.filePath.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filePath.Location = new System.Drawing.Point(119, 37);
            this.filePath.Margin = new System.Windows.Forms.Padding(2);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(438, 20);
            this.filePath.TabIndex = 0;
            this.filePath.Text = "Dosya seç";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(36, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dosya Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStackOku
            // 
            this.btnStackOku.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStackOku.Location = new System.Drawing.Point(36, 115);
            this.btnStackOku.Margin = new System.Windows.Forms.Padding(2);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(79, 31);
            this.btnStackOku.TabIndex = 2;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = false;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // rtxtbxResult
            // 
            this.rtxtbxResult.Location = new System.Drawing.Point(119, 108);
            this.rtxtbxResult.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtbxResult.Name = "rtxtbxResult";
            this.rtxtbxResult.Size = new System.Drawing.Size(438, 144);
            this.rtxtbxResult.TabIndex = 3;
            this.rtxtbxResult.Text = "";
            // 
            // rtxtbxResultwords
            // 
            this.rtxtbxResultwords.Location = new System.Drawing.Point(590, 31);
            this.rtxtbxResultwords.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtbxResultwords.Name = "rtxtbxResultwords";
            this.rtxtbxResultwords.Size = new System.Drawing.Size(481, 221);
            this.rtxtbxResultwords.TabIndex = 4;
            this.rtxtbxResultwords.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(36, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agaca\'a Oku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHashBTN
            // 
            this.txtHashBTN.Location = new System.Drawing.Point(36, 305);
            this.txtHashBTN.Name = "txtHashBTN";
            this.txtHashBTN.Size = new System.Drawing.Size(96, 39);
            this.txtHashBTN.TabIndex = 6;
            this.txtHashBTN.Text = "Hashle";
            this.txtHashBTN.UseVisualStyleBackColor = true;
            this.txtHashBTN.Click += new System.EventHandler(this.txtHashBTN_Click);
            // 
            // txtHashInput
            // 
            this.txtHashInput.Location = new System.Drawing.Point(138, 315);
            this.txtHashInput.Name = "txtHashInput";
            this.txtHashInput.Size = new System.Drawing.Size(177, 20);
            this.txtHashInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(909, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Muhammet Furkan İnce";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1102, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHashInput);
            this.Controls.Add(this.txtHashBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtbxResultwords);
            this.Controls.Add(this.rtxtbxResult);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.filePath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "200601059";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.RichTextBox rtxtbxResult;
        private System.Windows.Forms.RichTextBox rtxtbxResultwords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtHashBTN;
        private System.Windows.Forms.TextBox txtHashInput;
        private System.Windows.Forms.Label label1;
    }
}

