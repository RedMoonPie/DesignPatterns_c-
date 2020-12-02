using System;
namespace Decorator_pattern
{
    public abstract class ACBeverage
    {
        protected string description = "Unknown Beverage";
        protected string size = "default";
        public virtual string GetDescription()
        {
            return description;
        }

        public virtual string getSize()
        {
            return size;
        }
        public virtual void setSize(string size)
        {
            this.size = size;
        }

        public abstract double cost();
    }

    public abstract class ACCondimentDecorator : ACBeverage
    {
        public abstract override string GetDescription();
        
       
    }
}
