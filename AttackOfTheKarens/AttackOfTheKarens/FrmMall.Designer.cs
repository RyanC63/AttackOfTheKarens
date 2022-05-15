namespace AttackOfTheKarens {
  partial class FrmMall {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panMall = new System.Windows.Forms.Panel();
            this.tmrKarenSpawner = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateKarens = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveOwner = new System.Windows.Forms.Timer(this.components);
            this.lblMoneySaved = new System.Windows.Forms.Label();
            this.lblMoneySavedLabel = new System.Windows.Forms.Label();
            this.tmrUpdateGame = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panMall
            // 
            this.panMall.BackColor = System.Drawing.Color.Transparent;
            this.panMall.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.mall_bg;
            this.panMall.Location = new System.Drawing.Point(14, 16);
            this.panMall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panMall.Name = "panMall";
            this.panMall.Size = new System.Drawing.Size(641, 719);
            this.panMall.TabIndex = 0;
            // 
            // tmrKarenSpawner
            // 
            this.tmrKarenSpawner.Tick += new System.EventHandler(this.tmrKarenSpawner_Tick);
            // 
            // tmrUpdateKarens
            // 
            this.tmrUpdateKarens.Enabled = true;
            this.tmrUpdateKarens.Interval = 40;
            this.tmrUpdateKarens.Tick += new System.EventHandler(this.tmrUpdateKarens_Tick);
            // 
            // tmrMoveOwner
            // 
            this.tmrMoveOwner.Enabled = true;
            this.tmrMoveOwner.Interval = 120;
            this.tmrMoveOwner.Tick += new System.EventHandler(this.tmrMoveOwner_Tick);
            // 
            // lblMoneySaved
            // 
            this.lblMoneySaved.AutoSize = true;
            this.lblMoneySaved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySaved.Location = new System.Drawing.Point(1229, -1);
            this.lblMoneySaved.Name = "lblMoneySaved";
            this.lblMoneySaved.Size = new System.Drawing.Size(119, 41);
            this.lblMoneySaved.TabIndex = 1;
            this.lblMoneySaved.Text = "$ 00.00";
            this.lblMoneySaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoneySavedLabel
            // 
            this.lblMoneySavedLabel.AutoSize = true;
            this.lblMoneySavedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySavedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySavedLabel.Location = new System.Drawing.Point(1048, 8);
            this.lblMoneySavedLabel.Name = "lblMoneySavedLabel";
            this.lblMoneySavedLabel.Size = new System.Drawing.Size(174, 32);
            this.lblMoneySavedLabel.TabIndex = 2;
            this.lblMoneySavedLabel.Text = "Money Saved:";
            this.lblMoneySavedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrUpdateGame
            // 
            this.tmrUpdateGame.Enabled = true;
            this.tmrUpdateGame.Tick += new System.EventHandler(this.tmrUpdateGame_Tick);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(550, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Money gained is increased to $10.95: Cost $50";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Money gained is increased to $15.95: Cost $150";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Money gained is increased $20.95: Cost $300";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Money gained is increased to $25.95: Cost $750";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(550, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "Money gained is increased to $30.95: Cost $1200";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 931);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMoneySavedLabel);
            this.Controls.Add(this.lblMoneySaved);
            this.Controls.Add(this.panMall);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attack of the Karens!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMall_FormClosed);
            this.Load += new System.EventHandler(this.FrmMall_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMall_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panMall;
    private System.Windows.Forms.Timer tmrKarenSpawner;
    private System.Windows.Forms.Timer tmrUpdateKarens;
    private System.Windows.Forms.Timer tmrMoveOwner;
    private System.Windows.Forms.Label lblMoneySaved;
    private System.Windows.Forms.Label lblMoneySavedLabel;
    private System.Windows.Forms.Timer tmrUpdateGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
