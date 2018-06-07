using System;

namespace rpgchars
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Vivi");
            Ninja ninja = new Ninja("Shadow");
            Samurai samurai = new Samurai("Ashe");
            wizard.DisplayStats();
            ninja.DisplayStats();
            samurai.DisplayStats();

            ninja.BackStab(wizard);
        }
    }
}
