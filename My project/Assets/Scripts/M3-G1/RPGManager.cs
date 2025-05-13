using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RPGManager : MonoBehaviour
{

    public Enemy boss = new Enemy("Sauron", 30, 10);

    // Start is called before the first frame update
    void Start()
    {
       List<Characther> c = new List<Characther>();
       c.Add (new Warrior ( "Aragorn" ,50, 10));
       c.Add (new Mage ("Gandalf", 45 , 12, Element.MAGIC));
       c.Add(new Archer("Legolas", 45, 7));

        foreach (Characther ch in c)
        {

            int damage = ch.Attack();
            boss.TakeDamage(damage);
            int damage2 = Random.Range(1, 20 + 1);
            ch.TakeDamage(damage2);
            
            if (ch.IsDead())
            { 
                Debug.Log(ch._name + " è stato sconfitto!"); 
            }
        }
        if (boss.IsDead())
        {
            Debug.Log(boss._name + " è stato sconfitto!");
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
