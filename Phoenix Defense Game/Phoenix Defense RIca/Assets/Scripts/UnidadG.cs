using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnidadG : MonoBehaviour {

    // Use this for initialization
    public GameObject ruta;
    private int indice;
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    public float vel = 0.5f;
    private float tiempo;
    private float distancia_punto = 0.6f;
    private bool esta_viva;

    

    void Start()
    {
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;
    }
    // Update is called once per frame
    void Update() {

        if (esta_viva==false)
        {
            Vector3 dir;
            dir = posicion_siguiente - this.transform.position;
            dir.z = 0;
            this.transform.position += dir * vel * Time.deltaTime;
            if (dir.magnitude <= distancia_punto)
            {
                if (indice + 1 < ruta.transform.childCount)
                {
                    indice++;
                    posicion_siguiente = ruta.transform.GetChild(indice).position;
                }
            }

        }
        
    }
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Bala")
        {
            Destroy(otro.gameObject);
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


