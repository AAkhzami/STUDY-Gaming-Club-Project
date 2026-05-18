namespace Gaming_Club_Project
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
            this.ctrlComputerGaming1 = new Gaming_Club_Project.ctrlComputerGaming();
            this.SuspendLayout();
            // 
            // ctrlComputerGaming1
            // 
            this.ctrlComputerGaming1.BackColor = System.Drawing.SystemColors.MenuText;
            this.ctrlComputerGaming1.Location = new System.Drawing.Point(303, 92);
            this.ctrlComputerGaming1.Name = "ctrlComputerGaming1";
            this.ctrlComputerGaming1.PlayerName = "Player";
            this.ctrlComputerGaming1.PricePerHour = 0.5F;
            this.ctrlComputerGaming1.Size = new System.Drawing.Size(360, 240);
            this.ctrlComputerGaming1.TabIndex = 0;
            this.ctrlComputerGaming1.TableTitle = "Computer Gaming";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 632);
            this.Controls.Add(this.ctrlComputerGaming1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlComputerGaming ctrlComputerGaming1;
    }
}

