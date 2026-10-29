namespace Topic_11___Adding_Sounds_and_Randomization
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
            this.btnSound = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultTxt = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgPig = new System.Windows.Forms.PictureBox();
            this.imgCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSound
            // 
            this.btnSound.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.Location = new System.Drawing.Point(550, 12);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(238, 75);
            this.btnSound.TabIndex = 3;
            this.btnSound.Text = "Click to play the sound!";
            this.btnSound.UseVisualStyleBackColor = true;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(29, 27);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(515, 42);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "Play the sound, and pick the correct animal!";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(29, 385);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(101, 42);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // lblResultTxt
            // 
            this.lblResultTxt.AutoSize = true;
            this.lblResultTxt.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTxt.Location = new System.Drawing.Point(127, 385);
            this.lblResultTxt.Name = "lblResultTxt";
            this.lblResultTxt.Size = new System.Drawing.Size(121, 42);
            this.lblResultTxt.TabIndex = 6;
            this.lblResultTxt.Text = "Correct!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Topic_11___Adding_Sounds_and_Randomization.Properties.Resources.dog;
            this.pictureBox3.Location = new System.Drawing.Point(532, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(242, 242);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // imgPig
            // 
            this.imgPig.Image = global::Topic_11___Adding_Sounds_and_Randomization.Properties.Resources.pig;
            this.imgPig.Location = new System.Drawing.Point(284, 115);
            this.imgPig.Name = "imgPig";
            this.imgPig.Size = new System.Drawing.Size(242, 242);
            this.imgPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPig.TabIndex = 1;
            this.imgPig.TabStop = false;
            // 
            // imgCat
            // 
            this.imgCat.Image = global::Topic_11___Adding_Sounds_and_Randomization.Properties.Resources.cat;
            this.imgCat.Location = new System.Drawing.Point(36, 115);
            this.imgCat.Name = "imgCat";
            this.imgCat.Size = new System.Drawing.Size(242, 242);
            this.imgCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCat.TabIndex = 0;
            this.imgCat.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultTxt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.imgPig);
            this.Controls.Add(this.imgCat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCat;
        private System.Windows.Forms.PictureBox imgPig;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultTxt;
    }
}

