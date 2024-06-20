using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_6
{
    abstract class Bug
    {
        public Bug() 
        {
            Menu();
        }
        public void Menu()
        {
            bool inMenu = true;
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    InnsektListe();
                    break;
                   case "2":
                    default: inMenu = false;
                    break;
            }
        }
        void InnsektListe()
        {
            var insectChoice = Console.ReadLine();
            switch (insectChoice)
            {
                case "1":
                 Edderkopp.PrintEdderkopp();
                    break;
                case "2":
                    Mygg.PrintMygg();
                    break;
                case "3":
                    Husflue.PrintFlue();
                    break;
                case "4":
                    flått.PrintFlått();
                    break;
                case "5":
                    Veps.PrintVeps();
                    break;
            }
        }
        
       
        public string Name { get; }
        public string Ailments { get; }
        

        protected Bug(string name, string ailments) 
        {
            Name = name;
            Ailments = ailments;
            
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"");
        }

       
    }
}

