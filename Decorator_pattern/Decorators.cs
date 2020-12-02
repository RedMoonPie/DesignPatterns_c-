using System;
namespace Decorator_pattern
{
    public class Mocha : ACCondimentDecorator
    {
        ACBeverage beverage;
        public Mocha(ACBeverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
        public override double cost()
        {
          
            if (beverage.getSize() == "sm")
            {
                return .20 + beverage.cost();
            }
            if (beverage.getSize() == "md")
            {
                return .25 + beverage.cost();
            }
            if (beverage.getSize() == "lg")
            {
                return .30 + beverage.cost();
            }
            return beverage.cost() + .20;
        }
    }


    public class SteamedMilk : ACCondimentDecorator
    {
        ACBeverage beverage;
        public SteamedMilk(ACBeverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }
        public override double cost()
        {
            if (beverage.getSize() == "sm")
            {
                return .10 + beverage.cost();
            }
            if (beverage.getSize() == "md")
            {
                return .15 + beverage.cost();
            }
            if (beverage.getSize() == "lg")
            {
                return .20 + beverage.cost();
            }
            return beverage.cost() + .10;
        }
    }



    public class Soy : ACCondimentDecorator
    {
        ACBeverage beverage;
        public Soy(ACBeverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
        public override double cost()
        {
            if (beverage.getSize() == "sm")
            {
                return .15 + beverage.cost();
            }
            if (beverage.getSize() == "md")
            {
                return .20 + beverage.cost();
            }
            if (beverage.getSize() == "lg")
            {
                return .25 + beverage.cost();
            }
            return beverage.cost() + .15;
        }

    }




    public class whip : ACCondimentDecorator
    {
        ACBeverage beverage;
        public whip(ACBeverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";

        }
        public override double cost()
        {
            if (beverage.getSize() == "sm")
            {
                return .10 + beverage.cost();
            }
            if (beverage.getSize() == "md")
            {
                return .15 + beverage.cost();
            }
            if (beverage.getSize() == "lg")
            {
                return .20 + beverage.cost();
            }
            return beverage.cost() + .10;

        }

    }



    public class large : ACCondimentDecorator
    {
        ACBeverage beverage;
        public large(ACBeverage beverage)
        {   
            this.beverage = beverage;

        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Large ";

        }
        public override double cost()
        {
            return beverage.cost();
        }

    }







}
   
