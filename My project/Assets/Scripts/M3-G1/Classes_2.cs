using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public abstract class Characther
{
    protected string nome;
    protected int hp;

    public Characther(string name, int hp)
    {
        this.nome = name;
        this.hp = hp;
    }
    public string _name
    {
        get => nome;
        set => nome = value;
    }
    public int _hp
    {
        get => hp;
        set => hp = value;
    }
    public abstract int Attack();
    public abstract int TakeDamage(int damage);

    public abstract bool IsDead();
  
}

public class Enemy : Characther
{
    public int damage;
    public Enemy(string name, int hp, int weapon) : base(name, hp)
    {
        this.damage = weapon;
    }

    public int _damage
    {
        get => damage;
        set => damage = value;
    }

    public override int Attack()
    {
        Debug.Log(nome + " attacca e infligge " + damage + " danni");
        return damage;
    }


    public override int TakeDamage(int damage)
    {
        hp = Mathf.Max(hp - damage, 0);
        Debug.Log(nome + " prende " + damage + " danni." + " HP attuali: " + hp);
        return hp;
    }
    public override bool IsDead()
    {
        return hp <= 0;
    }

}

public class Warrior : Characther
{
    public int damage;
    public Warrior(string name, int hp, int weapon) : base(name, hp)
    {
        this.damage = weapon;
    }

    public int _damage
    {
        get => damage;
        set => damage = value;
    }

    public override int Attack()
    {
        Debug.Log(nome + " attacca e infligge " + damage + " danni");
        return damage;
    }


    public override int TakeDamage(int damage)
    {
        hp = Mathf.Max(hp - damage, 0);
        Debug.Log(nome + " prende " + damage + " danni." + " HP attuali: " + hp);
        return hp;
    }

    public override bool IsDead()
    {
        return hp <= 0;
    }

}

public class Mage : Characther
{
    public int damage;
    Element element;
    public Mage(string name, int hp, int weapon, Element element) : base(name, hp)
    {
        this.damage = weapon;
        this.element = element;
    }

    public int _damage
    {
        get => damage;
        set => damage = value;
    }

    public override int Attack()
    {
        Debug.Log(nome + " attacca e infligge " + damage + " danni di tipo: " + element);
        return damage;
    }


    public override int TakeDamage(int damage)
    {
        hp = Mathf.Max(hp - damage, 0);
        Debug.Log(nome + " prende " + damage + " danni." + " HP attuali: " + hp);
        return hp;
    }

    public override bool IsDead()
    {
        return hp <= 0;
    }
}

public class Archer : Characther
{
    public int damage;
    public Archer(string name, int hp, int weapon) : base(name, hp)
    {
        this.damage = weapon;
    }

    public int _damage
    {
        get => damage;
        set => damage = value;
    }

    public override int Attack()
    {
        int freccia1 = damage;
        int freccia2 = damage;
        Debug.Log(nome + " attacca con la prima freccia e infligge " + damage + " danni");
        Debug.Log(nome + " attacca con la seconda freccia e infligge " + damage + " danni");
        return freccia1 + freccia2;
    }


    public override int TakeDamage(int damage)
    {
        hp = Mathf.Max(hp - damage, 0);
        Debug.Log(nome + " prende " + damage + " danni." + " HP attuali: " + hp);
        return hp;
    }

    public override bool IsDead()
    {
        return hp <= 0;
    }

}