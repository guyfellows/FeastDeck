namespace FeastDeck
{
    partial class Form1
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
            this.drawButton = new System.Windows.Forms.Button();
            this.lblCardsRemaining = new System.Windows.Forms.Label();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.drawBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardPic1 = new System.Windows.Forms.PictureBox();
            this.cardPic2 = new System.Windows.Forms.PictureBox();
            this.cardPic3 = new System.Windows.Forms.PictureBox();
            this.cardPic4 = new System.Windows.Forms.PictureBox();
            this.cardPic5 = new System.Windows.Forms.PictureBox();
            this.cardPic6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic6)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(16, 12);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw Cards";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // lblCardsRemaining
            // 
            this.lblCardsRemaining.AutoSize = true;
            this.lblCardsRemaining.Location = new System.Drawing.Point(601, 20);
            this.lblCardsRemaining.Name = "lblCardsRemaining";
            this.lblCardsRemaining.Size = new System.Drawing.Size(121, 15);
            this.lblCardsRemaining.TabIndex = 1;
            this.lblCardsRemaining.Text = "Cards Remaining: 154";
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(728, 12);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 2;
            this.shuffleButton.Text = "Shuffle Deck";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(97, 13);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(23, 23);
            this.drawBox.TabIndex = 0;
            this.drawBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drawBox.TextChanged += new System.EventHandler(this.drawBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cards to Draw";
            // 
            // cardPic1
            // 
            this.cardPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPic1.Location = new System.Drawing.Point(12, 47);
            this.cardPic1.Name = "cardPic1";
            this.cardPic1.Size = new System.Drawing.Size(260, 364);
            this.cardPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic1.TabIndex = 5;
            this.cardPic1.TabStop = false;
            // 
            // cardPic2
            // 
            this.cardPic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPic2.Location = new System.Drawing.Point(278, 47);
            this.cardPic2.Name = "cardPic2";
            this.cardPic2.Size = new System.Drawing.Size(260, 364);
            this.cardPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic2.TabIndex = 6;
            this.cardPic2.TabStop = false;
            // 
            // cardPic3
            // 
            this.cardPic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPic3.Location = new System.Drawing.Point(544, 47);
            this.cardPic3.Name = "cardPic3";
            this.cardPic3.Size = new System.Drawing.Size(260, 364);
            this.cardPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic3.TabIndex = 7;
            this.cardPic3.TabStop = false;
            // 
            // cardPic4
            // 
            this.cardPic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPic4.Location = new System.Drawing.Point(12, 417);
            this.cardPic4.Name = "cardPic4";
            this.cardPic4.Size = new System.Drawing.Size(260, 364);
            this.cardPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic4.TabIndex = 8;
            this.cardPic4.TabStop = false;
            // 
            // cardPic5
            // 
            this.cardPic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPic5.Location = new System.Drawing.Point(278, 417);
            this.cardPic5.Name = "cardPic5";
            this.cardPic5.Size = new System.Drawing.Size(260, 364);
            this.cardPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic5.TabIndex = 9;
            this.cardPic5.TabStop = false;
            // 
            // cardPic6
            // 
            this.cardPic6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPic6.Location = new System.Drawing.Point(544, 417);
            this.cardPic6.Name = "cardPic6";
            this.cardPic6.Size = new System.Drawing.Size(260, 364);
            this.cardPic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic6.TabIndex = 10;
            this.cardPic6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 822);
            this.Controls.Add(this.cardPic6);
            this.Controls.Add(this.cardPic5);
            this.Controls.Add(this.cardPic4);
            this.Controls.Add(this.cardPic3);
            this.Controls.Add(this.cardPic2);
            this.Controls.Add(this.cardPic1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.lblCardsRemaining);
            this.Controls.Add(this.drawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cardPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button drawButton;
        private Label lblCardsRemaining;
        private Button shuffleButton;
        private TextBox drawBox;
        private Label label1;
        private PictureBox cardPic1;
        private PictureBox cardPic2;
        private PictureBox cardPic3;
        private PictureBox cardPic4;
        private PictureBox cardPic5;
        private PictureBox cardPic6;
    }
}