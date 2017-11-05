using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awoken
{
    public partial class Awoken : Form
    {
        private bool _wolf;
        private bool _vamp;
        private bool _mage;
        private bool _woke;
        private bool _gameOver;
        private int _moral;
        private int _steps = 0;

        public Awoken()
        {
            InitializeComponent();
            uxStoryText.Text = "Please press start button to begin.";
        }

        public int Moral
        {
            get
            {
                return _moral;
            }
        }

        public void MoralColor()
        {
            if (_moral > 5)
            {
                uxMoralTotal.ForeColor = Color.DeepSkyBlue;
                _moral++;
            }
            else if (_moral < -5)
            {
                uxMoralTotal.ForeColor = Color.Red;
                _moral--;
            }
            else
            {
                uxMoralTotal.ForeColor = Color.White;
            }
        }

        public void GameOver()
        {
            if (_gameOver)
            {
                uxStoryText.Font = new Font("GothicE", 30, FontStyle.Bold);
                uxStoryText.SelectionAlignment = HorizontalAlignment.Center;
                StoryPrint(StoryLine.GameOver());
            }
        }

        public void YouWin()
        {
            if (!_gameOver)
            {
                uxStoryText.Font = new Font("GothicE", 30, FontStyle.Bold);
                uxStoryText.SelectionAlignment = HorizontalAlignment.Center;
                StoryPrint(StoryLine.YouWin());
            }
        }

        public void StoryPrint(string s)
        {
            uxChoiceA.Enabled = false;
            uxChoiceB.Enabled = false;
            foreach (char c in s)
            {
                uxStoryText.AppendText(c.ToString());
                Thread.Sleep(1);
                uxStoryText.Refresh();
            }
            uxChoiceA.Enabled = true;
            uxChoiceB.Enabled = true;
        }

        public void Title()
        {
            uxStart.BackColor = Color.Black;
            uxStoryText.Font = new Font("GothicE", 30, FontStyle.Bold);
            uxStoryText.SelectionAlignment = HorizontalAlignment.Center;
            StoryPrint("WELCOME TO THE AWOKEN.\n\nA Formerly M-Rated Game.\n\nPress any button to start.");
        }

        private void uxChoiceA_Click(object sender, EventArgs e)
        {
            if(_steps == 0)
            {
                uxStoryText.Text = "";
                uxStoryText.Font = new Font("OCR A", 9.75F, FontStyle.Regular);
                uxStoryText.SelectionAlignment = HorizontalAlignment.Left;
                StoryPrint(StoryLine.PrologueHallway());
                _steps++;
            }
            else if(_steps == 1)
            {
                uxStoryText.Text = "";
                StoryPrint(StoryLine.PrologueHallwayLeft());
                _steps++;
            }
            else if(_steps == 2)
            {
                if (uxStoryText.Text.Equals(StoryLine.PrologueHallwayLeft()))
                    _wolf = true;
                else
                    _mage = true;
                uxStoryText.Text = "";
                if(_wolf)
                    StoryPrint(StoryLine.WakeUpWolf());
                else if(_vamp)
                    StoryPrint(StoryLine.WakeUpVamp());
                else if(_mage)
                    StoryPrint(StoryLine.WakeUpMage());
                else if(_woke)
                    StoryPrint(StoryLine.WakeUpWoke());
                _moral = 0;
                MoralColor();
                uxMoralTotal.Text = "0";
                _steps++;
            }
            else if (_steps == 3)
            {
                if (_wolf)
                    StoryPrint(StoryLine.GiveSugarWolf());
                else if (_vamp)
                    StoryPrint(StoryLine.GiveSugarVamp());
                else if (_mage)
                    StoryPrint(StoryLine.GiveSugarMage());
                else if (_woke)
                    StoryPrint(StoryLine.GiveSugarWoke());
                _moral++;
                MoralColor();
                uxMoralTotal.Text = _moral.ToString();
                StoryPrint(StoryLine.TwoBlocks());
                _steps++;
            }
            else if (_steps == 4)
            {
                if (_wolf)
                    StoryPrint(StoryLine.TwoBlocksGoodWolf());
                else if (_vamp)
                    StoryPrint(StoryLine.TwoBlocksGoodVamp());
                else if (_mage)
                    StoryPrint(StoryLine.TwoBlocksGoodMage());
                else if (_woke)
                    StoryPrint(StoryLine.TwoBlocksGoodWoke());
                _moral++;
                MoralColor();
                uxMoralTotal.Text = _moral.ToString();
                StoryPrint(StoryLine.ConvinceGeneral());
                _steps++;
            }
            else if (_steps == 5)
            {
                StoryPrint(StoryLine.ConvinceGeneralGood());
                StoryPrint(Act2.Act2Prologue());
                _steps++;
            }

            else if (_steps == 6)
            {
                StoryPrint(Act2.Act2PrologueGood());
                StoryPrint(Act2.Act2GoodRoute());
                _moral++;
                MoralColor();
                uxMoralTotal.Text = _moral.ToString();
                _steps++;
            }

            else if (_steps == 7)
            {
                StoryPrint(Act2.Act2GoodRouteGood());
                YouWin();
            }

            else if (_steps == 8)
            {
                StoryPrint(Act2.Act2EvilRouteGood());
                _gameOver = true;
                GameOver();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_steps == 0)
            {
                uxStoryText.Text = "";
                uxStoryText.Font = new Font("OCR A", 9.75F, FontStyle.Regular);
                uxStoryText.SelectionAlignment = HorizontalAlignment.Left;
                StoryPrint(StoryLine.PrologueHallway());
                _steps++;
            }
            else if (_steps == 1)
            {
                uxStoryText.Text = "";
                StoryPrint(StoryLine.PrologueHallwayRight());
                _steps++;
            }
            else if (_steps == 2)
            {
                if (uxStoryText.Text.Equals(StoryLine.PrologueHallwayRight()))
                    _vamp = true;
                else
                    _woke = true;
                uxStoryText.Text = "";
                if (_wolf)
                    StoryPrint(StoryLine.WakeUpWolf());
                else if (_vamp)
                    StoryPrint(StoryLine.WakeUpVamp());
                else if (_mage)
                    StoryPrint(StoryLine.WakeUpMage());
                else if (_woke)
                    StoryPrint(StoryLine.WakeUpWoke());
                _moral = 0;
                MoralColor();
                uxMoralTotal.Text = "0";
                _steps++;
            }
            else if (_steps == 3)
            {
                uxStoryText.Text = "";
                if (_wolf)
                    StoryPrint(StoryLine.ScareSugarWolf());
                else if (_vamp)
                    StoryPrint(StoryLine.ScareSugarVamp());
                else if (_mage)
                    StoryPrint(StoryLine.ScareSugarMage());
                else if (_woke)
                    StoryPrint(StoryLine.ScareSugarWoke());
                _moral--;
                MoralColor();
                uxMoralTotal.Text = _moral.ToString();
                StoryPrint(StoryLine.TwoBlocks());
                _steps++;
            }
            else if (_steps == 4)
            {
                uxStoryText.Text = "";
                StoryPrint(StoryLine.TwoBlocksEvil());
                StoryPrint(Act2.Act2Prologue());
                _moral--;
                MoralColor();
                uxMoralTotal.Text = _moral.ToString();
                _steps += 2;
            }
            else if (_steps == 5)
            {
                StoryPrint(StoryLine.ConvinceGeneralEvil());
                _gameOver = true;
                GameOver();
            }
            else if(_steps == 6)
            {
                StoryPrint(Act2.Act2PrologueEvil());
                StoryPrint(Act2.Act2EvilRoute());
                _steps++;
            }
            else if(_steps == 7)
            {
                StoryPrint(Act2.Act2GoodRouteEvil());
                _gameOver = true;
                GameOver();
            }

            else if (_steps == 8)
            {
                StoryPrint(Act2.Act2EvilRouteEvil());
                YouWin();

            }
        }

        private void uxStart_Click(object sender, EventArgs e)
        {
            uxStoryText.Text = "";
            Title();
            uxStart.Enabled = false;
        }
    }
}
