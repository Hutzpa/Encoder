namespace RGB_Encoder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxEncode = new System.Windows.Forms.RichTextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.pictureBoxEncode = new System.Windows.Forms.PictureBox();
            this.buttonUploadEncode = new System.Windows.Forms.Button();
            this.richTextBoxDecode = new System.Windows.Forms.RichTextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.pictureBoxDecode = new System.Windows.Forms.PictureBox();
            this.buttonUploadDecode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecode)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxEncode
            // 
            this.richTextBoxEncode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxEncode.Location = new System.Drawing.Point(138, 40);
            this.richTextBoxEncode.Name = "richTextBoxEncode";
            this.richTextBoxEncode.Size = new System.Drawing.Size(270, 210);
            this.richTextBoxEncode.TabIndex = 15;
            this.richTextBoxEncode.Text = "";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(15, 150);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(120, 100);
            this.buttonEncode.TabIndex = 14;
            this.buttonEncode.Text = "Кодировать";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // pictureBoxEncode
            // 
            this.pictureBoxEncode.Location = new System.Drawing.Point(414, 40);
            this.pictureBoxEncode.Name = "pictureBoxEncode";
            this.pictureBoxEncode.Size = new System.Drawing.Size(270, 210);
            this.pictureBoxEncode.TabIndex = 13;
            this.pictureBoxEncode.TabStop = false;
            // 
            // buttonUploadEncode
            // 
            this.buttonUploadEncode.Location = new System.Drawing.Point(15, 40);
            this.buttonUploadEncode.Name = "buttonUploadEncode";
            this.buttonUploadEncode.Size = new System.Drawing.Size(120, 100);
            this.buttonUploadEncode.TabIndex = 12;
            this.buttonUploadEncode.Text = "Загрузить картинку";
            this.buttonUploadEncode.UseVisualStyleBackColor = true;
            this.buttonUploadEncode.Click += new System.EventHandler(this.buttonUploadEncode_Click);
            // 
            // richTextBoxDecode
            // 
            this.richTextBoxDecode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxDecode.Location = new System.Drawing.Point(138, 271);
            this.richTextBoxDecode.Name = "richTextBoxDecode";
            this.richTextBoxDecode.ReadOnly = true;
            this.richTextBoxDecode.Size = new System.Drawing.Size(270, 210);
            this.richTextBoxDecode.TabIndex = 22;
            this.richTextBoxDecode.Text = "";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(12, 383);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(120, 100);
            this.buttonDecode.TabIndex = 21;
            this.buttonDecode.Text = "Декодировать";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxDecode
            // 
            this.pictureBoxDecode.Location = new System.Drawing.Point(414, 271);
            this.pictureBoxDecode.Name = "pictureBoxDecode";
            this.pictureBoxDecode.Size = new System.Drawing.Size(270, 210);
            this.pictureBoxDecode.TabIndex = 20;
            this.pictureBoxDecode.TabStop = false;
            // 
            // buttonUploadDecode
            // 
            this.buttonUploadDecode.Location = new System.Drawing.Point(12, 271);
            this.buttonUploadDecode.Name = "buttonUploadDecode";
            this.buttonUploadDecode.Size = new System.Drawing.Size(120, 100);
            this.buttonUploadDecode.TabIndex = 19;
            this.buttonUploadDecode.Text = "Загрузить картинку";
            this.buttonUploadDecode.UseVisualStyleBackColor = true;
            this.buttonUploadDecode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.clearToolStripMenuItem.Text = "Очистить всё";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxDecode);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.pictureBoxDecode);
            this.Controls.Add(this.buttonUploadDecode);
            this.Controls.Add(this.richTextBoxEncode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.pictureBoxEncode);
            this.Controls.Add(this.buttonUploadEncode);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecode)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxEncode;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.PictureBox pictureBoxEncode;
        private System.Windows.Forms.Button buttonUploadEncode;
        private System.Windows.Forms.RichTextBox richTextBoxDecode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.PictureBox pictureBoxDecode;
        private System.Windows.Forms.Button buttonUploadDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}