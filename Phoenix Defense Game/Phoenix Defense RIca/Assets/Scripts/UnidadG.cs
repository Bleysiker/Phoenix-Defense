using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnidadG : MonoBehaviour {

    // Use this for initialization
    public GameObject ruta;
    private int indice;
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    public float vel;
    private float tiempo;
    private float distancia_punto;
    private bool esta_viva;
    [SerializeField]
    private int vidas;
    private float delta_de_vida;
    private LogicaBarra lb;

    

    void Start()
    {
        vel = 0.2f;
        delta_de_vida = 0.15f / vidas;
        distancia_punto = 1f;
        esta_viva = true;
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;
        lb = this.GetComponent<LogicaBarra>();
    }
    // Update is called once per frame
    void Update() {

        if (esta_viva==true)
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
}


