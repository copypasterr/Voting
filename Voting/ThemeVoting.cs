using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class ThemeVoting: Option
    {
        public int Quantity = 15;

        public CustomVote[] Theme()
        {
            CustomVote[] customVotes = new CustomVote[Quantity];
            for (int i = 0; i < customVotes.Length; i++)
                customVotes[i] = new CustomVote();

            return customVotes;
        }
    }
}
