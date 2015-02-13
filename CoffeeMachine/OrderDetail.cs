
namespace CoffeeMachine
{
    using System.Collections.Generic;

    public class OrderDetail
    {
        public DrinkKind Kind;
        public int SugarCount;

        private static readonly Dictionary<DrinkKind, string> DrinkKindString = new Dictionary<DrinkKind, string>
        {
            {DrinkKind.Coffee, "C"},
            {DrinkKind.Tea, "T"},
            {DrinkKind.Chocolate, "H"}
        };

        public override string ToString()
        {
            string result = DrinkKindString[Kind];
            result += ":";
            //Sugar count
            if (SugarCount > 0)
                result += SugarCount;

            result += ":";
            //Add stick
            if (SugarCount > 0)
                result += "0";
            return result;
        }
    }
}
