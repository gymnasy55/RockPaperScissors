namespace RockPaperScissorsTest
{
    partial class MainGameForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlAI = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtAI = new System.Windows.Forms.TextBox();
            this.lblAI = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlUser.SuspendLayout();
            this.pnlAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(247, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Choose your variant";
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors"});
            this.cmbUser.Location = new System.Drawing.Point(9, 43);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(242, 31);
            this.cmbUser.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(9, 101);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(242, 50);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.ForeColor = System.Drawing.Color.Red;
            this.lblCounter.Location = new System.Drawing.Point(205, 167);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 90);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Visible = false;
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.TmrCounter_Tick);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Controls.Add(this.cmbUser);
            this.pnlUser.Controls.Add(this.btnGo);
            this.pnlUser.Location = new System.Drawing.Point(12, 23);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(254, 188);
            this.pnlUser.TabIndex = 4;
            // 
            // pnlAI
            // 
            this.pnlAI.Controls.Add(this.btnRestart);
            this.pnlAI.Controls.Add(this.lblResult);
            this.pnlAI.Controls.Add(this.txtAI);
            this.pnlAI.Controls.Add(this.lblAI);
            this.pnlAI.Location = new System.Drawing.Point(128, 112);
            this.pnlAI.Name = "pnlAI";
            this.pnlAI.Size = new System.Drawing.Size(261, 265);
            this.pnlAI.TabIndex = 5;
            this.pnlAI.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(15, 102);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(214, 49);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "YOU LOSE!";
            // 
            // txtAI
            // 
            this.txtAI.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAI.Location = new System.Drawing.Point(8, 44);
            this.txtAI.Name = "txtAI";
            this.txtAI.ReadOnly = true;
            this.txtAI.Size = new System.Drawing.Size(221, 30);
            this.txtAI.TabIndex = 4;
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAI.Location = new System.Drawing.Point(3, 0);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(226, 25);
            this.lblAI.TabIndex = 3;
            this.lblAI.Text = "Opponent showed";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(8, 178);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(221, 44);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "AGAIN!";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 320);
            this.Controls.Add(this.pnlAI);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.lblCounter);
            this.Name = "MainGameForm";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameForm_FormClosing);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlAI.ResumeLayout(false);
            this.pnlAI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlAI;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.TextBox txtAI;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRestart;
    }
}