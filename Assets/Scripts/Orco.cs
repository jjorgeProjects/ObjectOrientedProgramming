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

        vida = 100 + this.resistencia * 5.0f;
    }

    public virtual void Atacar(Orco objetivo)
    {
        float daño = CalcularDañoBasico();
        objetivo.RecibirDaño(daño);
        Debug.Log($"{nombre} ataca a {objetivo.nombre} e inflige {daño} de daño.");
    }

    public float CalcularDañoBasico()
    {
        //TODO 
        return 0.0f;
    }

    public void RecibirDaño(float daño)
    {
        vida -= daño;
    }

    public virtual void Gritar()
    {
        Debug.Log($"¡¡Soy {nombre}!!");
    }

    public float getFuerza()
    {
        return fuerza;
    }

    public void setFuerza(float fuerza)
    {
        this.fuerza = fuerza;
    }

    public float getVida()
    {
        return vida;
    }

    public string getNombre()
    {
        return nombre;
    }

    public void setVida(float vida)
    {
        this.vida = Mathf.Clamp(vida,0f,100f) ;
    }





}
