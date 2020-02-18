namespace MinionMaster
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
            this.chkHealth = new System.Windows.Forms.CheckBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.chkLevelUpEachMatch = new System.Windows.Forms.CheckBox();
            this.lblActualXp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotalXp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnemyHealthAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkHealth
            // 
            this.chkHealth.AutoSize = true;
            this.chkHealth.Location = new System.Drawing.Point(12, 104);
            this.chkHealth.Name = "chkHealth";
            this.chkHealth.Size = new System.Drawing.Size(57, 17);
            this.chkHealth.TabIndex = 17;
            this.chkHealth.Text = "Health";
            this.chkHealth.UseVisualStyleBackColor = true;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(103, 146);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(35, 13);
            this.lblHealth.TabIndex = 16;
            this.lblHealth.Text = "label1";
            // 
            // chkLevelUpEachMatch
            // 
            this.chkLevelUpEachMatch.AutoSize = true;
            this.chkLevelUpEachMatch.Location = new System.Drawing.Point(12, 72);
            this.chkLevelUpEachMatch.Name = "chkLevelUpEachMatch";
            this.chkLevelUpEachMatch.Size = new System.Drawing.Size(126, 17);
            this.chkLevelUpEachMatch.TabIndex = 15;
            this.chkLevelUpEachMatch.Text = "Level up each match";
            this.chkLevelUpEachMatch.UseVisualStyleBackColor = true;
            // 
            // lblActualXp
            // 
            this.lblActualXp.AutoSize = true;
            this.lblActualXp.Location = new System.Drawing.Point(168, 73);
            this.lblActualXp.Name = "lblActualXp";
            this.lblActualXp.Size = new System.Drawing.Size(35, 13);
            this.lblActualXp.TabIndex = 14;
            this.lblActualXp.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTotalXp
            // 
            this.lblTotalXp.AutoSize = true;
            this.lblTotalXp.Location = new System.Drawing.Point(218, 73);
            this.lblTotalXp.Name = "lblTotalXp";
            this.lblTotalXp.Size = new System.Drawing.Size(35, 13);
            this.lblTotalXp.TabIndex = 22;
            this.lblTotalXp.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "/";
            // 
            // txtEnemyHealthAddr
            // 
            this.txtEnemyHealthAddr.Location = new System.Drawing.Point(12, 146);
            this.txtEnemyHealthAddr.Name = "txtEnemyHealthAddr";
            this.txtEnemyHealthAddr.Size = new System.Drawing.Size(85, 20);
            this.txtEnemyHealthAddr.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnemyHealthAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalXp);
            this.Controls.Add(this.chkHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.chkLevelUpEachMatch);
            this.Controls.Add(this.lblActualXp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkHealth;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.CheckBox chkLevelUpEachMatch;
        private System.Windows.Forms.Label lblActualXp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTotalXp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnemyHealthAddr;
        private System.Windows.Forms.Label label1;
    }
}

