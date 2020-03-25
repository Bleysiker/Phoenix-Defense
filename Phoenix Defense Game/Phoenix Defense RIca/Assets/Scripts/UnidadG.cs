﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnidadG : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    public GameObject ruta;
    [SerializeField]
    public float vel;
    [SerializeField]
    private int vidas;
    [SerializeField]
    private int valor_muerte;
    private int indice;

    private Vector2 posicion_inicial;
    private Transform posicion_siguiente;
    private Transform posicion_actual;
   
    private float tiempo;
    private float distancia_punto;
    private bool esta_viva;
    [SerializeField]
    private Vector3 posicion_muerte;
    
    private float delta_de_vida;
    private LogicaBarra lb;

    private Hud inst;

    

    void Start()
    {
        vel = 1;
        delta_de_vida = 0.15f / vidas;
        distancia_punto = 1f;
        esta_viva = true;
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0);
        inst = new Hud();
        lb = this.GetComponent<LogicaBarra>();
    }
    // Update is called once per frame
    void Update() {

        if (esta_viva==true)
        {
            // Vector3 dir;
            // dir = posicion_siguiente - this.transform.position;
            //dir.z = 0;
            transform.position = Vector2.MoveTowards(transform.position, posicion_siguiente.position, vel * Time.deltaTime);
            //this.transform.position += dir * vel * Time.deltaTime;
            if (Vector2.Distance(transform.position,posicion_siguiente.position)<distancia_punto)
            {
                if (indice + 1 < ruta.transform.childCount)
                {
                    indice++;
                    posicion_actual = posicion_siguiente;
                    posicion_siguiente = ruta.transform.GetChild(indice);
                    //CambiarPosicion();

                }
                else
                {
                    indice = 0;
                    transform.position = posicion_inicial;
                    posicion_siguiente = ruta.transform.GetChild(0);
                    posicion_actual = null;
                }
            }

        }
        
    }
    void OnTriggerEnter2D(Collider2D otro)
    {
        Bala bala;
        if (vidas > 0)
        {
            if (otro.gameObject.tag == "Bala")
            {
                bala = otro.gameObject.GetComponent<Bala>();
                bala.Disparada = false;
                if (--vidas == 0)
                {
                    esta_viva = false;
                    inst.ActualizarMoneda(valor_muerte);
                    Debug.Log("Se murio la unidad");

                    Destroy(this.gameObject);

                }
                else
                {
                    lb.ModificarBarra(delta_de_vida);                    
                }
                
            }
        }
        
    }
        public bool Esta_viva
    {
        get
        {
            return esta_viva;
        }

        set
        {
            esta_viva = value;
        }
    }

    public Vector3 Posicion_muerte
    {
        get
        {
            return posicion_muerte;
        }

        set
        {
            posicion_muerte = value;
        }
    }
}


