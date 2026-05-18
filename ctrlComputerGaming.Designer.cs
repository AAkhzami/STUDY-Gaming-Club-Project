namespace Gaming_Club_Project
{
    partial class ctrlComputerGaming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbPCTable = new System.Windows.Forms.GroupBox();
            this.pbOptions = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.gbPCTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPCTable
            // 
            this.gbPCTable.BackColor = System.Drawing.SystemColors.MenuText;
            this.gbPCTable.Controls.Add(this.pbOptions);
            this.gbPCTable.Controls.Add(this.lblTime);
            this.gbPCTable.Controls.Add(this.btnEnd);
            this.gbPCTable.Controls.Add(this.btnStart);
            this.gbPCTable.Controls.Add(this.lblPlayerName);
            this.gbPCTable.Controls.Add(this.pictureBox1);
            this.gbPCTable.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPCTable.ForeColor = System.Drawing.Color.White;
            this.gbPCTable.Location = new System.Drawing.Point(3, 3);
            this.gbPCTable.Name = "gbPCTable";
            this.gbPCTable.Size = new System.Drawing.Size(354, 234);
            this.gbPCTable.TabIndex = 0;
            this.gbPCTable.TabStop = false;
            this.gbPCTable.Text = "PC";
            // 
            // pbOptions
            // 
            this.pbOptions.Image = global::Gaming_Club_Project.Properties.Resources.option;
            this.pbOptions.Location = new System.Drawing.Point(314, 25);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(18, 18);
            this.pbOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOptions.TabIndex = 7;
            this.pbOptions.TabStop = false;
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(118, 195);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 33);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(215, 120);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(117, 48);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(215, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 48);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(141, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(78, 25);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Player";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gaming_Club_Project.Properties.Resources.computer_game;
            this.pictureBox1.Location = new System.Drawing.Point(15, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayTimer
            // 
            this.PlayTimer.Interval = 10;
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
            // 
            // ctrlComputerGaming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.Controls.Add(this.gbPCTable);
            this.Name = "ctrlComputerGaming";
            this.Size = new System.Drawing.Size(360, 240);
            this.gbPCTable.ResumeLayout(false);
            this.gbPCTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPCTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.PictureBox pbOptions;
    }
}
