using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class CustomVote: Option
    {
        public int NumOfOption = 3;
        public Option[] Options()
        {
            Option[] Options = new Option[NumOfOption];

            for (int i = 0; i < Options.Length; i++)
                Options[i] = new Option();

            return Options;
        }
    }
}
