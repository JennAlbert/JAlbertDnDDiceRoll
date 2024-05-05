namespace DnDDiceRollTwo
{
    partial class DnDDiceRoll
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dFourDiceRoll = new Button();
            dSixDiceRoll = new Button();
            dEightDiceRoll = new Button();
            dTenDiceRoll = new Button();
            dTwelveDiceRoll = new Button();
            dTwentyDiceRoll = new Button();
            diceRollResult = new Label();
            SuspendLayout();
            // 
            // dFourDiceRoll
            // 
            dFourDiceRoll.Location = new Point(86, 90);
            dFourDiceRoll.Name = "dFourDiceRoll";
            dFourDiceRoll.Size = new Size(94, 29);
            dFourDiceRoll.TabIndex = 0;
            dFourDiceRoll.Text = "D4";
            dFourDiceRoll.UseVisualStyleBackColor = true;
            dFourDiceRoll.Click += dFourDiceRoll_Click;
            // 
            // dSixDiceRoll
            // 
            dSixDiceRoll.Location = new Point(241, 90);
            dSixDiceRoll.Name = "dSixDiceRoll";
            dSixDiceRoll.Size = new Size(94, 29);
            dSixDiceRoll.TabIndex = 1;
            dSixDiceRoll.Text = "D6";
            dSixDiceRoll.UseVisualStyleBackColor = true;
            dSixDiceRoll.Click += dSixDiceRoll_Click;
            // 
            // dEightDiceRoll
            // 
            dEightDiceRoll.Location = new Point(419, 90);
            dEightDiceRoll.Name = "dEightDiceRoll";
            dEightDiceRoll.Size = new Size(94, 29);
            dEightDiceRoll.TabIndex = 2;
            dEightDiceRoll.Text = "D8";
            dEightDiceRoll.UseVisualStyleBackColor = true;
            dEightDiceRoll.Click += dEightDiceRoll_Click;
            // 
            // dTenDiceRoll
            // 
            dTenDiceRoll.Location = new Point(617, 90);
            dTenDiceRoll.Name = "dTenDiceRoll";
            dTenDiceRoll.Size = new Size(94, 29);
            dTenDiceRoll.TabIndex = 3;
            dTenDiceRoll.Text = "D10";
            dTenDiceRoll.UseVisualStyleBackColor = true;
            dTenDiceRoll.Click += dTenDiceRoll_Click;
            // 
            // dTwelveDiceRoll
            // 
            dTwelveDiceRoll.Location = new Point(174, 301);
            dTwelveDiceRoll.Name = "dTwelveDiceRoll";
            dTwelveDiceRoll.Size = new Size(94, 29);
            dTwelveDiceRoll.TabIndex = 4;
            dTwelveDiceRoll.Text = "D12";
            dTwelveDiceRoll.UseVisualStyleBackColor = true;
            dTwelveDiceRoll.Click += dTwelveDiceRoll_Click;
            // 
            // dTwentyDiceRoll
            // 
            dTwentyDiceRoll.Location = new Point(524, 301);
            dTwentyDiceRoll.Name = "dTwentyDiceRoll";
            dTwentyDiceRoll.Size = new Size(94, 29);
            dTwentyDiceRoll.TabIndex = 5;
            dTwentyDiceRoll.Text = "D20";
            dTwentyDiceRoll.UseVisualStyleBackColor = true;
            dTwentyDiceRoll.Click += dTwentyDiceRoll_Click;
            // 
            // diceRollResult
            // 
            diceRollResult.AutoSize = true;
            diceRollResult.Font = new Font("Segoe Print", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diceRollResult.Location = new Point(138, 140);
            diceRollResult.Name = "diceRollResult";
            diceRollResult.Size = new Size(543, 140);
            diceRollResult.TabIndex = 6;
            diceRollResult.Text = "You Rolled...";
            diceRollResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DnDDiceRoll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(diceRollResult);
            Controls.Add(dTwentyDiceRoll);
            Controls.Add(dTwelveDiceRoll);
            Controls.Add(dTenDiceRoll);
            Controls.Add(dEightDiceRoll);
            Controls.Add(dSixDiceRoll);
            Controls.Add(dFourDiceRoll);
            Name = "DnDDiceRoll";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dFourDiceRoll;
        private Button dSixDiceRoll;
        private Button dEightDiceRoll;
        private Button dTenDiceRoll;
        private Button dTwelveDiceRoll;
        private Button dTwentyDiceRoll;
        private Label diceRollResult;
    }
}
