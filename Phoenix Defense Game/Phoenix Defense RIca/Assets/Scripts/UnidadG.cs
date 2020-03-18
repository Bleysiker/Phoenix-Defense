using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnidadG : MonoBehaviour {

    // Use this for initialization
    public GameObject ruta;
    private int indice;
<<<<<<< HEAD
    private Vector2 posicion_inicial;
    private Transform posicion_actual;
    private Transform posicion_siguiente;
    public float vel ;
    private float tiempo;
    private int vidas;
    private Vector3 posicion_muerte;
    private float distancia_punto ;
=======
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    public float vel = 0.5f;
    private float tiempo;
    private float distancia_punto = 0.6f;
>>>>>>> parent of 44b4b08... 1
    private bool esta_viva;

    

    void Start()
    {
<<<<<<< HEAD
        esta_viva = true;
        vel = .5f;
        distancia_punto = 0.6f;
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0);
=======
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;
>>>>>>> parent of 44b4b08... 1
    }
    // Update is called once per frame
    void Update() {

        if (esta_viva==false)
        {
            // Vector3 dir;
            //dir = posicion_siguiente - this.transform.position;
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
                    
                }
                else
                {
                    indice = 0;
                    transform.position = posicion_inicial;
                    posicion_siguiente = ruta.transform.GetChild(0);
                    posicion_actual = null;
                }
            }
            else
            {
                posicion_muerte = this.transform.position;
                this.transform.position = posicion_inicial;
            }

        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
<<<<<<< HEAD
        if (other.gameObject.tag == "Bala")
        {
            Destroy(other.gameObject);
=======
        if (otro.gameObject.tag == "Bala")
        {
            Destroy(otro.gameObject);
>>>>>>> parent of 44b4b08... 1
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
}


