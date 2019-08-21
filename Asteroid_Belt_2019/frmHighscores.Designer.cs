namespace Asteroid_Belt_2019
{
    partial class frmHighscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighscores));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxLives = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerLives = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(134, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(317, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lives:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxName
            // 
            this.listBoxName.BackColor = System.Drawing.Color.Black;
            this.listBoxName.ForeColor = System.Drawing.Color.Lime;
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(117, 35);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(80, 147);
            this.listBoxName.TabIndex = 2;
            // 
            // listBoxLives
            // 
            this.listBoxLives.BackColor = System.Drawing.Color.Black;
            this.listBoxLives.ForeColor = System.Drawing.Color.Lime;
            this.listBoxLives.FormattingEnabled = true;
            this.listBoxLives.Location = new System.Drawing.Point(297, 34);
            this.listBoxLives.Name = "listBoxLives";
            this.listBoxLives.Size = new System.Drawing.Size(80, 147);
            this.listBoxLives.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(158, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(158, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Your Lives:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayerName.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayerName.Image")));
            this.lblPlayerName.Location = new System.Drawing.Point(283, 262);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Name";
            // 
            // lblPlayerLives
            // 
            this.lblPlayerLives.AutoSize = true;
            this.lblPlayerLives.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayerLives.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayerLives.Image")));
            this.lblPlayerLives.Location = new System.Drawing.Point(283, 318);
            this.lblPlayerLives.Name = "lblPlayerLives";
            this.lblPlayerLives.Size = new System.Drawing.Size(32, 13);
            this.lblPlayerLives.TabIndex = 7;
            this.lblPlayerLives.Text = "Lives";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Lime;
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.Location = new System.Drawing.Point(158, 376);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(211, 207);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Exit";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // frmHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPlayerLives);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxLives);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHighscores";
            this.Text = "frmHighscores";
            this.Load += new System.EventHandler(this.frmHighscores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxLives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerLives;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReturn;
    }
}