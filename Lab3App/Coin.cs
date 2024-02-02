using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value;

        public Coin(String d, int score, int value) 
        {
            Description = d;
            Value = value;   
            Score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        public void UpdateTotalValue()
        {
            this.Board.TotalValue += Value;
            Console.WriteLine("Total value is update to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> c)
        {
            base.AddMe(c);
            UpdateTotalValue();
        }
    }
}
