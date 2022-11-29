using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_22._11._2022
{
    public class WorkItem
    {
        private string calc;

        public string Calc
        { 
            get { return calc; }
            set => calc = value;
        }

        private string buttontext;
        
        public string ButtonText
        {
            get { return buttontext; } 
            set => buttontext = value;
        }

        private int input;

        public int Input
        {
            get { return input; }
            set => input = value;
        }

        //Konstruktor
        public WorkItem()
        {
            calc= string.Empty;
            buttontext = "Berechnen";
            input = 5700;
        }

    }
}
