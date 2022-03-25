using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Mododedisparo{
    SemiAuto,
    FullAuto

}

public class NewBehaviourScript : MonoBehaviour
{
    protected Animator animator;
    protected AudioSource audioSource;
    public bool Tiemponodisparo = false;
    public bool Puededisparar = false;
    public bool Recargar = false;

    [Header("Referencia de objetos")]
    public ParticleSystem fuegodeArma;
    
    [Header("Referencia de sonido")]
    public AudioClip SonidodeDisparo;
    public AudioClip SonidosinBalas;
    public AudioClip SonCartuchoon;
    public AudioClip SonCartuchooff;
    public AudioClip SonVacio;
    public AudioClip SonDesenfundar;

    [Header("Atributo de arma")]
    public Mododedisparo mododedisparo = Mododedisparo.FullAuto;
    public float dano= 20f; 
    public float ritmo = 0.3f;
    public int Balasrestantes;
    public int Tamanodecartucho = 12; 



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent <AudioSource>();
        animator = GetComponent <Animator>();

        BalasenCartucho = Tamanodecartucho;
        Balasrestantes = maximodebalas;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
