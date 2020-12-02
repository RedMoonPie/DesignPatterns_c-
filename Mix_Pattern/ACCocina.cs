using System;
using System.Collections;

namespace Mix_Pattern
{
    public abstract class ACCocina:ACSujeto
    {
        protected ArrayList observadores;
        protected Boolean cambio;
        public ACCocina()
        {
            observadores = new ArrayList();
        }
        public void NotificarObsevadores(ACPlatos pPlato, object arg)
        {
            if (cambio)
            {
                foreach (ACObserver obs in observadores)
                {

                    obs.update(pPlato, arg);
                }
                cambio = false;
            }
        }

        public void RegistrarObservador(ACObserver o)
        {
            observadores.Add(o);
        }

        public void RemoverObservador(ACObserver o)
        {
            int i = observadores.IndexOf(o);
            if (i >= 0)
            {
                observadores.Remove(i);
            }
        }
        public abstract void MeasurementsCHanged();
        public abstract int AbastecerPlatos(ACPlatos plato);
        public abstract void agregarPlato(ACPlatos plato);
        public abstract void setChanged();
    }
}
