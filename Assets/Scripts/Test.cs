using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    //Definición de variables de este script (un script es una clase en este contexto)
    Orco orc1;
    Orco orc2;

    OrcoDeMoria orcDeMoria1;
    OrcoDeMoria orcDeMoria2;

    UrukhaiDeIsengard orcUrukHai1;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        MyVector3 vec1 = new MyVector3();

        MyVector3 vec2 = new MyVector3(10f, 10f, 4);

        float magnVec2 = vec2.Magnitude();

















        /*
        //Inicialización de los dos orcos
        orc1 = new Orco("Grizhnah", 9f, 8f, 2f);
        orc2 = new Orco("Rethz", 5f, 3f, 8f);

        orcDeMoria1 = new OrcoDeMoria("Pepito", 5f, 5f, 5f, 8f);
        orcDeMoria2 = new OrcoDeMoria("Pepito Segundo", 5f, 5f, 5f, 1f);

        orcUrukHai1 = new UrukhaiDeIsengard("Fernando", 7f,7f,5f,7f);

        /*
        orcDeMoria1.Gritar();
        orcUrukHai1.Gritar();

        orcDeMoria1.Disparar(orcDeMoria2);

        orc1.Gritar();
        orc2.Gritar();
        */
        /*
        List<Orco> orcList = new List<Orco>();

        orcList.Add(orc1);
        orcList.Add(orc2);
        orcList.Add(orcDeMoria1);
        orcList.Add(orcDeMoria2);
        orcList.Add(orcUrukHai1);
        */
        /*
        foreach (Orco o in orcList)
        {
            o.Gritar();
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
