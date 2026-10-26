using UnityEngine;
using UnityEngine.Rendering;

public class Orco
{

    //Atributos de la clase, privados
    private string nombre;
    private float fuerza;
    private float resistencia;
    private float destreza;

    private float vida;

    public Orco(string nombre, float fuerza, float resistencia, float destreza)
    {
        this.nombre = nombre;
        this.fuerza = fuerza;
        this.destreza = destreza;
        this.resistencia = resistencia;

        this.vida = 100 + this.resistencia * 5.0f;
    }

    public void Atacar(Orco objetivo)
    {
        float daño = CalcularDañoBasico();
        objetivo.RecibirDaño(daño);
        Debug.Log($"{nombre} ataca a {objetivo.nombre} e inflige {daño} de daño.");
    }

    private float CalcularDañoBasico()
    {
        //TODO 
        return 0.0f;
    }

    private void RecibirDaño(float daño)
    {
        this.vida -= daño;
    }




}
