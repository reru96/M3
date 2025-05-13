using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proiettile
{
    protected float velocit� = 10f;
    public abstract void Lancia();
}

public enum Element
{
    MAGIC,
    FIRE,
    ICE,
    ELECTRIC,
    HOLY,
    ARCANE
}

public class Freccia : Proiettile
{
    public string nome;

    public Freccia(float velocit�, string nome)
    {
        this.velocit� = velocit�;
        this.nome = nome;
    }

    public string _name
    {
        get => nome;
        set => nome = value;
    }

    public float _velocit�
    {
        get => velocit�;
        set => velocit� = value;
    }

    public override void Lancia()
    {
        Debug.Log(nome + " � stato lanciato. Velocit� di: " + velocit� + " m/s.");
    }
}

public class PallaMagica : Proiettile
{
    public string nome;
    public Element element;

    public PallaMagica(float velocit�, string nome, Element elem)
    {
        this.velocit� = velocit�;
        this.nome = nome;
        this.element = elem;
    }

    public float _velocit�
    {
        get => velocit�;
        set => velocit� = value;
    }

    public string _name
    {
        get => nome;
        set => nome = value;
    }

    public Element _element
    {
        get => element;
        set => element = value;
    }

    public override void Lancia()
    {
        Debug.Log(nome + " � stato lanciato. Velocit� di: " + velocit� + " m/s." + " Esplosione di tipo: " + element);
    }
}


