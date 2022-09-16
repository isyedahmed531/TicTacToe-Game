namespace TicTacToe
{
    partial class TicTacToe
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlaterStatus = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(25, 60);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(74, 74);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = " ";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(105, 60);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(74, 74);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = " ";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(185, 60);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(74, 74);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = " ";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(185, 140);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(74, 74);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = " ";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(105, 140);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(74, 74);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = " ";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(25, 140);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(74, 74);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = " ";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(185, 220);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(74, 74);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = " ";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(105, 220);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(74, 74);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = " ";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(25, 220);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(74, 74);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = " ";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(301, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Play Again";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlaterStatus
            // 
            this.lblPlaterStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlaterStatus.Location = new System.Drawing.Point(295, 140);
            this.lblPlaterStatus.Name = "lblPlaterStatus";
            this.lblPlaterStatus.Size = new System.Drawing.Size(103, 50);
            this.lblPlaterStatus.TabIndex = 10;
            this.lblPlaterStatus.Text = "Playing: Player 1";
            this.lblPlaterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(111, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(196, 31);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "TIC TAC TOE";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 412);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblPlaterStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnReset;
        private Label lblPlaterStatus;
        private Label lblHeading;
    }
}