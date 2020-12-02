using System;
namespace Mix_Pattern
{
    public interface ACSujeto
    {
         void RegistrarObservador(ACObserver o);
         void RemoverObservador(ACObserver o);
         void NotificarObsevadores(ACPlatos pPlato, object arg);
    }
    public interface ACObserver {

         void update(ACPlatos obs, object arg );


        
    }

    public interface ACMostrar
    {
         void mostrar(string plato, int cantidad);
    }

}
