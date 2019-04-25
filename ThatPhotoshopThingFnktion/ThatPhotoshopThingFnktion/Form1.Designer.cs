namespace ThatPhotoshopThingFnktion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckboxSlowmode = new System.Windows.Forms.CheckBox();
            this.ButtonFilepath = new System.Windows.Forms.Button();
            this.TextboxSavename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(0, 26);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start Process";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(12, 52);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(85, 13);
            this.LabelStatus.TabIndex = 3;
            this.LabelStatus.Text = "Waiting For Files";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CheckboxSlowmode
            // 
            this.CheckboxSlowmode.AutoSize = true;
            this.CheckboxSlowmode.Location = new System.Drawing.Point(12, 68);
            this.CheckboxSlowmode.Name = "CheckboxSlowmode";
            this.CheckboxSlowmode.Size = new System.Drawing.Size(94, 17);
            this.CheckboxSlowmode.TabIndex = 5;
            this.CheckboxSlowmode.Text = "slow but pretty";
            this.CheckboxSlowmode.UseVisualStyleBackColor = true;
            this.CheckboxSlowmode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ButtonFilepath
            // 
            this.ButtonFilepath.Location = new System.Drawing.Point(0, 0);
            this.ButtonFilepath.Name = "ButtonFilepath";
            this.ButtonFilepath.Size = new System.Drawing.Size(75, 23);
            this.ButtonFilepath.TabIndex = 6;
            this.ButtonFilepath.Text = "Choose Files";
            this.ButtonFilepath.UseVisualStyleBackColor = true;
            this.ButtonFilepath.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextboxSavename
            // 
            this.TextboxSavename.Location = new System.Drawing.Point(6, 91);
            this.TextboxSavename.Name = "TextboxSavename";
            this.TextboxSavename.Size = new System.Drawing.Size(100, 20);
            this.TextboxSavename.TabIndex = 7;
            this.TextboxSavename.Text = "save name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 366);
            this.Controls.Add(this.TextboxSavename);
            this.Controls.Add(this.ButtonFilepath);
            this.Controls.Add(this.CheckboxSlowmode);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cloud Remover";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CheckboxSlowmode;
        private System.Windows.Forms.Button ButtonFilepath;
        private System.Windows.Forms.TextBox TextboxSavename;
    }
}

