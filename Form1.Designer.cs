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
            this.lblNumberOfWins = new System.Windows.Forms.Label();
            this.lblNumberOfTies = new System.Windows.Forms.Label();
            this.lblNumberOFLosses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.Location = new System.Drawing.Point(71, 309);
            this.radRock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(90, 31);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.Location = new System.Drawing.Point(195, 310);
            this.radPaper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(105, 31);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.rdoPaper_CheckedChanged);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.Location = new System.Drawing.Point(334, 307);
            this.radScissors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(140, 31);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.rdoScissors_CheckedChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(16, 279);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(508, 27);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Please select rock paper or scissors";
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.Location = new System.Drawing.Point(589, 34);
            this.lblCpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(264, 27);
            this.lblCpu.TabIndex = 5;
            this.lblCpu.Text = "Opponenet\'s Result";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResult.Location = new System.Drawing.Point(672, 313);
            this.lblGameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(171, 27);
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
            this.imgPlayer.Location = new System.Drawing.Point(237, 78);
            this.imgPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(312, 142);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 10;
            this.imgPlayer.TabStop = false;
            this.imgPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Rock_Paper_Scissors_Philip_Graham.Properties.Resources.inline_image_preview;
            this.imgOpponent.Location = new System.Drawing.Point(604, 78);
            this.imgOpponent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(312, 142);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 9;
            this.imgOpponent.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(271, 34);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(189, 27);
            this.lblPlayer.TabIndex = 11;
            this.lblPlayer.Text = "Player Result";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Crimson;
            this.btnPlay.Font = new System.Drawing.Font("Proxy 5", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(71, 347);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(307, 130);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play Round";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblNumberOfWins
            // 
            this.lblNumberOfWins.AutoSize = true;
            this.lblNumberOfWins.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWins.Location = new System.Drawing.Point(559, 402);
            this.lblNumberOfWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfWins.Name = "lblNumberOfWins";
            this.lblNumberOfWins.Size = new System.Drawing.Size(36, 27);
            this.lblNumberOfWins.TabIndex = 13;
            this.lblNumberOfWins.Text = "0 ";
            // 
            // lblNumberOfTies
            // 
            this.lblNumberOfTies.AutoSize = true;
            this.lblNumberOfTies.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTies.Location = new System.Drawing.Point(695, 402);
            this.lblNumberOfTies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfTies.Name = "lblNumberOfTies";
            this.lblNumberOfTies.Size = new System.Drawing.Size(25, 27);
            this.lblNumberOfTies.TabIndex = 14;
            this.lblNumberOfTies.Text = "0";
            // 
            // lblNumberOFLosses
            // 
            this.lblNumberOFLosses.AutoSize = true;
            this.lblNumberOFLosses.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOFLosses.Location = new System.Drawing.Point(813, 402);
            this.lblNumberOFLosses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOFLosses.Name = "lblNumberOFLosses";
            this.lblNumberOFLosses.Size = new System.Drawing.Size(25, 27);
            this.lblNumberOFLosses.TabIndex = 15;
            this.lblNumberOFLosses.Text = "0";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(607, 402);
            this.lblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(67, 27);
            this.lblWins.TabIndex = 16;
            this.lblWins.Text = "Wins";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(735, 402);
            this.lblTies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(62, 27);
            this.lblTies.TabIndex = 17;
            this.lblTies.Text = "Ties";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Proxy 5", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(853, 402);
            this.lblLosses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(102, 27);
            this.lblLosses.TabIndex = 18;
            this.lblLosses.Text = "Losses";
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(957, 485);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblNumberOFLosses);
            this.Controls.Add(this.lblNumberOfTies);
            this.Controls.Add(this.lblNumberOfWins);
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
            this.Font = new System.Drawing.Font("Proxy 5", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Label lblNumberOfWins;
        private System.Windows.Forms.Label lblNumberOfTies;
        private System.Windows.Forms.Label lblNumberOFLosses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblLosses;
    }
}

