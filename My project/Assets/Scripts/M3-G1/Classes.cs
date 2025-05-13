using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proiettile
{
    protected float velocità = 10f;
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

    public Freccia(float velocità, string nome)
    {
        this.velocità = velocità;
        this.nome = nome;
    }

    public string _name
    {
        get => nome;
        set => nome = value;
    }

    public float _velocità
    {
        get => velocità;
        set => velocità = value;
    }

    public override void Lancia()
    {
        Debug.Log(nome + " è stato lanciato. Velocità di: " + velocità + " m/s.");
    }
}

public class PallaMagica : Proiettile
{
    public string nome;
    public Element element;

    public PallaMagica(float velocità, string nome, Element elem)
    {
        this.velocità = velocità;
        this.nome = nome;
        this.element = elem;
    }

    public float _velocità
    {
        get => velocità;
        set => velocità = value;
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
        Debug.Log(nome + " è stato lanciato. Velocità di: " + velocità + " m/s." + " Esplosione di tipo: " + element);
    }
}


