namespace TheQuest2019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.pictureBoxBluePotionInventory = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedPotionInventory = new System.Windows.Forms.PictureBox();
            this.pictureBoxSwordInventory = new System.Windows.Forms.PictureBox();
            this.pictureBoxBowInventory = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaceInventory = new System.Windows.Forms.PictureBox();
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.groupBoxAttack = new System.Windows.Forms.GroupBox();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanelHitpoints = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitpoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghostHitpoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.batHitpoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerHitpoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBluePotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedPotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBowInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaceInventory)).BeginInit();
            this.groupBoxMove.SuspendLayout();
            this.groupBoxAttack.SuspendLayout();
            this.tableLayoutPanelHitpoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(197, 122);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Visible = true;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(647, 122);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(50, 50);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mace.TabIndex = 1;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(591, 122);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(50, 50);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bow.TabIndex = 2;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(535, 122);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(50, 50);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sword.TabIndex = 3;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(479, 122);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(50, 50);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redPotion.TabIndex = 4;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(423, 122);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(50, 50);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bluePotion.TabIndex = 5;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(367, 122);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(50, 50);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ghoul.TabIndex = 6;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(311, 122);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(50, 50);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ghost.TabIndex = 7;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(255, 122);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(50, 50);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bat.TabIndex = 8;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // pictureBoxBluePotionInventory
            // 
            this.pictureBoxBluePotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBluePotionInventory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBluePotionInventory.Image")));
            this.pictureBoxBluePotionInventory.Location = new System.Drawing.Point(398, 621);
            this.pictureBoxBluePotionInventory.Name = "pictureBoxBluePotionInventory";
            this.pictureBoxBluePotionInventory.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxBluePotionInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBluePotionInventory.TabIndex = 9;
            this.pictureBoxBluePotionInventory.TabStop = false;
            this.pictureBoxBluePotionInventory.Visible = false;
            this.pictureBoxBluePotionInventory.Click += new System.EventHandler(this.pictureBoxBluePotionInventory_Click);
            // 
            // pictureBoxRedPotionInventory
            // 
            this.pictureBoxRedPotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRedPotionInventory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRedPotionInventory.Image")));
            this.pictureBoxRedPotionInventory.Location = new System.Drawing.Point(479, 621);
            this.pictureBoxRedPotionInventory.Name = "pictureBoxRedPotionInventory";
            this.pictureBoxRedPotionInventory.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxRedPotionInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedPotionInventory.TabIndex = 10;
            this.pictureBoxRedPotionInventory.TabStop = false;
            this.pictureBoxRedPotionInventory.Visible = false;
            this.pictureBoxRedPotionInventory.Click += new System.EventHandler(this.pictureBoxRedPotionInventory_Click);
            // 
            // pictureBoxSwordInventory
            // 
            this.pictureBoxSwordInventory.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSwordInventory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSwordInventory.Image")));
            this.pictureBoxSwordInventory.Location = new System.Drawing.Point(155, 621);
            this.pictureBoxSwordInventory.Name = "pictureBoxSwordInventory";
            this.pictureBoxSwordInventory.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxSwordInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSwordInventory.TabIndex = 11;
            this.pictureBoxSwordInventory.TabStop = false;
            this.pictureBoxSwordInventory.Visible = false;
            this.pictureBoxSwordInventory.Click += new System.EventHandler(this.pictureBoxSwordInventory_Click);
            // 
            // pictureBoxBowInventory
            // 
            this.pictureBoxBowInventory.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBowInventory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBowInventory.Image")));
            this.pictureBoxBowInventory.Location = new System.Drawing.Point(236, 621);
            this.pictureBoxBowInventory.Name = "pictureBoxBowInventory";
            this.pictureBoxBowInventory.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxBowInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBowInventory.TabIndex = 12;
            this.pictureBoxBowInventory.TabStop = false;
            this.pictureBoxBowInventory.Visible = false;
            this.pictureBoxBowInventory.Click += new System.EventHandler(this.pictureBoxBowInventory_Click);
            // 
            // pictureBoxMaceInventory
            // 
            this.pictureBoxMaceInventory.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMaceInventory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaceInventory.Image")));
            this.pictureBoxMaceInventory.Location = new System.Drawing.Point(317, 621);
            this.pictureBoxMaceInventory.Name = "pictureBoxMaceInventory";
            this.pictureBoxMaceInventory.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxMaceInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaceInventory.TabIndex = 13;
            this.pictureBoxMaceInventory.TabStop = false;
            this.pictureBoxMaceInventory.Visible = false;
            this.pictureBoxMaceInventory.Click += new System.EventHandler(this.pictureBoxMaceInventory_Click);
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMove.Controls.Add(this.moveUp);
            this.groupBoxMove.Controls.Add(this.moveRight);
            this.groupBoxMove.Controls.Add(this.moveDown);
            this.groupBoxMove.Controls.Add(this.moveLeft);
            this.groupBoxMove.Location = new System.Drawing.Point(560, 604);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(200, 100);
            this.groupBoxMove.TabIndex = 14;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Move";
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(80, 10);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(40, 40);
            this.moveUp.TabIndex = 3;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(125, 30);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(40, 40);
            this.moveRight.TabIndex = 2;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(80, 50);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(40, 40);
            this.moveDown.TabIndex = 1;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(35, 30);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(40, 40);
            this.moveLeft.TabIndex = 0;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // groupBoxAttack
            // 
            this.groupBoxAttack.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAttack.Controls.Add(this.attackRight);
            this.groupBoxAttack.Controls.Add(this.attackUp);
            this.groupBoxAttack.Controls.Add(this.attackDown);
            this.groupBoxAttack.Controls.Add(this.attackLeft);
            this.groupBoxAttack.Location = new System.Drawing.Point(766, 604);
            this.groupBoxAttack.Name = "groupBoxAttack";
            this.groupBoxAttack.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAttack.TabIndex = 15;
            this.groupBoxAttack.TabStop = false;
            this.groupBoxAttack.Text = "Attack";
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(125, 30);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(40, 40);
            this.attackRight.TabIndex = 3;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(80, 10);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(40, 40);
            this.attackUp.TabIndex = 2;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(80, 50);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(40, 40);
            this.attackDown.TabIndex = 1;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(35, 30);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(40, 40);
            this.attackLeft.TabIndex = 0;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // tableLayoutPanelHitpoints
            // 
            this.tableLayoutPanelHitpoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelHitpoints.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelHitpoints.ColumnCount = 2;
            this.tableLayoutPanelHitpoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHitpoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHitpoints.Controls.Add(this.ghoulHitpoints, 1, 3);
            this.tableLayoutPanelHitpoints.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanelHitpoints.Controls.Add(this.ghostHitpoints, 1, 2);
            this.tableLayoutPanelHitpoints.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanelHitpoints.Controls.Add(this.batHitpoints, 1, 1);
            this.tableLayoutPanelHitpoints.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelHitpoints.Controls.Add(this.playerHitpoints, 1, 0);
            this.tableLayoutPanelHitpoints.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelHitpoints.Location = new System.Drawing.Point(972, 611);
            this.tableLayoutPanelHitpoints.Name = "tableLayoutPanelHitpoints";
            this.tableLayoutPanelHitpoints.RowCount = 4;
            this.tableLayoutPanelHitpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelHitpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelHitpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelHitpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelHitpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHitpoints.Size = new System.Drawing.Size(163, 100);
            this.tableLayoutPanelHitpoints.TabIndex = 16;
            // 
            // ghoulHitpoints
            // 
            this.ghoulHitpoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ghoulHitpoints.AutoSize = true;
            this.ghoulHitpoints.Location = new System.Drawing.Point(84, 81);
            this.ghoulHitpoints.Name = "ghoulHitpoints";
            this.ghoulHitpoints.Size = new System.Drawing.Size(35, 13);
            this.ghoulHitpoints.TabIndex = 7;
            this.ghoulHitpoints.Text = "label8";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghoul";
            // 
            // ghostHitpoints
            // 
            this.ghostHitpoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ghostHitpoints.AutoSize = true;
            this.ghostHitpoints.Location = new System.Drawing.Point(84, 56);
            this.ghostHitpoints.Name = "ghostHitpoints";
            this.ghostHitpoints.Size = new System.Drawing.Size(35, 13);
            this.ghostHitpoints.TabIndex = 5;
            this.ghostHitpoints.Text = "label6";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghost";
            // 
            // batHitpoints
            // 
            this.batHitpoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batHitpoints.AutoSize = true;
            this.batHitpoints.Location = new System.Drawing.Point(84, 31);
            this.batHitpoints.Name = "batHitpoints";
            this.batHitpoints.Size = new System.Drawing.Size(35, 13);
            this.batHitpoints.TabIndex = 3;
            this.batHitpoints.Text = "label4";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bat";
            // 
            // playerHitpoints
            // 
            this.playerHitpoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playerHitpoints.AutoSize = true;
            this.playerHitpoints.Location = new System.Drawing.Point(84, 6);
            this.playerHitpoints.Name = "playerHitpoints";
            this.playerHitpoints.Size = new System.Drawing.Size(35, 13);
            this.playerHitpoints.TabIndex = 1;
            this.playerHitpoints.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.player);
            this.Controls.Add(this.tableLayoutPanelHitpoints);
            this.Controls.Add(this.groupBoxAttack);
            this.Controls.Add(this.groupBoxMove);
            this.Controls.Add(this.pictureBoxMaceInventory);
            this.Controls.Add(this.pictureBoxBowInventory);
            this.Controls.Add(this.pictureBoxSwordInventory);
            this.Controls.Add(this.pictureBoxRedPotionInventory);
            this.Controls.Add(this.pictureBoxBluePotionInventory);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBluePotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedPotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBowInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaceInventory)).EndInit();
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxAttack.ResumeLayout(false);
            this.tableLayoutPanelHitpoints.ResumeLayout(false);
            this.tableLayoutPanelHitpoints.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox pictureBoxBluePotionInventory;
        private System.Windows.Forms.PictureBox pictureBoxRedPotionInventory;
        private System.Windows.Forms.PictureBox pictureBoxSwordInventory;
        private System.Windows.Forms.PictureBox pictureBoxBowInventory;
        private System.Windows.Forms.PictureBox pictureBoxMaceInventory;
        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.GroupBox groupBoxAttack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHitpoints;
        private System.Windows.Forms.Label ghoulHitpoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ghostHitpoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label batHitpoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerHitpoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackLeft;
    }
}

