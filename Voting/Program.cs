using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    internal class Program
    {
        ThemeVoting ThemeCreator(string _Name, string _Description, int Size = 15)
        {
            ThemeVoting Themes = new ThemeVoting()
            {
                Name = _Name,
                Description = _Description,
            };

            return Themes;
        }

        CustomVote VotingCreator(string _Name, string _Description, int Size = 3)
        {
            CustomVote Themes = new CustomVote();
            for (int i = 0; i < Size; i++)
            {
                Themes.Options()[i].Name = _Name;
                Themes.Options()[i].Description = _Description;
            }

            return Themes;
        }

        static void Main(string[] args)
        {
            
            
        }
    }
}
