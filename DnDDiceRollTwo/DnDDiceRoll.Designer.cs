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
            dFourDiceRoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dFourDiceRoll.Location = new Point(147, 40);
            dFourDiceRoll.Name = "dFourDiceRoll";
            dFourDiceRoll.Size = new Size(94, 79);
            dFourDiceRoll.TabIndex = 0;
            dFourDiceRoll.Text = "D4";
            dFourDiceRoll.UseVisualStyleBackColor = true;
            dFourDiceRoll.Click += dFourDiceRoll_Click;
            // 
            // dSixDiceRoll
            // 
            dSixDiceRoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dSixDiceRoll.Location = new Point(351, 40);
            dSixDiceRoll.Name = "dSixDiceRoll";
            dSixDiceRoll.Size = new Size(94, 79);
            dSixDiceRoll.TabIndex = 1;
            dSixDiceRoll.Text = "D6";
            dSixDiceRoll.UseVisualStyleBackColor = true;
            dSixDiceRoll.Click += dSixDiceRoll_Click;
            // 
            // dEightDiceRoll
            // 
            dEightDiceRoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dEightDiceRoll.Location = new Point(524, 40);
            dEightDiceRoll.Name = "dEightDiceRoll";
            dEightDiceRoll.Size = new Size(94, 79);
            dEightDiceRoll.TabIndex = 2;
            dEightDiceRoll.Text = "D8";
            dEightDiceRoll.UseVisualStyleBackColor = true;
            dEightDiceRoll.Click += dEightDiceRoll_Click;
            // 
            // dTenDiceRoll
            // 
            dTenDiceRoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTenDiceRoll.Location = new Point(147, 282);
            dTenDiceRoll.Name = "dTenDiceRoll";
            dTenDiceRoll.Size = new Size(94, 85);
            dTenDiceRoll.TabIndex = 3;
            dTenDiceRoll.Text = "D10";
            dTenDiceRoll.UseVisualStyleBackColor = true;
            dTenDiceRoll.Click += dTenDiceRoll_Click;
            // 
            // dTwelveDiceRoll
            // 
            dTwelveDiceRoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTwelveDiceRoll.Location = new Point(351, 282);
            dTwelveDiceRoll.Name = "dTwelveDiceRoll";
            dTwelveDiceRoll.Size = new Size(94, 87);
            dTwelveDiceRoll.TabIndex = 4;
            dTwelveDiceRoll.Text = "D12";
            dTwelveDiceRoll.UseVisualStyleBackColor = true;
            dTwelveDiceRoll.Click += dTwelveDiceRoll_Click;
            // 
            // dTwentyDiceRoll
            // 
            dTwentyDiceRoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTwentyDiceRoll.Location = new Point(524, 283);
            dTwentyDiceRoll.Name = "dTwentyDiceRoll";
            dTwentyDiceRoll.Size = new Size(94, 84);
            dTwentyDiceRoll.TabIndex = 5;
            dTwentyDiceRoll.Text = "D20";
            dTwentyDiceRoll.UseVisualStyleBackColor = true;
            dTwentyDiceRoll.Click += dTwentyDiceRoll_Click;
            // 
            // diceRollResult
            // 
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
