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
            this.components = new System.ComponentModel.Container();
            this.TekenGrond = new System.Windows.Forms.Panel();
            this.overgang2 = new System.Windows.Forms.Button();
            this.overgang1 = new System.Windows.Forms.Button();
            this.stationButton = new System.Windows.Forms.Button();
            this.storing = new System.Windows.Forms.CheckBox();
            this.overgangTimer = new System.Windows.Forms.Timer(this.components);
            this.storingTimer = new System.Windows.Forms.Timer(this.components);
            this.TekenGrond.SuspendLayout();
            this.SuspendLayout();
            // 
            // TekenGrond
            // 
            this.TekenGrond.Controls.Add(this.overgang2);
            this.TekenGrond.Controls.Add(this.overgang1);
            this.TekenGrond.Controls.Add(this.stationButton);
            this.TekenGrond.Controls.Add(this.storing);
            this.TekenGrond.Location = new System.Drawing.Point(13, 13);
            this.TekenGrond.Name = "TekenGrond";
            this.TekenGrond.Size = new System.Drawing.Size(1345, 724);
            this.TekenGrond.TabIndex = 0;
            this.TekenGrond.Paint += new System.Windows.Forms.PaintEventHandler(this.TekenGrond_Paint);
            // 
            // overgang2
            // 
            this.overgang2.Location = new System.Drawing.Point(163, 683);
            this.overgang2.Name = "overgang2";
            this.overgang2.Size = new System.Drawing.Size(140, 23);
            this.overgang2.TabIndex = 5;
            this.overgang2.Text = "Toggel Overgang Rechts";
            this.overgang2.UseVisualStyleBackColor = true;
            this.overgang2.Click += new System.EventHandler(this.overgang2_Click);
            // 
            // overgang1
            // 
            this.overgang1.Location = new System.Drawing.Point(17, 683);
            this.overgang1.Name = "overgang1";
            this.overgang1.Size = new System.Drawing.Size(140, 23);
            this.overgang1.TabIndex = 4;
            this.overgang1.Text = "Toggel Overgang Links";
            this.overgang1.UseVisualStyleBackColor = true;
            this.overgang1.Click += new System.EventHandler(this.overgang1_Click);
            // 
            // stationButton
            // 
            this.stationButton.Location = new System.Drawing.Point(358, 683);
            this.stationButton.Name = "stationButton";
            this.stationButton.Size = new System.Drawing.Size(140, 23);
            this.stationButton.TabIndex = 3;
            this.stationButton.Text = "Wissel Lichten Station";
            this.stationButton.UseVisualStyleBackColor = true;
            this.stationButton.Click += new System.EventHandler(this.stationButton_Click);
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
            // overgangTimer
            // 
            this.overgangTimer.Interval = 1000;
            // 
            // storingTimer
            // 
            this.storingTimer.Interval = 1000;
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
        private System.Windows.Forms.CheckBox storing;
        private System.Windows.Forms.Timer overgangTimer;
        private System.Windows.Forms.Timer storingTimer;
        private System.Windows.Forms.Button stationButton;
        private System.Windows.Forms.Button overgang2;
        private System.Windows.Forms.Button overgang1;
    }
}

