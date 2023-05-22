using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_me_this___Football___Homework
{
    public class Team
    {
        public Coach? Coach { get; set; }
        public List<FootballPlayer>? FootballPlayers { get; set; }

        public double AveragePlayerAge()
        {
            if (FootballPlayers.Count == 0)
            {
                return 0;
            }

            int totalAge = FootballPlayers.Sum(p => p.Age);
            return (double)totalAge/FootballPlayers.Count;
        }
    }
}
