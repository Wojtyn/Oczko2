using System.Drawing;

namespace Oczko2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerHitBtn = new System.Windows.Forms.Button();
            this.PlayerStandBtn = new System.Windows.Forms.Button();
            this.PlayerDDBtn = new System.Windows.Forms.Button();
            this.PlayerSplitBtn = new System.Windows.Forms.Button();
            this.PlayerBetControl = new System.Windows.Forms.NumericUpDown();
            this.PlayerBet = new System.Windows.Forms.Label();
            this.PlayerMoneyLabel = new System.Windows.Forms.Label();
            this.labelGracz = new System.Windows.Forms.Label();
            this.labelBot = new System.Windows.Forms.Label();
            this.labelDealer = new System.Windows.Forms.Label();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.PlayerCard3 = new System.Windows.Forms.PictureBox();
            this.PlayerCard4 = new System.Windows.Forms.PictureBox();
            this.PlayerCard5 = new System.Windows.Forms.PictureBox();
            this.BotCard1 = new System.Windows.Forms.PictureBox();
            this.BotCard2 = new System.Windows.Forms.PictureBox();
            this.BotCard3 = new System.Windows.Forms.PictureBox();
            this.BotCard4 = new System.Windows.Forms.PictureBox();
            this.BotCard5 = new System.Windows.Forms.PictureBox();
            this.DealerCard1 = new System.Windows.Forms.PictureBox();
            this.DealerCard2 = new System.Windows.Forms.PictureBox();
            this.DealerCard3 = new System.Windows.Forms.PictureBox();
            this.DealerCard4 = new System.Windows.Forms.PictureBox();
            this.DealerCard5 = new System.Windows.Forms.PictureBox();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.PointsPlayerLabel = new System.Windows.Forms.Label();
            this.PlayerMoney = new System.Windows.Forms.Label();
            this.PlayerPoints = new System.Windows.Forms.Label();
            this.BotPointsLabel = new System.Windows.Forms.Label();
            this.DealerPointsLabel = new System.Windows.Forms.Label();
            this.DealerPoints = new System.Windows.Forms.Label();
            this.BotPoints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBetControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerHitBtn
            // 
            this.PlayerHitBtn.Location = new System.Drawing.Point(460, 493);
            this.PlayerHitBtn.Name = "PlayerHitBtn";
            this.PlayerHitBtn.Size = new System.Drawing.Size(117, 29);
            this.PlayerHitBtn.TabIndex = 0;
            this.PlayerHitBtn.Text = "Hit";
            this.PlayerHitBtn.UseVisualStyleBackColor = true;
            this.PlayerHitBtn.Click += new System.EventHandler(this.PlayerHitBtn_Click);
            // 
            // PlayerStandBtn
            // 
            this.PlayerStandBtn.Location = new System.Drawing.Point(583, 493);
            this.PlayerStandBtn.Name = "PlayerStandBtn";
            this.PlayerStandBtn.Size = new System.Drawing.Size(118, 29);
            this.PlayerStandBtn.TabIndex = 1;
            this.PlayerStandBtn.Text = "Stand";
            this.PlayerStandBtn.UseVisualStyleBackColor = true;
            this.PlayerStandBtn.Click += new System.EventHandler(this.PlayerStandBtn_Click);
            // 
            // PlayerDDBtn
            // 
            this.PlayerDDBtn.Location = new System.Drawing.Point(707, 493);
            this.PlayerDDBtn.Name = "PlayerDDBtn";
            this.PlayerDDBtn.Size = new System.Drawing.Size(118, 29);
            this.PlayerDDBtn.TabIndex = 2;
            this.PlayerDDBtn.Text = "Double Down";
            this.PlayerDDBtn.UseVisualStyleBackColor = true;
            // 
            // PlayerSplitBtn
            // 
            this.PlayerSplitBtn.Location = new System.Drawing.Point(831, 493);
            this.PlayerSplitBtn.Name = "PlayerSplitBtn";
            this.PlayerSplitBtn.Size = new System.Drawing.Size(118, 29);
            this.PlayerSplitBtn.TabIndex = 3;
            this.PlayerSplitBtn.Text = "Split";
            this.PlayerSplitBtn.UseVisualStyleBackColor = true;
            // 
            // PlayerBetControl
            // 
            this.PlayerBetControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayerBetControl.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerBetControl.Location = new System.Drawing.Point(899, 445);
            this.PlayerBetControl.Name = "PlayerBetControl";
            this.PlayerBetControl.Size = new System.Drawing.Size(43, 20);
            this.PlayerBetControl.TabIndex = 4;
            this.PlayerBetControl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PlayerBet
            // 
            this.PlayerBet.AutoSize = true;
            this.PlayerBet.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerBet.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerBet.Location = new System.Drawing.Point(867, 444);
            this.PlayerBet.Name = "PlayerBet";
            this.PlayerBet.Size = new System.Drawing.Size(33, 17);
            this.PlayerBet.TabIndex = 5;
            this.PlayerBet.Text = "Bet:";
            // 
            // PlayerMoneyLabel
            // 
            this.PlayerMoneyLabel.AutoSize = true;
            this.PlayerMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerMoneyLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerMoneyLabel.Location = new System.Drawing.Point(867, 461);
            this.PlayerMoneyLabel.Name = "PlayerMoneyLabel";
            this.PlayerMoneyLabel.Size = new System.Drawing.Size(24, 17);
            this.PlayerMoneyLabel.TabIndex = 6;
            this.PlayerMoneyLabel.Text = "$: ";
            // 
            // labelGracz
            // 
            this.labelGracz.AutoSize = true;
            this.labelGracz.BackColor = System.Drawing.Color.Transparent;
            this.labelGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGracz.ForeColor = System.Drawing.SystemColors.Window;
            this.labelGracz.Location = new System.Drawing.Point(35, 324);
            this.labelGracz.Name = "labelGracz";
            this.labelGracz.Size = new System.Drawing.Size(46, 17);
            this.labelGracz.TabIndex = 7;
            this.labelGracz.Text = "Gracz";
            this.labelGracz.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBot
            // 
            this.labelBot.AutoSize = true;
            this.labelBot.BackColor = System.Drawing.Color.Transparent;
            this.labelBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBot.ForeColor = System.Drawing.SystemColors.Window;
            this.labelBot.Location = new System.Drawing.Point(35, 34);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(29, 17);
            this.labelBot.TabIndex = 8;
            this.labelBot.Text = "Bot";
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.BackColor = System.Drawing.Color.Transparent;
            this.labelDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDealer.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDealer.Location = new System.Drawing.Point(539, 34);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(50, 17);
            this.labelDealer.TabIndex = 9;
            this.labelDealer.Text = "Dealer";
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerCard1.Image = ((System.Drawing.Image)(resources.GetObject("PlayerCard1.Image")));
            this.PlayerCard1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PlayerCard1.InitialImage")));
            this.PlayerCard1.Location = new System.Drawing.Point(38, 365);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(77, 113);
            this.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCard1.TabIndex = 10;
            this.PlayerCard1.TabStop = false;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard2.Cursor = System.Windows.Forms.Cursors.No;
            this.PlayerCard2.Location = new System.Drawing.Point(121, 365);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(77, 113);
            this.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCard2.TabIndex = 11;
            this.PlayerCard2.TabStop = false;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerCard3.Location = new System.Drawing.Point(204, 365);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(77, 113);
            this.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCard3.TabIndex = 12;
            this.PlayerCard3.TabStop = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerCard4.Location = new System.Drawing.Point(287, 365);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(77, 113);
            this.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCard4.TabIndex = 13;
            this.PlayerCard4.TabStop = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerCard5.Location = new System.Drawing.Point(370, 365);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(77, 113);
            this.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCard5.TabIndex = 14;
            this.PlayerCard5.TabStop = false;
            // 
            // BotCard1
            // 
            this.BotCard1.BackColor = System.Drawing.Color.Transparent;
            this.BotCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotCard1.Location = new System.Drawing.Point(38, 54);
            this.BotCard1.Name = "BotCard1";
            this.BotCard1.Size = new System.Drawing.Size(77, 113);
            this.BotCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotCard1.TabIndex = 15;
            this.BotCard1.TabStop = false;
            // 
            // BotCard2
            // 
            this.BotCard2.BackColor = System.Drawing.Color.Transparent;
            this.BotCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotCard2.Location = new System.Drawing.Point(121, 54);
            this.BotCard2.Name = "BotCard2";
            this.BotCard2.Size = new System.Drawing.Size(77, 113);
            this.BotCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotCard2.TabIndex = 16;
            this.BotCard2.TabStop = false;
            // 
            // BotCard3
            // 
            this.BotCard3.BackColor = System.Drawing.Color.Transparent;
            this.BotCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotCard3.Location = new System.Drawing.Point(204, 54);
            this.BotCard3.Name = "BotCard3";
            this.BotCard3.Size = new System.Drawing.Size(77, 113);
            this.BotCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotCard3.TabIndex = 17;
            this.BotCard3.TabStop = false;
            // 
            // BotCard4
            // 
            this.BotCard4.BackColor = System.Drawing.Color.Transparent;
            this.BotCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotCard4.Location = new System.Drawing.Point(287, 54);
            this.BotCard4.Name = "BotCard4";
            this.BotCard4.Size = new System.Drawing.Size(77, 113);
            this.BotCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotCard4.TabIndex = 18;
            this.BotCard4.TabStop = false;
            // 
            // BotCard5
            // 
            this.BotCard5.BackColor = System.Drawing.Color.Transparent;
            this.BotCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotCard5.Location = new System.Drawing.Point(370, 54);
            this.BotCard5.Name = "BotCard5";
            this.BotCard5.Size = new System.Drawing.Size(77, 113);
            this.BotCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotCard5.TabIndex = 19;
            this.BotCard5.TabStop = false;
            // 
            // DealerCard1
            // 
            this.DealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DealerCard1.Location = new System.Drawing.Point(542, 54);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(77, 113);
            this.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DealerCard1.TabIndex = 20;
            this.DealerCard1.TabStop = false;
            // 
            // DealerCard2
            // 
            this.DealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DealerCard2.Location = new System.Drawing.Point(625, 54);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(77, 113);
            this.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DealerCard2.TabIndex = 21;
            this.DealerCard2.TabStop = false;
            // 
            // DealerCard3
            // 
            this.DealerCard3.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DealerCard3.Location = new System.Drawing.Point(708, 54);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(77, 113);
            this.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DealerCard3.TabIndex = 22;
            this.DealerCard3.TabStop = false;
            // 
            // DealerCard4
            // 
            this.DealerCard4.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DealerCard4.Location = new System.Drawing.Point(791, 54);
            this.DealerCard4.Name = "DealerCard4";
            this.DealerCard4.Size = new System.Drawing.Size(77, 113);
            this.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DealerCard4.TabIndex = 23;
            this.DealerCard4.TabStop = false;
            // 
            // DealerCard5
            // 
            this.DealerCard5.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DealerCard5.Location = new System.Drawing.Point(874, 54);
            this.DealerCard5.Name = "DealerCard5";
            this.DealerCard5.Size = new System.Drawing.Size(77, 113);
            this.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DealerCard5.TabIndex = 24;
            this.DealerCard5.TabStop = false;
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(8, 497);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(118, 29);
            this.QuitBtn.TabIndex = 25;
            this.QuitBtn.Text = "Zamknij";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(130, 497);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(118, 29);
            this.HelpBtn.TabIndex = 26;
            this.HelpBtn.Text = "Pomoc";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // PointsPlayerLabel
            // 
            this.PointsPlayerLabel.AutoSize = true;
            this.PointsPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PointsPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PointsPlayerLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PointsPlayerLabel.Location = new System.Drawing.Point(118, 324);
            this.PointsPlayerLabel.Name = "PointsPlayerLabel";
            this.PointsPlayerLabel.Size = new System.Drawing.Size(59, 17);
            this.PointsPlayerLabel.TabIndex = 27;
            this.PointsPlayerLabel.Text = "Punkty: ";
            // 
            // PlayerMoney
            // 
            this.PlayerMoney.AutoSize = true;
            this.PlayerMoney.BackColor = System.Drawing.Color.Transparent;
            this.PlayerMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerMoney.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerMoney.Location = new System.Drawing.Point(882, 461);
            this.PlayerMoney.Name = "PlayerMoney";
            this.PlayerMoney.Size = new System.Drawing.Size(32, 17);
            this.PlayerMoney.TabIndex = 28;
            this.PlayerMoney.Text = "100";
            // 
            // PlayerPoints
            // 
            this.PlayerPoints.AutoSize = true;
            this.PlayerPoints.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerPoints.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerPoints.Location = new System.Drawing.Point(167, 324);
            this.PlayerPoints.Name = "PlayerPoints";
            this.PlayerPoints.Size = new System.Drawing.Size(16, 17);
            this.PlayerPoints.TabIndex = 29;
            this.PlayerPoints.Text = "1";
            // 
            // BotPointsLabel
            // 
            this.BotPointsLabel.AutoSize = true;
            this.BotPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.BotPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BotPointsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.BotPointsLabel.Location = new System.Drawing.Point(118, 34);
            this.BotPointsLabel.Name = "BotPointsLabel";
            this.BotPointsLabel.Size = new System.Drawing.Size(59, 17);
            this.BotPointsLabel.TabIndex = 30;
            this.BotPointsLabel.Text = "Punkty: ";
            // 
            // DealerPointsLabel
            // 
            this.DealerPointsLabel.AutoSize = true;
            this.DealerPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DealerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DealerPointsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.DealerPointsLabel.Location = new System.Drawing.Point(622, 34);
            this.DealerPointsLabel.Name = "DealerPointsLabel";
            this.DealerPointsLabel.Size = new System.Drawing.Size(59, 17);
            this.DealerPointsLabel.TabIndex = 31;
            this.DealerPointsLabel.Text = "Punkty: ";
            // 
            // DealerPoints
            // 
            this.DealerPoints.AutoSize = true;
            this.DealerPoints.BackColor = System.Drawing.Color.Transparent;
            this.DealerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DealerPoints.ForeColor = System.Drawing.SystemColors.Window;
            this.DealerPoints.Location = new System.Drawing.Point(671, 34);
            this.DealerPoints.Name = "DealerPoints";
            this.DealerPoints.Size = new System.Drawing.Size(16, 17);
            this.DealerPoints.TabIndex = 32;
            this.DealerPoints.Text = "1";
            // 
            // BotPoints
            // 
            this.BotPoints.AutoSize = true;
            this.BotPoints.BackColor = System.Drawing.Color.Transparent;
            this.BotPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BotPoints.ForeColor = System.Drawing.SystemColors.Window;
            this.BotPoints.Location = new System.Drawing.Point(168, 34);
            this.BotPoints.Name = "BotPoints";
            this.BotPoints.Size = new System.Drawing.Size(16, 17);
            this.BotPoints.TabIndex = 33;
            this.BotPoints.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotPoints);
            this.Controls.Add(this.DealerPoints);
            this.Controls.Add(this.DealerPointsLabel);
            this.Controls.Add(this.BotPointsLabel);
            this.Controls.Add(this.PlayerPoints);
            this.Controls.Add(this.PlayerMoney);
            this.Controls.Add(this.PointsPlayerLabel);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.DealerCard5);
            this.Controls.Add(this.DealerCard4);
            this.Controls.Add(this.DealerCard3);
            this.Controls.Add(this.DealerCard2);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.BotCard5);
            this.Controls.Add(this.BotCard4);
            this.Controls.Add(this.BotCard3);
            this.Controls.Add(this.BotCard2);
            this.Controls.Add(this.BotCard1);
            this.Controls.Add(this.PlayerCard5);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.labelDealer);
            this.Controls.Add(this.labelBot);
            this.Controls.Add(this.labelGracz);
            this.Controls.Add(this.PlayerMoneyLabel);
            this.Controls.Add(this.PlayerBet);
            this.Controls.Add(this.PlayerBetControl);
            this.Controls.Add(this.PlayerSplitBtn);
            this.Controls.Add(this.PlayerDDBtn);
            this.Controls.Add(this.PlayerStandBtn);
            this.Controls.Add(this.PlayerHitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OczkoJW";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBetControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerHitBtn;
        private System.Windows.Forms.Button PlayerStandBtn;
        private System.Windows.Forms.Button PlayerDDBtn;
        private System.Windows.Forms.Button PlayerSplitBtn;
        private System.Windows.Forms.NumericUpDown PlayerBetControl;
        private System.Windows.Forms.Label PlayerBet;
        private System.Windows.Forms.Label PlayerMoneyLabel;
        private System.Windows.Forms.Label labelGracz;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.PictureBox PlayerCard1;
        private System.Windows.Forms.PictureBox PlayerCard2;
        private System.Windows.Forms.PictureBox PlayerCard3;
        private System.Windows.Forms.PictureBox PlayerCard4;
        private System.Windows.Forms.PictureBox PlayerCard5;
        private System.Windows.Forms.PictureBox BotCard1;
        private System.Windows.Forms.PictureBox BotCard2;
        private System.Windows.Forms.PictureBox BotCard3;
        private System.Windows.Forms.PictureBox BotCard4;
        private System.Windows.Forms.PictureBox BotCard5;
        private System.Windows.Forms.PictureBox DealerCard1;
        private System.Windows.Forms.PictureBox DealerCard2;
        private System.Windows.Forms.PictureBox DealerCard3;
        private System.Windows.Forms.PictureBox DealerCard4;
        private System.Windows.Forms.PictureBox DealerCard5;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Label PointsPlayerLabel;
        private System.Windows.Forms.Label PlayerMoney;
        private System.Windows.Forms.Label PlayerPoints;
        private System.Windows.Forms.Label BotPointsLabel;
        private System.Windows.Forms.Label DealerPointsLabel;
        private System.Windows.Forms.Label DealerPoints;
        private System.Windows.Forms.Label BotPoints;
        private System.Windows.Forms.PictureBox pictureBox1;
        
    }
}

