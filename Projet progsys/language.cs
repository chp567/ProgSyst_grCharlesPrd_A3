using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_progsys
{
    class _Language //creation of the language class
    {
        private int Language;

        public int SetLanguage() //method to select the dired language on for the software to run
        {
            int language;
            Console.WriteLine("Choissisez votre langue : "+$"{Environment.NewLine}Choose your language :" +
            $"{Environment.NewLine}1 = Français" +
            $"{Environment.NewLine}2 = English");
            language = int.Parse(Console.ReadLine());

            //If statement checking the entered value in order to correct if there is any mistake on the input
            if (language is 1)
            {
                Console.WriteLine("La langue sélectionnée est le français");
            }
            else if (language is 2)
            {
                Console.WriteLine("The selected language is english");
            }
            else
            {
                SetLanguage();
                
            }

            this.Language = language;

            return this.Language;
        }

        public int GetLanguage() //get method returning the value of the private variable language 
        {
            return this.Language;
        }
    }
}
