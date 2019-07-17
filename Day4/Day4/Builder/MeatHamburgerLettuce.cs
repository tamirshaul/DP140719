using System;
namespace Day4.Builder
{
    public class MeatHamburgerLettuce : MeatHamburgerBuilder
    {
        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Lettuces XD");
        }
    }
}
