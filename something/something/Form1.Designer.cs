
namespace something
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
            this.txtammo = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.Label();
            this.txthealth = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.playerbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerbox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtammo
            // 
            this.txtammo.AutoSize = true;
            this.txtammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtammo.ForeColor = System.Drawing.Color.White;
            this.txtammo.Location = new System.Drawing.Point(12, 9);
            this.txtammo.Name = "txtammo";
            this.txtammo.Size = new System.Drawing.Size(107, 29);
            this.txtammo.TabIndex = 0;
            this.txtammo.Text = "Ammo:0";

            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtscore.ForeColor = System.Drawing.Color.White;
            this.txtscore.Location = new System.Drawing.Point(346, 9);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(85, 29);
            this.txtscore.TabIndex = 0;
            this.txtscore.Text = "Kills:0";
            // 
            // txthealth
            // 
            this.txthealth.AutoSize = true;
            this.txthealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txthealth.ForeColor = System.Drawing.Color.White;
            this.txthealth.Location = new System.Drawing.Point(584, 9);
            this.txthealth.Name = "txthealth";
            this.txthealth.Size = new System.Drawing.Size(95, 29);
            this.txthealth.TabIndex = 0;
            this.txthealth.Text = "Health:";
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(708, 14);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(202, 23);
            this.healthbar.TabIndex = 1;
            // 
            // playerbox
            // 
            this.playerbox.Location = new System.Drawing.Point(389, 273);
            this.playerbox.Name = "playerbox";
            this.playerbox.Size = new System.Drawing.Size(75, 95);
            this.playerbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerbox.TabIndex = 5;
            this.playerbox.TabStop = false;
            this.playerbox.Tag = "player";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(922, 653);
            this.Controls.Add(this.playerbox);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.txthealth);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtammo);
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.playerbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtammo;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label txthealth;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.PictureBox playerbox;
    }
}

