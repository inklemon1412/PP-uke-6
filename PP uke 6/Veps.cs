using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_6
{
    class Veps : Bug
    {
        public List<Veps> _veps = new List<Veps>();
        public string Ailments { get; }

        public Veps(string name, string abilities, string ailments)
        : base(name, abilities)
        {
            Ailments = ailments;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ailments = {Ailments}");
        }
         public static void PrintVeps()
        {
            foreach (Veps veps in _veps)
            {
                Console.WriteLine(veps.Name);
            }
        }
    }
}
