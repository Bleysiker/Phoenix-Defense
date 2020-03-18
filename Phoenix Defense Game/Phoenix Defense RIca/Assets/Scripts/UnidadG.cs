using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnidadG : MonoBehaviour {

    // Use this for initialization
    public GameObject ruta;
    private int indice;
<<<<<<< HEAD
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
    public float vel;
    private float tiempo;
<<<<<<< HEAD
    private float distancia_punto = 0.6f;
>>>>>>> parent of 44b4b08... 1
=======
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    public float vel = 0.5f;
    private float tiempo;
    private float distancia_punto = 0.6f;
>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje
=======
    private float distancia_punto;
>>>>>>> parent of 7728b27... Revert "1"
    private bool esta_viva;
    [SerializeField]
    private int vidas;
    private float delta_de_vida;
    private LogicaBarra lb;

    

    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;
>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje
=======
        vel = 0.2f;
        delta_de_vida = 0.15f / vidas;
        distancia_punto = 1f;
        esta_viva = true;
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;
        lb = this.GetComponent<LogicaBarra>();
>>>>>>> parent of 7728b27... Revert "1"
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        if (other.gameObject.tag == "Bala")
        {
            Destroy(other.gameObject);
=======
        if (otro.gameObject.tag == "Bala")
        {
            Destroy(otro.gameObject);
>>>>>>> parent of 44b4b08... 1
=======
        if (otro.gameObject.tag == "Bala")
        {
            Destroy(otro.gameObject);
>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje
=======
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
>>>>>>> parent of 7728b27... Revert "1"
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


