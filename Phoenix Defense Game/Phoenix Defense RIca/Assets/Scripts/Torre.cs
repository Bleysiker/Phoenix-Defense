using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    private GameObject enemigo;
    private bool esta_viva; 
    private float distancia_umbral;
    private float tiempo_disparo;
    private GameObject[] balas;

   

    void Start()
    {
        distancia_umbral = 1.5f;
        tiempo_disparo = .8f;
        crearBalas(5);

    }
   
	

	void Update () {
        Enemigo = BuscarEnemigoCercano();
        if (enemigo != null && tiempo_disparo<=0)
        {
            Disparar();
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.yellow);
            tiempo_disparo = 1f;
        }
        else
        {
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
            if (Vector3.Distance(temp.transform.position, this.transform.position) < distancia_umbral)
            {
                return temp;
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
}
