using System;
namespace Decorator_pattern
{
    public class HouseBlend:ACBeverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double cost()
        {
            if (size == "sm")
            {
                return .89;
            }
            if (size == "md")
            {
                return 1.5;
            }
            if (size == "lg")
            {
                return 2;
            }
            return .89;
        }
    }
    public class DarkRoast : ACBeverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double cost()
        {
            if (size == "sm")
            {
                return .99;
            }
            if (size == "md")
            {
                return 1.5;
            }
            if (size == "lg")
            {
                return 2;
            }
            return .99;
        }
    }
    public class Decaff : ACBeverage
    {
        public Decaff()
        {
            description = "Premium Decaf Coffee";

        }
        public override double cost()
        {
            if (size == "sm")
            {
                return 1.05;
            }
            if (size == "md")
            {
                return 1.30;
            }
            if (size == "lg")
            {
                return 1.8;
            }
            return 1.05;
        }
    }
}
