using UnityEngine;

public class OrcoDeMoria : Orco
{

    private float precisión;
    public OrcoDeMoria(string nombre, float fuerza, float resistencia, float destreza, float precision): 
        base(nombre,fuerza,resistencia, destreza)
    {
        this.precisión = precision;
    }

    public void Disparar(Orco objetivo) {
        //Chequear la distancia...

        objetivo.RecibirDaño(10f);
    }

    public void Gritar()
    {
        Debug.Log($"¡¡Soy {getNombre()} y soy un Orco de Moria!!");
    }


}
