﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    private GameObject enemigo;
    private bool esta_viva; 
    private float distancia_umbral=2;

   

    void Start()
    {

    }
	
    void Disparar()
    {
        GameObject obj = (GameObject)Instantiate(GameObject.Find("Bala"), this.transform.position, Quaternion.identity);
        Bala bala = obj.GetComponent<Bala>();
        bala.ActivarBala(this);
    }
	GameObject BuscarEnemigoCercano()
    {
        ArrayList enemigos = PoolingUnidades.unidades;
        GameObject temp ;
        foreach(object item in enemigos)
        {
            temp = (GameObject)item;
            if (Vector3.Distance(temp.transform.position, this.transform.position) < distancia_umbral)
            {
                return temp;
            }
        }
        return null;
    }

	void Update () {
        Enemigo = BuscarEnemigoCercano();
        if (enemigo != null)
        {
            Disparar();
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.yellow);
        }
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
