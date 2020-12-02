using System;
namespace Decorator_pattern
{
    public class CEspresso:ACBeverage
    {
        public CEspresso() {
            description = "Espresso";
        }
        public override double cost()
        {
            if (size == "sm")
            {
                return 1.99;
            }
            if (size == "md")
            {
                return 2.30;
            }
            if (size == "lg")
            {
                return 3;
            }
            return   + 1.99;
        }

    }
}
