using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    public class Player
    {
        private string _name;
        private int _points;

        public Player(string name, int points)
        {
            _name = name;
            _points = points;
        }

        public void Play(Player opponent)
        {
            var random = new Random();
            var winner = random.Next(2); // 2 is exclusive

            if (winner == 0)
            {
                _points++;
                opponent._points--;
            }
            else
            {
                opponent._points++;
                _points--;
            }
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Points: {_points}\n");
        }
    }
}
