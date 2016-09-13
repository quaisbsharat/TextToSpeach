namespace TextToSpeach
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelectVoice = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.Button();
            this.txtResume = new System.Windows.Forms.Button();
            this.txtPause = new System.Windows.Forms.Button();
            this.txtSpeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cboSelectVoice
            // 
            this.cboSelectVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectVoice.FormattingEnabled = true;
            this.cboSelectVoice.Items.AddRange(new object[] {
            "NotSet",
            "Male",
            "Female",
            "Natural"});
            this.cboSelectVoice.Location = new System.Drawing.Point(53, 6);
            this.cboSelectVoice.Name = "cboSelectVoice";
            this.cboSelectVoice.Size = new System.Drawing.Size(121, 21);
            this.cboSelectVoice.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 54);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(510, 322);
            this.txtContent.TabIndex = 2;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(447, 402);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(75, 23);
            this.txtSave.TabIndex = 3;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(366, 402);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(75, 23);
            this.txtResume.TabIndex = 3;
            this.txtResume.Text = "Resume";
            this.txtResume.UseVisualStyleBackColor = true;
            this.txtResume.Click += new System.EventHandler(this.txtResume_Click);
            // 
            // txtPause
            // 
            this.txtPause.Location = new System.Drawing.Point(285, 402);
            this.txtPause.Name = "txtPause";
            this.txtPause.Size = new System.Drawing.Size(75, 23);
            this.txtPause.TabIndex = 3;
            this.txtPause.Text = "Pause";
            this.txtPause.UseVisualStyleBackColor = true;
            this.txtPause.Click += new System.EventHandler(this.txtPause_Click);
            // 
            // txtSpeak
            // 
            this.txtSpeak.Location = new System.Drawing.Point(204, 402);
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.Size = new System.Drawing.Size(75, 23);
            this.txtSpeak.TabIndex = 3;
            this.txtSpeak.Text = "Speak";
            this.txtSpeak.UseVisualStyleBackColor = true;
            this.txtSpeak.Click += new System.EventHandler(this.txtSpeak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 437);
            this.Controls.Add(this.txtSpeak);
            this.Controls.Add(this.txtPause);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cboSelectVoice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectVoice;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Button txtResume;
        private System.Windows.Forms.Button txtPause;
        private System.Windows.Forms.Button txtSpeak;
    }
}

