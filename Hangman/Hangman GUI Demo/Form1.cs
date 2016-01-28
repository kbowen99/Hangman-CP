#region Hangman



#region program
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this makes the magic happen
#region Gypsy_Magic
namespace Hangman_GUI_Demo
{
    
    public partial class frm_HangmanDemo : Form
    {
        #region Variables
        char[] Textbox;
        bool LoseLimbsActive = true;
        #region Words
        string[] Words = {
                             "word",
                             "hello",
                             "jazz",
                             "noob",
                             "abbey",
                             "abruptly",
                             "affix",
                             "askew",
                             "axiom",
                             "azure",
                             "bagpipes",
                             "bandwagon",
                             "banjo",
                             "bayou",
                             "bikini",
                             "blitz",
                             "bookworm",
                             "boxcar",
                             "boxful",
                             "buckaroo",
                             "buffalo",
                             "buffoon",
                             "cobweb",
                             "croquet",
                             "disavow",
                             "duplex",
                             "dwarves",
                             "equip",
                             "exodus",
                             "fishhook",
                             "fixable",
                             "galaxy",
                             "galvinize",
                             "gazebo",
                             "gizmo",
                             "guffaw",
                             "haiku",
                             "haphazard",
                             "hyphen",
                             "icebox",
                             "injury",
                             "ivory",
                             "ivy",
                             "jawbreaker",
                             "jaundice",
                             "jazzy",
                             "jovial",
                             "joyful",
                             "jigsaw",
                             "jujitsu",
                             "jockey",
                             "kazoo",
                             "khaki",
                             "kiosk",
                             "kiwifruit",
                             "knapsack",
                             "larynx",
                             "oxidize",
                             "microwave",
                             "oxygen",
                             "numbskull",
                             "pixel",
                             "pizzaz",
                             "pneumonia",
                             "unknown",
                             "zilch",
                             "zephyr",
                             "google",
                             "Kurtis",
                             "buzz",
                             "jazzed",
                             "fizz",
                             "fuzz",
                             "jinx",
                             "fuzzy",
                             "razz",
                             "puff",
                             "zap",
                             "quiz",
                             "vex",
                             "huh",
                             "zigzagging",
                             "antidisestablishmentarianism",
                             "supercalifragilisticexpialidocious",
                             "Floccinaucinihilipilification",
                             "Honorificabilitudinitatibus",
                             "Pneumonoultramicroscopicsilicovolcanoconiosis",
                             "Lopado­­temacho­­selacho­­galeo­­kranio­­leipsano­­drim­­hypo­­trimmato­­silphio­­parao­­melito­­katakechy­­meno­­kichl­­epi­­kossypho­­phatto­­perister­­alektryon­­opte­­kephallio­­kigklo­­peleio­­lagoio­­siraio­­baphe­­tragano­­pterygon",
                             "Cow",
                             "mathmatics",

                         };
        
        #endregion
        char[] WordLetters;
        string RndWord = "Chosen Word";
        Random rndgen = new Random();
        int limbs = 0;
        Image[] HangMen = {
                              Properties.Resources.Hangman_0,
                              Properties.Resources.Hangman_1,
                              Properties.Resources.Hangman_2,
                              Properties.Resources.Hangman_3,
                              Properties.Resources.Hangman_4,
                              Properties.Resources.Hangman_5,
                              Properties.Resources.Hangman_6,
                          };
        string[] WorkingAst = new string[100];
        int rndnum;
        #endregion
        public frm_HangmanDemo()
        {
            //start ame with buttons in correct order
            InitializeComponent();
            btn_Revive.Visible = false;
            txt_Word.Enabled = false;
            btn_quiter.Visible = false;
        }
        private void btn_wordgen_Click(object sender, EventArgs e)
        {
            //Begin Gen Word
            Zombify();
            Tmr_TIME.Start();
            txt_UsedLetters.Text = "";
        }
        private void btn_quiter_Click(object sender, EventArgs e)
        {
            //a close button for all the quiters of the world
            this.Close();
        }
        public void Generator()
        {
            #region GenCode
            //Messy Word Gen code
            try
            {
                rndnum = rndgen.Next((0), (Words.Length));
                RndWord = Words[rndnum];
                Console.Write("Number " + rndnum + " " + "Word " + Words[rndnum]);
                txt_Word.Text = "";
                for (int i = 0; i < (RndWord.Length); i++)
                {
                    txt_Word.Text = txt_Word.Text + "*";
                }
                Textbox = (txt_Word.Text).ToCharArray(); 
            }
            catch
            {
                //to catch occasion weird error that sometimes occurs when hitting word button twice
                Console.Write("Out of Range Exception");
            }
            WordLetters = RndWord.ToCharArray();
            //clean out array
            WorkingAst = new string[250];
            for (int i = 1; i < (RndWord.Length + 1); i++)
            {
                WorkingAst[(i)] = " * ";
            };
            for (int i = 0; i < WordLetters.Length; i++)
            {
                //debug info
                Console.Write(" Letter: ");
                Console.Write(WordLetters[i]);
            }
            for (int i = 0; i < WorkingAst.Length; i++)
            {
                //more debug
                Console.Write(WorkingAst[i]);
            }
            #endregion
        }
        public void StartHang()
        {
            //begin the hangings
            Btn_LtrGuess.Enabled = true;
            Btn_WordGuess.Enabled = true;
            Generator();
        }

        private void btn_Revive_Click(object sender, EventArgs e)
        {
            //restart for all the awesome people
            Application.Restart();
        }
        private void Btn_WordGuess_Click(object sender, EventArgs e)
        {
            #region Guess
            #region Debug
            if (txt_WordGeuss.Text == "debug")
            {
                MessageBox.Show("Current word " + RndWord, " " + rndnum);
                Tmr_TIME.Stop();
            }
            else if (txt_WordGeuss.Text == "stoptimer")
            {
                Tmr_TIME.Stop();
            }
            else if (txt_WordGeuss.Text == "stoplose")
            {
                LoseLimbsActive = false;
            }
            else if (txt_WordGeuss.Text == "-killyourself")
            {
                LoseLimbsActive = false;
                Tmr_TIME.Stop();
                limbs = 0;
                Prg_Game.Value = 0;
            }
            #endregion
            //check to see if word is correct
            if ((txt_WordGeuss.Text).Contains(RndWord) == true && txt_WordGeuss.Text.Length > 0)
            {
                Endgame("You Won!");
            }
            else if ((txt_WordGeuss.Text).Contains(RndWord) == false)
            {
                limbs = limbs + 1;
                LoseLimbs();
            }
            txt_WordGeuss.Text = "";
            #endregion
        }
        private void Btn_LtrGuess_Click(object sender, EventArgs e)
        {
            #region Guessltr
            //check letter guess
            try
            {
                if (txt_UsedLetters.Text.Contains(txt_LtrGeuss.Text) == true && txt_LtrGeuss.Text.Length > 0)
                {
                    //noob code
                    MessageBox.Show("You already guessed that", "noob");
                    limbs = limbs + 1;
                    LoseLimbs();
                }
                else
                {
                    CheckLetter(Convert.ToChar(txt_LtrGeuss.Text));
                }
            }
            catch
            {
                Console.Write(" CheckLetter Failed ");
            }
            #endregion
        }
        public void LoseLimbs()
        {
            #region limblosers
            if (LoseLimbsActive == true)
            {
                pic_Hangman.Image = HangMen[limbs];
            }
            else
            {
                //debug feature
                Console.Write(" Loss of limbs is disabled ");
            }
            #endregion
        }

        private void Tmr_TIME_Tick(object sender, EventArgs e)
        {
            #region Tick
            //time
            if (Prg_Game.Value < 60)
            {
                Prg_Game.Value = Prg_Game.Value + 1;
            }
            else
            {
                //die code
                Endgame("You Ran out of time! The Correct Answer was" + RndWord);
            }
            if (limbs == 6)
            {
                //die code
                Endgame("You Died, The Correct answer was " + RndWord);

            }
            #endregion
        }
        private void Zombify()
        {
            #region ZombieCode
            //sets up buttons, brings from the dead
            limbs = 0;
            pic_Hangman.Image = HangMen[0];
            Prg_Game.Value = 0;
            StartHang();
            Btn_LtrGuess.Enabled = true;
            Btn_WordGuess.Enabled = true;
            btn_wordgen.Enabled = true;
            btn_Revive.Visible = false;
            btn_quiter.Visible = false;
            #endregion
        }
        private void Endgame(string message)
        {
            #region End
            //used for deaths and occasional win
            Tmr_TIME.Stop();
            MessageBox.Show(message);
            Btn_LtrGuess.Enabled = false;
            Btn_WordGuess.Enabled = false;
            btn_wordgen.Enabled = false;
            btn_Revive.Visible = true;
            btn_quiter.Visible = true;
            btn_quiter.Enabled = true;
            btn_Revive.Enabled = true;
            #endregion
        }
        public void CheckLetter(char L)
        {
            #region LetterCheck
            //check to see if letter is correct, and a few other things
            int wrong = 0;
            try
            {
                for (int i = 0; i < (RndWord.Length); i++)
                {
                    if (RndWord[i] == L)
                    {
                        Textbox[i] = txt_LtrGeuss.Text[0];
                        txt_Word.Text = "";
                        for (int k = 0; k < (Textbox.Length); k++)
                        {
                            txt_Word.Text = txt_Word.Text + Textbox[k];
                        }
                        if (txt_Word.Text == RndWord)
                        {
                            //the occasional win
                            Endgame("You Won");
                        }
                    }
                    else
                    {
                        wrong = wrong + 1;
                    }
                };
            }
            catch
            {
                //safetynet/idiot check
                Console.Write(" No Character Value ");
            }
            if (wrong == (RndWord.Length))
            {
                limbs = limbs + 1;
                LoseLimbs();
                txt_UsedLetters.Text = txt_UsedLetters.Text + " " + txt_LtrGeuss.Text + " ";
                txt_LtrGeuss.Text = "";
            }
            else
            {
                txt_UsedLetters.Text = txt_UsedLetters.Text + " " + txt_LtrGeuss.Text + " ";
            }
            wrong = 0;
            txt_LtrGeuss.Text = "";
            #endregion
        }
    }
}
#endregion
#endregion
//this is my game, it isn't special, but it is mine
//copyright Kurtis Bowen
//liscensed under CC BY-NC-SA
#endregion