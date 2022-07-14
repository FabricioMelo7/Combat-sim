namespace Combat_sim
{
    partial class combatTable
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.attack1 = new System.Windows.Forms.Button();
            this.attack2 = new System.Windows.Forms.Button();
            this.attack3 = new System.Windows.Forms.Button();
            this.attack4 = new System.Windows.Forms.Button();
            this.characterName = new System.Windows.Forms.TextBox();
            this.enemyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(236, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 165);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            // 
            // attack1
            // 
            this.attack1.Location = new System.Drawing.Point(27, 277);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(81, 38);
            this.attack1.TabIndex = 1;
            this.attack1.Text = "Attack 1";
            this.attack1.UseVisualStyleBackColor = true;
            // 
            // attack2
            // 
            this.attack2.Location = new System.Drawing.Point(128, 277);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(81, 38);
            this.attack2.TabIndex = 2;
            this.attack2.Text = "Attack 2";
            this.attack2.UseVisualStyleBackColor = true;
            // 
            // attack3
            // 
            this.attack3.Location = new System.Drawing.Point(27, 347);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(81, 38);
            this.attack3.TabIndex = 3;
            this.attack3.Text = "Attack 3";
            this.attack3.UseVisualStyleBackColor = true;
            // 
            // attack4
            // 
            this.attack4.Location = new System.Drawing.Point(128, 347);
            this.attack4.Name = "attack4";
            this.attack4.Size = new System.Drawing.Size(81, 38);
            this.attack4.TabIndex = 4;
            this.attack4.Text = "Attack 4";
            this.attack4.UseVisualStyleBackColor = true;
            // 
            // characterName
            // 
            this.characterName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.ForeColor = System.Drawing.Color.Chartreuse;
            this.characterName.Location = new System.Drawing.Point(35, 206);
            this.characterName.Multiline = true;
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(174, 50);
            this.characterName.TabIndex = 5;
            // 
            // enemyName
            // 
            this.enemyName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.enemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyName.ForeColor = System.Drawing.Color.Chartreuse;
            this.enemyName.Location = new System.Drawing.Point(602, 206);
            this.enemyName.Multiline = true;
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(174, 50);
            this.enemyName.TabIndex = 6;
            // 
            // combatTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.enemyName);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.attack4);
            this.Controls.Add(this.attack3);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.textBox1);
            this.Name = "combatTable";
            this.Text = "CombatSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Button attack2;
        private System.Windows.Forms.Button attack3;
        private System.Windows.Forms.Button attack4;
        private System.Windows.Forms.TextBox characterName;
        private System.Windows.Forms.TextBox enemyName;
    }
}

