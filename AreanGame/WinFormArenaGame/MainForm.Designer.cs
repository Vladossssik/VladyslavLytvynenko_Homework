namespace WinFormArenaGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            tbKnight = new TextBox();
            tbAssassin = new TextBox();
            imgFight = new PictureBox();
            lbWinner = new Label();
            label1 = new Label();
            label2 = new Label();
            tbTank = new TextBox();
            tbArcher = new TextBox();
            btnNewGame2 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(591, 148);
            btnNewGame.Margin = new Padding(3, 2, 3, 2);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(82, 22);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // tbKnight
            // 
            tbKnight.Location = new Point(20, 26);
            tbKnight.Margin = new Padding(3, 2, 3, 2);
            tbKnight.Multiline = true;
            tbKnight.Name = "tbKnight";
            tbKnight.Size = new Size(490, 329);
            tbKnight.TabIndex = 1;
            tbKnight.TextChanged += tbKnight_TextChanged;
            // 
            // tbAssassin
            // 
            tbAssassin.Location = new Point(769, 33);
            tbAssassin.Margin = new Padding(3, 2, 3, 2);
            tbAssassin.Multiline = true;
            tbAssassin.Name = "tbAssassin";
            tbAssassin.Size = new Size(490, 329);
            tbAssassin.TabIndex = 2;
            tbAssassin.TextChanged += tbAssassin_TextChanged;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(552, 200);
            imgFight.Margin = new Padding(3, 2, 3, 2);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(180, 100);
            imgFight.TabIndex = 5;
            imgFight.TabStop = false;
            imgFight.Click += imgFight_Click;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(552, 364);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(180, 67);
            lbWinner.TabIndex = 6;
            lbWinner.Visible = false;
            lbWinner.Click += lbWinner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(769, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Assassin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 7);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Knight:";
            label2.Click += label2_Click;
            // 
            // tbTank
            // 
            tbTank.Location = new Point(20, 427);
            tbTank.Multiline = true;
            tbTank.Name = "tbTank";
            tbTank.Size = new Size(490, 329);
            tbTank.TabIndex = 9;
            tbTank.TextChanged += tbTank_TextChanged;
            // 
            // tbArcher
            // 
            tbArcher.Location = new Point(769, 427);
            tbArcher.Multiline = true;
            tbArcher.Name = "tbArcher";
            tbArcher.Size = new Size(490, 329);
            tbArcher.TabIndex = 10;
            tbArcher.TextChanged += tbArcher_TextChanged;
            // 
            // btnNewGame2
            // 
            btnNewGame2.Location = new Point(591, 504);
            btnNewGame2.Name = "btnNewGame2";
            btnNewGame2.Size = new Size(82, 26);
            btnNewGame2.TabIndex = 11;
            btnNewGame2.Text = "New Game 2";
            btnNewGame2.UseVisualStyleBackColor = true;
            btnNewGame2.Click += btnNewGame2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 409);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 12;
            label3.Text = "Tank:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(769, 409);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "Archer:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 768);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnNewGame2);
            Controls.Add(tbArcher);
            Controls.Add(tbTank);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(tbAssassin);
            Controls.Add(tbKnight);
            Controls.Add(btnNewGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Arena Game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox tbKnight;
        private TextBox tbAssassin;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
        private TextBox tbTank;
        private TextBox tbArcher;
        private Button btnNewGame2;
        private Label label3;
        private Label label4;
    }
}