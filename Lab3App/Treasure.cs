using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        public int Score;

        public void UpdateTotalScore()
        {
            this.Board.TotalScore += Score;
            Console.WriteLine("Total score is update to: " + Board.TotalScore);
        }
        public override void AddMe(List<Collectable> c)
        {
            base.AddMe(c);
            UpdateTotalScore();
        }
    }
}
