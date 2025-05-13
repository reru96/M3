using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Esercizio_1 : MonoBehaviour
{
  
    // Start is called before the first frame update
        void Start()
        {
            Proiettile[] p1 = new Proiettile[3];
            p1[0] = new Freccia(15f, "Freccia");
            p1[1] = new PallaMagica(20f, "Firaga", Element.FIRE);
            p1[2] = new PallaMagica(25f, "Thunderaga", Element.ELECTRIC);

            foreach (Proiettile p in p1)
            {
                p.Lancia();
            }
        }
        void Update()
        {
        
        }
}

    // Update is called once per frame
    

