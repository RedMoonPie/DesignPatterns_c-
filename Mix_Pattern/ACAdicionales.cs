using System;
namespace Mix_Pattern
{
    public abstract class ACAdicionales : ACPlatos
    {
        public abstract override string GetDescription();
    }

    public class PapaFrita : ACAdicionales
    {
        ACPlatos plato;

        public PapaFrita(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 3000 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Papas Fritas ";
        }


    }
    public class Aguacate : ACAdicionales
    {
        ACPlatos plato;

        public Aguacate(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 1500 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Aguacate ";
        }


    }
    public class Ensalada : ACAdicionales
    {
        ACPlatos plato;

        public Ensalada(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 2000 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Ensalada ";
        }

       
    }
    public class Sopa : ACAdicionales
    {
        ACPlatos plato;

        public Sopa(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 5000 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Sopa ";
        }

      
    }
    public class SalsaSoya : ACAdicionales
    {
        ACPlatos plato;

        public SalsaSoya(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 1500 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Salsa de Soya ";
        }

       
    }
    public class CostillasBBQ : ACAdicionales
    {
        ACPlatos plato;

        public CostillasBBQ(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 7000 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Costillas BBQ ";
        }

       
    }
    public class JugoCasa : ACAdicionales
    {
        ACPlatos plato;

        public JugoCasa(ACPlatos pPlato)
        {
            this.plato = pPlato;
        }
        public override double cost()
        {
            return 3000 + plato.cost();
        }

        public override string GetDescription()
        {
            return plato.GetDescription() + " + Jugo Casa ";
        }

      
    }
}
