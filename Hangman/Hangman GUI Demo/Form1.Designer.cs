namespace Hangman_GUI_Demo
{
    partial class frm_HangmanDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HangmanDemo));
            this.Prg_Game = new System.Windows.Forms.ProgressBar();
            this.pic_Hangman = new System.Windows.Forms.PictureBox();
            this.Btn_WordGuess = new System.Windows.Forms.Button();
            this.txt_WordGeuss = new System.Windows.Forms.TextBox();
            this.Btn_LtrGuess = new System.Windows.Forms.Button();
            this.txt_LtrGeuss = new System.Windows.Forms.TextBox();
            this.txt_Word = new System.Windows.Forms.TextBox();
            this.Lbl_Word = new System.Windows.Forms.Label();
            this.txt_UsedLetters = new System.Windows.Forms.TextBox();
            this.lbl_usedLetters = new System.Windows.Forms.Label();
            this.btn_Revive = new System.Windows.Forms.Button();
            this.btn_wordgen = new System.Windows.Forms.Button();
            this.btn_quiter = new System.Windows.Forms.Button();
            this.Tmr_TIME = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hangman)).BeginInit();
            this.SuspendLayout();
            // 
            // Prg_Game
            // 
            this.Prg_Game.Location = new System.Drawing.Point(571, 405);
            this.Prg_Game.Maximum = 60;
            this.Prg_Game.Name = "Prg_Game";
            this.Prg_Game.Size = new System.Drawing.Size(263, 33);
            this.Prg_Game.TabIndex = 1;
            // 
            // pic_Hangman
            // 
            this.pic_Hangman.BackColor = System.Drawing.Color.Transparent;
            this.pic_Hangman.Image = global::Hangman_GUI_Demo.Properties.Resources.Hangman_0;
            this.pic_Hangman.Location = new System.Drawing.Point(571, 152);
            this.pic_Hangman.Name = "pic_Hangman";
            this.pic_Hangman.Size = new System.Drawing.Size(263, 247);
            this.pic_Hangman.TabIndex = 2;
            this.pic_Hangman.TabStop = false;
            //this.pic_Hangman.Click += new System.EventHandler(this.pic_Hangman_Click);
            // 
            // Btn_WordGuess
            // 
            this.Btn_WordGuess.Enabled = false;
            this.Btn_WordGuess.Location = new System.Drawing.Point(12, 12);
            this.Btn_WordGuess.Name = "Btn_WordGuess";
            this.Btn_WordGuess.Size = new System.Drawing.Size(100, 36);
            this.Btn_WordGuess.TabIndex = 3;
            this.Btn_WordGuess.Text = "Guess Word";
            this.Btn_WordGuess.UseVisualStyleBackColor = true;
            this.Btn_WordGuess.Click += new System.EventHandler(this.Btn_WordGuess_Click);
            // 
            // txt_WordGeuss
            // 
            this.txt_WordGeuss.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_WordGeuss.Location = new System.Drawing.Point(12, 54);
            this.txt_WordGeuss.Name = "txt_WordGeuss";
            this.txt_WordGeuss.Size = new System.Drawing.Size(100, 20);
            this.txt_WordGeuss.TabIndex = 4;
            this.txt_WordGeuss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_LtrGuess
            // 
            this.Btn_LtrGuess.Enabled = false;
            this.Btn_LtrGuess.Location = new System.Drawing.Point(12, 459);
            this.Btn_LtrGuess.Name = "Btn_LtrGuess";
            this.Btn_LtrGuess.Size = new System.Drawing.Size(100, 36);
            this.Btn_LtrGuess.TabIndex = 5;
            this.Btn_LtrGuess.Text = "Guess Letter";
            this.Btn_LtrGuess.UseVisualStyleBackColor = true;
            this.Btn_LtrGuess.Click += new System.EventHandler(this.Btn_LtrGuess_Click);
            // 
            // txt_LtrGeuss
            // 
            this.txt_LtrGeuss.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_LtrGeuss.Location = new System.Drawing.Point(12, 501);
            this.txt_LtrGeuss.MaxLength = 1;
            this.txt_LtrGeuss.Name = "txt_LtrGeuss";
            this.txt_LtrGeuss.Size = new System.Drawing.Size(100, 20);
            this.txt_LtrGeuss.TabIndex = 6;
            this.txt_LtrGeuss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Word
            // 
            this.txt_Word.Enabled = false;
            this.txt_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Word.Location = new System.Drawing.Point(722, 36);
            this.txt_Word.Name = "txt_Word";
            this.txt_Word.Size = new System.Drawing.Size(100, 26);
            this.txt_Word.TabIndex = 7;
            this.txt_Word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Word
            // 
            this.Lbl_Word.AutoSize = true;
            this.Lbl_Word.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Word.Location = new System.Drawing.Point(766, 9);
            this.Lbl_Word.Name = "Lbl_Word";
            this.Lbl_Word.Size = new System.Drawing.Size(56, 24);
            this.Lbl_Word.TabIndex = 8;
            this.Lbl_Word.Text = "Word";
            // 
            // txt_UsedLetters
            // 
            this.txt_UsedLetters.Enabled = false;
            this.txt_UsedLetters.Location = new System.Drawing.Point(571, 468);
            this.txt_UsedLetters.Multiline = true;
            this.txt_UsedLetters.Name = "txt_UsedLetters";
            this.txt_UsedLetters.Size = new System.Drawing.Size(263, 62);
            this.txt_UsedLetters.TabIndex = 9;
            this.txt_UsedLetters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_usedLetters
            // 
            this.lbl_usedLetters.AutoSize = true;
            this.lbl_usedLetters.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usedLetters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_usedLetters.Location = new System.Drawing.Point(649, 441);
            this.lbl_usedLetters.Name = "lbl_usedLetters";
            this.lbl_usedLetters.Size = new System.Drawing.Size(114, 24);
            this.lbl_usedLetters.TabIndex = 10;
            this.lbl_usedLetters.Text = "Used Letters";
            // 
            // btn_Revive
            // 
            this.btn_Revive.Enabled = false;
            this.btn_Revive.Location = new System.Drawing.Point(281, 223);
            this.btn_Revive.Name = "btn_Revive";
            this.btn_Revive.Size = new System.Drawing.Size(257, 71);
            this.btn_Revive.TabIndex = 12;
            this.btn_Revive.Text = "Revive?";
            this.btn_Revive.UseVisualStyleBackColor = true;
            this.btn_Revive.Click += new System.EventHandler(this.btn_Revive_Click);
            // 
            // btn_wordgen
            // 
            this.btn_wordgen.Location = new System.Drawing.Point(722, 62);
            this.btn_wordgen.Name = "btn_wordgen";
            this.btn_wordgen.Size = new System.Drawing.Size(100, 33);
            this.btn_wordgen.TabIndex = 13;
            this.btn_wordgen.Text = "Generate Word";
            this.btn_wordgen.UseVisualStyleBackColor = true;
            this.btn_wordgen.Click += new System.EventHandler(this.btn_wordgen_Click);
            // 
            // btn_quiter
            // 
            this.btn_quiter.Enabled = false;
            this.btn_quiter.Location = new System.Drawing.Point(281, 300);
            this.btn_quiter.Name = "btn_quiter";
            this.btn_quiter.Size = new System.Drawing.Size(257, 71);
            this.btn_quiter.TabIndex = 14;
            this.btn_quiter.Text = "Quit";
            this.btn_quiter.UseVisualStyleBackColor = true;
            this.btn_quiter.Click += new System.EventHandler(this.btn_quiter_Click);
            // 
            // Tmr_TIME
            // 
            this.Tmr_TIME.Interval = 1000;
            this.Tmr_TIME.Tick += new System.EventHandler(this.Tmr_TIME_Tick);
            // 
            // frm_HangmanDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Hangman_GUI_Demo.Properties.Resources.Wild_West_landscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 533);
            this.Controls.Add(this.btn_quiter);
            this.Controls.Add(this.btn_wordgen);
            this.Controls.Add(this.btn_Revive);
            this.Controls.Add(this.lbl_usedLetters);
            this.Controls.Add(this.txt_UsedLetters);
            this.Controls.Add(this.Lbl_Word);
            this.Controls.Add(this.txt_Word);
            this.Controls.Add(this.txt_LtrGeuss);
            this.Controls.Add(this.Btn_LtrGuess);
            this.Controls.Add(this.txt_WordGeuss);
            this.Controls.Add(this.Btn_WordGuess);
            this.Controls.Add(this.pic_Hangman);
            this.Controls.Add(this.Prg_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_HangmanDemo";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Prg_Game;
        private System.Windows.Forms.PictureBox pic_Hangman;
        private System.Windows.Forms.Button Btn_WordGuess;
        private System.Windows.Forms.TextBox txt_WordGeuss;
        private System.Windows.Forms.Button Btn_LtrGuess;
        private System.Windows.Forms.TextBox txt_LtrGeuss;
        private System.Windows.Forms.TextBox txt_Word;
        private System.Windows.Forms.Label Lbl_Word;
        private System.Windows.Forms.TextBox txt_UsedLetters;
        private System.Windows.Forms.Label lbl_usedLetters;
        private System.Windows.Forms.Button btn_Revive;
        private System.Windows.Forms.Button btn_wordgen;
        private System.Windows.Forms.Button btn_quiter;
        private System.Windows.Forms.Timer Tmr_TIME;

    }
}

