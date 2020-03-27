using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    private GameObject enemigo;
    private bool esta_viva; 
    private float distancia_umbral;
    private float tiempo_disparo;
    private GameObject[] balas;
    private Animator controlador;
    private int valor_actual;


    public Torre()      
    {
        Valor_actual1 = 150;
    }
   

    void Start()
    {
        distancia_umbral = 1.4f;
        tiempo_disparo = .8f;
        crearBalas(5);
        controlador = this.GetComponent<Animator>();

    }
   
	

	void Update () {
        Enemigo = BuscarEnemigoCercano();
        if (Enemigo != null && tiempo_disparo<=0)
        {
            Debug.DrawLine(this.transform.position, Enemigo.transform.position, Color.yellow);
            controlador.SetBool("atacar", true);
            Disparar();

            tiempo_disparo = 1f;
        }
        else
        {
            controlador.SetBool("atacar", false);
            tiempo_disparo -= Time.deltaTime;
        }
	}

    private void crearBalas(int total_balas)
    {
        balas = new GameObject[total_balas];
        for (int i = 0; i < balas.Length; i++)
        {
            balas[i] = Instantiate(GameObject.Find("Bala"), this.transform.position, Quaternion.identity);
        }
    }
    private Bala DespacharBalaLibre()
    {
        Bala libre = null;
        for (int i = 0; i < balas.Length; i++)
        {
            libre = balas[i].GetComponent<Bala>();
            if (!libre.Disparada)
            {
                break;
            }

        }
        return libre; 
    }
    void Disparar()
    {

        Bala bala = DespacharBalaLibre();
        bala.ActivarBala(this);
       
    }
    GameObject BuscarEnemigoCercano()
    {
        ArrayList enemigos = PoolingUnidades.unidades;
        GameObject temp;
        
        foreach (object item in enemigos)
        {

            temp = (GameObject)item;
            if (temp != null) // Verificacion de que temp existe podiendo realizar la operacion punto.
            {
                if (Vector3.Distance(temp.transform.position, this.transform.position) < distancia_umbral)
                {
                    return temp;
                }
            }
        }
        return null;
    }
    public GameObject Enemigo
    {
        get
        {
            return enemigo;
        }

        set
        {
            enemigo = value;
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

    public int Valor_actual1
    {
        get
        {
            return valor_actual;
        }

        set
        {
            valor_actual = value;
        }
    }
}
