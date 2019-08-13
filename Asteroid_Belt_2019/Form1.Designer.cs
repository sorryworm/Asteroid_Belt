namespace Asteroid_Belt_2019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrAsteroid = new System.Windows.Forms.Timer(this.components);
            this.tmrShip = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrPlasmaRegeneration = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblReload = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Cyan;
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlGame.Location = new System.Drawing.Point(91, 149);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(500, 400);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            this.pnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asteroid Belt";
            // 
            // tmrAsteroid
            // 
            this.tmrAsteroid.Enabled = true;
            this.tmrAsteroid.Tick += new System.EventHandler(this.tmrAsteroid_Tick);
            // 
            // tmrShip
            // 
            this.tmrShip.Enabled = true;
            this.tmrShip.Interval = 50;
            this.tmrShip.Tick += new System.EventHandler(this.tmrShip_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(491, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScore.Image = ((System.Drawing.Image)(resources.GetObject("lblScore.Image")));
            this.lblScore.Location = new System.Drawing.Point(99, 92);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(88, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(200, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lives:";
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLives.Image = ((System.Drawing.Image)(resources.GetObject("txtLives.Image")));
            this.txtLives.Location = new System.Drawing.Point(209, 92);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(19, 13);
            this.txtLives.TabIndex = 2;
            this.txtLives.Text = "10";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStart
            // 
            this.mnuStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuStart.BackgroundImage")));
            this.mnuStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStart.ForeColor = System.Drawing.Color.Lime;
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(49, 21);
            this.mnuStart.Text = "Start";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuStop.BackgroundImage")));
            this.mnuStop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStop.ForeColor = System.Drawing.Color.Lime;
            this.mnuStop.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuStop.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(48, 21);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(601, 83);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Confirm";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tmrShoot
            // 
            this.tmrShoot.Enabled = true;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrPlasmaRegeneration
            // 
            this.tmrPlasmaRegeneration.Interval = 1000;
            this.tmrPlasmaRegeneration.Tick += new System.EventHandler(this.tmrPlasmaRegenration_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(321, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plasma Cannon:";
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblReload.Image = ((System.Drawing.Image)(resources.GetObject("lblReload.Image")));
            this.lblReload.Location = new System.Drawing.Point(343, 92);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(38, 13);
            this.lblReload.TabIndex = 9;
            this.lblReload.Text = "Ready";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Lime;
            this.lblLevel.Image = ((System.Drawing.Image)(resources.GetObject("lblLevel.Image")));
            this.lblLevel.Location = new System.Drawing.Point(553, 25);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 24);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Level 1";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(491, 111);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(181, 23);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check for Highscore";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblReload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Asteroid Belt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrAsteroid;
        private System.Windows.Forms.Timer tmrShip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Timer tmrPlasmaRegeneration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReload;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnCheck;
    }
}

