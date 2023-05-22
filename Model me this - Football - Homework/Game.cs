using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_me_this___Football___Homework
{
    public  class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Refree Refree { get; set; }
        public List<AssistantRefree> AssistantRefrees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }

        public Game()
        {
            AssistantRefrees = new List<AssistantRefree>();
            Goals = new List<Goal>();
        }
    }
}
