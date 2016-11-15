namespace DragRacing
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
            this.light1Row1 = new System.Windows.Forms.Label();
            this.light2Row1 = new System.Windows.Forms.Label();
            this.light2Row2 = new System.Windows.Forms.Label();
            this.light1Row2 = new System.Windows.Forms.Label();
            this.light2Row3 = new System.Windows.Forms.Label();
            this.light1Row3 = new System.Windows.Forms.Label();
            this.greenLight2 = new System.Windows.Forms.Label();
            this.greenLight1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reactionLabel = new System.Windows.Forms.Label();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // light1Row1
            // 
            this.light1Row1.BackColor = System.Drawing.Color.DimGray;
            this.light1Row1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.light1Row1.Location = new System.Drawing.Point(24, 32);
            this.light1Row1.Name = "light1Row1";
            this.light1Row1.Size = new System.Drawing.Size(40, 40);
            this.light1Row1.TabIndex = 0;
            // 
            // light2Row1
            // 
            this.light2Row1.BackColor = System.Drawing.Color.DimGray;
            this.light2Row1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.light2Row1.Location = new System.Drawing.Point(70, 32);
            this.light2Row1.Name = "light2Row1";
            this.light2Row1.Size = new System.Drawing.Size(40, 40);
            this.light2Row1.TabIndex = 1;
            // 
            // light2Row2
            // 
            this.light2Row2.BackColor = System.Drawing.Color.DimGray;
            this.light2Row2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.light2Row2.Location = new System.Drawing.Point(70, 86);
            this.light2Row2.Name = "light2Row2";
            this.light2Row2.Size = new System.Drawing.Size(40, 40);
            this.light2Row2.TabIndex = 4;
            // 
            // light1Row2
            // 
            this.light1Row2.BackColor = System.Drawing.Color.DimGray;
            this.light1Row2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.light1Row2.Location = new System.Drawing.Point(24, 86);
            this.light1Row2.Name = "light1Row2";
            this.light1Row2.Size = new System.Drawing.Size(40, 40);
            this.light1Row2.TabIndex = 3;
            // 
            // light2Row3
            // 
            this.light2Row3.BackColor = System.Drawing.Color.DimGray;
            this.light2Row3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.light2Row3.Location = new System.Drawing.Point(70, 141);
            this.light2Row3.Name = "light2Row3";
            this.light2Row3.Size = new System.Drawing.Size(40, 40);
            this.light2Row3.TabIndex = 7;
            // 
            // light1Row3
            // 
            this.light1Row3.BackColor = System.Drawing.Color.DimGray;
            this.light1Row3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.light1Row3.Location = new System.Drawing.Point(24, 141);
            this.light1Row3.Name = "light1Row3";
            this.light1Row3.Size = new System.Drawing.Size(40, 40);
            this.light1Row3.TabIndex = 6;
            // 
            // greenLight2
            // 
            this.greenLight2.BackColor = System.Drawing.Color.DarkGreen;
            this.greenLight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLight2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.greenLight2.Location = new System.Drawing.Point(70, 193);
            this.greenLight2.Name = "greenLight2";
            this.greenLight2.Size = new System.Drawing.Size(40, 40);
            this.greenLight2.TabIndex = 9;
            // 
            // greenLight1
            // 
            this.greenLight1.BackColor = System.Drawing.Color.DarkGreen;
            this.greenLight1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLight1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.greenLight1.Location = new System.Drawing.Point(24, 193);
            this.greenLight1.Name = "greenLight1";
            this.greenLight1.Size = new System.Drawing.Size(40, 40);
            this.greenLight1.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(146, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 40);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(146, 86);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 40);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // goButton
            // 
            this.goButton.ForeColor = System.Drawing.Color.Black;
            this.goButton.Location = new System.Drawing.Point(146, 141);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(108, 40);
            this.goButton.TabIndex = 12;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // raceTimer
            // 
            this.raceTimer.Interval = 400;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reaction Time:";
            // 
            // reactionLabel
            // 
            this.reactionLabel.AutoSize = true;
            this.reactionLabel.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactionLabel.Location = new System.Drawing.Point(143, 216);
            this.reactionLabel.Name = "reactionLabel";
            this.reactionLabel.Size = new System.Drawing.Size(170, 17);
            this.reactionLabel.TabIndex = 14;
            this.reactionLabel.Text = "0.000 milliseconds";
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLabel.Location = new System.Drawing.Point(277, 32);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(98, 17);
            this.scoreTitleLabel.TabIndex = 15;
            this.scoreTitleLabel.Text = "Highscore:";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(277, 55);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(0, 17);
            this.highScoreLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(427, 250);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.scoreTitleLabel);
            this.Controls.Add(this.reactionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.greenLight2);
            this.Controls.Add(this.greenLight1);
            this.Controls.Add(this.light2Row3);
            this.Controls.Add(this.light1Row3);
            this.Controls.Add(this.light2Row2);
            this.Controls.Add(this.light1Row2);
            this.Controls.Add(this.light2Row1);
            this.Controls.Add(this.light1Row1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Drag Race";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label light1Row1;
        private System.Windows.Forms.Label light2Row1;
        private System.Windows.Forms.Label light2Row2;
        private System.Windows.Forms.Label light1Row2;
        private System.Windows.Forms.Label light2Row3;
        private System.Windows.Forms.Label light1Row3;
        private System.Windows.Forms.Label greenLight2;
        private System.Windows.Forms.Label greenLight1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Timer raceTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reactionLabel;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Label highScoreLabel;
    }
}

