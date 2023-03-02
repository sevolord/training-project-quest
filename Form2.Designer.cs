namespace Quest
{
    partial class Game
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
            this.RTBTextField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LHeroName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LHealth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LDamage = new System.Windows.Forms.Label();
            this.TBActionField = new System.Windows.Forms.TextBox();
            this.BStartAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBTextField
            // 
            this.RTBTextField.Location = new System.Drawing.Point(12, 39);
            this.RTBTextField.Name = "RTBTextField";
            this.RTBTextField.Size = new System.Drawing.Size(412, 186);
            this.RTBTextField.TabIndex = 0;
            this.RTBTextField.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Герой:";
            // 
            // LHeroName
            // 
            this.LHeroName.AutoSize = true;
            this.LHeroName.Location = new System.Drawing.Point(61, 9);
            this.LHeroName.Name = "LHeroName";
            this.LHeroName.Size = new System.Drawing.Size(65, 15);
            this.LHeroName.TabIndex = 2;
            this.LHeroName.Text = "HeroName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Уровень здоровья: ";
            // 
            // LHealth
            // 
            this.LHealth.AutoSize = true;
            this.LHealth.Location = new System.Drawing.Point(250, 9);
            this.LHealth.Name = "LHealth";
            this.LHealth.Size = new System.Drawing.Size(25, 15);
            this.LHealth.TabIndex = 4;
            this.LHealth.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Уровень атаки:";
            // 
            // LDamage
            // 
            this.LDamage.AutoSize = true;
            this.LDamage.Location = new System.Drawing.Point(399, 9);
            this.LDamage.Name = "LDamage";
            this.LDamage.Size = new System.Drawing.Size(25, 15);
            this.LDamage.TabIndex = 6;
            this.LDamage.Text = "100";
            // 
            // TBActionField
            // 
            this.TBActionField.Location = new System.Drawing.Point(12, 231);
            this.TBActionField.Name = "TBActionField";
            this.TBActionField.Size = new System.Drawing.Size(319, 23);
            this.TBActionField.TabIndex = 7;
            // 
            // BStartAction
            // 
            this.BStartAction.Location = new System.Drawing.Point(349, 231);
            this.BStartAction.Name = "BStartAction";
            this.BStartAction.Size = new System.Drawing.Size(75, 23);
            this.BStartAction.TabIndex = 8;
            this.BStartAction.Text = "Ввести";
            this.BStartAction.UseVisualStyleBackColor = true;
            this.BStartAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 265);
            this.Controls.Add(this.BStartAction);
            this.Controls.Add(this.TBActionField);
            this.Controls.Add(this.LDamage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LHeroName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBTextField);
            this.Name = "Game";
            this.Text = "Текстовой квест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RTBTextField;
        private Label label1;
        private Label LHeroName;
        private Label label2;
        private Label LHealth;
        private Label label4;
        private Label LDamage;
        private TextBox TBActionField;
        private Button BStartAction;
    }
}