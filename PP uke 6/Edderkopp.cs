using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_6
{
    class Edderkopp : Bug
    {
        public List <Edderkopp> edderkopps = new List <Edderkopp> ();
        public string Ailments { get; }

        public Edderkopp(string name, string abilities, string ailments)
        : base(name, abilities)
        {
            Ailments = ailments;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ailments = {Ailments}");
        }

        public static void PrintEdderkopp()
        {
            foreach (Edderkopp edderkopp in edderkopps)
            {
                Console.WriteLine(edderkopp.Name);
            }
        }
    }
}
