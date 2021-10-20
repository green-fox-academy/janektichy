using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GreetTheWorld.Models
{
    public class Greeting
    {
        protected string[] greetings;
        protected Random random;
        public string currentColor { get; set; }
        public string currentFontSize { get; set; }
        public string currentGreeting { get; set; }
        public Greeting()
        {
            greetings = new string[]{
                "Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};
            random = new Random();
            currentGreeting = greetings[random.Next(0, greetings.Length)];
            int fontSizeInt = random.Next(30, 100);
            currentFontSize = $"{fontSizeInt}px";
            int r = random.Next(0, 256);
            currentColor = getRandColor();
        }
        private string getRandColor()
        {
            string hexOutput = String.Format("{0:X}", random.Next(0, 0xFFFFFF));
            while (hexOutput.Length < 6)
                hexOutput = "0" + hexOutput;
            return "#" + hexOutput;
        }
    }
}
