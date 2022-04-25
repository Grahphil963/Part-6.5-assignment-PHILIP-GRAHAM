namespace Rock_Paper_Scissors_Philip_Graham
{
    partial class RockPaperScissors
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
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblCpu = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(52, 115);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(50, 138);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.rdoPaper_CheckedChanged);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(50, 161);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.rdoScissors_CheckedChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 85);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(176, 13);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Please select rock paper or scissors";
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(530, 85);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(100, 13);
            this.lblCpu.TabIndex = 5;
            this.lblCpu.Text = "Opponenet\'s Result";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Location = new System.Drawing.Point(246, 329);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(71, 13);
            this.lblGameResult.TabIndex = 6;
            this.lblGameResult.Text = "Game Result:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Rock_Paper_Scissors_Philip_Graham.Properties.Resources.inline_image_preview;
            this.imgPlayer.Location = new System.Drawing.Point(207, 115);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(234, 132);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 10;
            this.imgPlayer.TabStop = false;
            this.imgPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Rock_Paper_Scissors_Philip_Graham.Properties.Resources.inline_image_preview;
            this.imgOpponent.Location = new System.Drawing.Point(483, 115);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(234, 132);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 9;
            this.imgOpponent.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(281, 84);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(69, 13);
            this.lblPlayer.TabIndex = 11;
            this.lblPlayer.Text = "Player Result";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(483, 276);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(241, 135);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play Round";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.radScissors);
            this.Controls.Add(this.radPaper);
            this.Controls.Add(this.radRock);
            this.Name = "RockPaperScissors";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnPlay;
    }
}

