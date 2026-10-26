using UnityEngine;
using UnityEngine.Rendering;

public class UrukhaiDeIsengard : Orco
{
    private float ira;

    public UrukhaiDeIsengard(string nombre, float fuerza, float resistencia, float destreza, float ira)
        : base(nombre, fuerza, resistencia, destreza)
    {
        this.ira = ira;
    }

    public override void Atacar(Orco objetivo)
    {
        float daño = CalcularDañoBasico();
        objetivo.RecibirDaño(daño);
        Debug.Log($"{getNombre()} ataca a {objetivo.getNombre()} e inflige {daño} de daño.");

    }

    public override void Gritar()
    {
        base.Gritar();
        Debug.Log($"¡¡Soy {getNombre()} y soy un Uruk-Hai!!");
    }

}
