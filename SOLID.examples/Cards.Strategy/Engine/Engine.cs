using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Engine
{
    public class Engine
    {
        public static void RunRound()
        {
            RecordActions();
            ApplyActions();
            UpdateScores();
            CheckForDefeat();
        }

        private static void CheckForDefeat()
        {
            throw new NotImplementedException();
        }

        private static void UpdateScores()
        {
            throw new NotImplementedException();
        }

        private static void ApplyActions()
        {
            throw new NotImplementedException();
        }

        private static void RecordActions()
        {
            throw new NotImplementedException();
        }
    }
}
