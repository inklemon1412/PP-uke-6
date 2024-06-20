using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_6
{
    class Mygg : Bug
    {
        public List<Mygg> myggs = new List<Mygg>();
       public string Ailments { get; }

        public Mygg(string name, string abilities, string ailments)
        : base(name, abilities)
        {
            Ailments = ailments;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ailments = {Ailments}");
        }

        public static void PrintMygg()
        {
            foreach (var mygg in myggs)
            {
                Console.WriteLine (mygg.Name);
            }
        }
    }
}
