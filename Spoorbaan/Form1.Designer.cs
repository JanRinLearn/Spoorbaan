namespace Spoorbaan
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
            this.TekenGrond = new System.Windows.Forms.Panel();
            this.stationRecht = new System.Windows.Forms.CheckBox();
            this.stationLinks = new System.Windows.Forms.CheckBox();
            this.overgang2 = new System.Windows.Forms.CheckBox();
            this.overgang1 = new System.Windows.Forms.CheckBox();
            this.storing = new System.Windows.Forms.CheckBox();
            this.TekenGrond.SuspendLayout();
            this.SuspendLayout();
            // 
            // TekenGrond
            // 
            this.TekenGrond.Controls.Add(this.stationRecht);
            this.TekenGrond.Controls.Add(this.stationLinks);
            this.TekenGrond.Controls.Add(this.overgang2);
            this.TekenGrond.Controls.Add(this.overgang1);
            this.TekenGrond.Controls.Add(this.storing);
            this.TekenGrond.Location = new System.Drawing.Point(13, 13);
            this.TekenGrond.Name = "TekenGrond";
            this.TekenGrond.Size = new System.Drawing.Size(1345, 724);
            this.TekenGrond.TabIndex = 0;
            this.TekenGrond.Paint += new System.Windows.Forms.PaintEventHandler(this.TekenGrond_Paint);
            // 
            // stationRecht
            // 
            this.stationRecht.AutoSize = true;
            this.stationRecht.Location = new System.Drawing.Point(17, 198);
            this.stationRecht.Name = "stationRecht";
            this.stationRecht.Size = new System.Drawing.Size(123, 17);
            this.stationRecht.TabIndex = 4;
            this.stationRecht.Text = "Station Recht Groen";
            this.stationRecht.UseVisualStyleBackColor = true;
            // 
            // stationLinks
            // 
            this.stationLinks.AutoSize = true;
            this.stationLinks.Location = new System.Drawing.Point(17, 174);
            this.stationLinks.Name = "stationLinks";
            this.stationLinks.Size = new System.Drawing.Size(119, 17);
            this.stationLinks.TabIndex = 3;
            this.stationLinks.Text = "Station Links Groen";
            this.stationLinks.UseVisualStyleBackColor = true;
            // 
            // overgang2
            // 
            this.overgang2.AutoSize = true;
            this.overgang2.Location = new System.Drawing.Point(17, 109);
            this.overgang2.Name = "overgang2";
            this.overgang2.Size = new System.Drawing.Size(82, 17);
            this.overgang2.TabIndex = 2;
            this.overgang2.Text = "Overgang 2";
            this.overgang2.UseVisualStyleBackColor = true;
            // 
            // overgang1
            // 
            this.overgang1.AutoSize = true;
            this.overgang1.Location = new System.Drawing.Point(17, 86);
            this.overgang1.Name = "overgang1";
            this.overgang1.Size = new System.Drawing.Size(82, 17);
            this.overgang1.TabIndex = 1;
            this.overgang1.Text = "Overgang 1";
            this.overgang1.UseVisualStyleBackColor = true;
            this.overgang1.CheckedChanged += new System.EventHandler(this.overgang1_CheckedChanged);
            // 
            // storing
            // 
            this.storing.AutoSize = true;
            this.storing.Location = new System.Drawing.Point(17, 32);
            this.storing.Name = "storing";
            this.storing.Size = new System.Drawing.Size(59, 17);
            this.storing.TabIndex = 0;
            this.storing.Text = "Storing";
            this.storing.UseVisualStyleBackColor = true;
            this.storing.CheckedChanged += new System.EventHandler(this.storing_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.TekenGrond);
            this.Name = "Form1";
            this.Text = "Spoorbaan";
            this.TekenGrond.ResumeLayout(false);
            this.TekenGrond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TekenGrond;
        private System.Windows.Forms.CheckBox stationRecht;
        private System.Windows.Forms.CheckBox stationLinks;
        private System.Windows.Forms.CheckBox overgang2;
        private System.Windows.Forms.CheckBox overgang1;
        private System.Windows.Forms.CheckBox storing;
    }
}

