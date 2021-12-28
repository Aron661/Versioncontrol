﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;//dll using - pl: GameController class

namespace Evolucios_alg_Worldhardestgame
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;

        /*induló populáció*/
        int populationSize = 100;
        int nbrOfSteps = 10;
        int nbrOfStepsIncrement = 10;
        int generation = 1;

        /*győzteskezelés*/
        Brain winnerBrain=null;

        public Form1()
        {
            InitializeComponent();
            //label_generation.BringToFront();
            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            gc.GameOver += Gc_GameOver;

            for (int i = 0; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOfSteps);
            }
            gc.Start();

            //gc.AddPlayer(); tesztelésre
            //gc.Start(true);
        }

        private void Gc_GameOver(object sender)
        {
            generation++;
            label_generation.Text = string.Format("{0}. generáció", generation);

            var playerList = from p in gc.GetCurrentPlayers()
                             orderby p.GetFitness() descending
                             select p;
            var topPerformers = playerList.Take(populationSize / 2).ToList();

            gc.ResetCurrentLevel();
            foreach (var p in topPerformers)
            {
                var b = p.Brain.Clone();
                if (generation % 3 == 0)
                    gc.AddPlayer(b.ExpandBrain(nbrOfStepsIncrement));
                else
                    gc.AddPlayer(b);

                if (generation % 3 == 0)
                    gc.AddPlayer(b.Mutate().ExpandBrain(nbrOfStepsIncrement));
                else
                    gc.AddPlayer(b.Mutate());
            }
            gc.Start();

            var winners = from p in topPerformers
                          where p.IsWinner  //tesztelsé !p.IsWinner()
                          select p;

            if (winners.Count()>0)
            {
                winnerBrain = winners.FirstOrDefault().Brain.Clone();
                gc.GameOver -= Gc_GameOver;
                btn_Start.Visible = true; //start gomb iteráció végén
                return;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            gc.ResetCurrentLevel();
            gc.AddPlayer(winnerBrain.Clone());
            gc.AddPlayer();
            ga.Focus();
            gc.Start(true);
        }
    }
}
