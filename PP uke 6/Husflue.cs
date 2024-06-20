using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_6
{
    class Husflue : Bug
    {
        public List <Husflue> husflues = new List <Husflue> ();
        public string Ailments { get; }

        public Husflue(string name, string abilities, string ailments)
        : base(name, abilities)
        {
            Ailments = ailments;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ailments = {Ailments}");
        }

        public static void PrintFlue()
        {
            foreach (Husflue husflue in husflues)
            {
                Console.WriteLine(husflue.Name);
            }
        }
    }
}
