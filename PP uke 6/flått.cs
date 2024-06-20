using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_6
{
    class flått : Bug
    {
        public List<flått> flåtts = new List<flått>(); 
        public string Ailments { get; }

        public flått(string name, string abilities, string ailments)
        : base(name, abilities)
        {
            Ailments = ailments;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ailments = {Ailments}");
        }

        public static void PrintFlått()
        {
            foreach (flått flått in flåtts)
            {
                Console.WriteLine(flått.Name);
            }
        }
    }
}