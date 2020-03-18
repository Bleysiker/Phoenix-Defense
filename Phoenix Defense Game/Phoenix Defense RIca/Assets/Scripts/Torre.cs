using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    private GameObject enemigo;
    private bool esta_viva; 
    private float distancia_umbral=2;
<<<<<<< HEAD
<<<<<<< HEAD
    private Animator controlador;
=======
>>>>>>> parent of 44b4b08... 1
=======
>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje

   

    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        controlador = this.GetComponent<Animator>();
=======

>>>>>>> parent of 44b4b08... 1
=======

>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje
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
<<<<<<< HEAD
<<<<<<< HEAD
            controlador.SetBool("atacar", true);
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.yellow);
        }
        else
        {
            controlador.SetBool("atacar", false);
        }
=======
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.yellow);
        }
>>>>>>> parent of 44b4b08... 1
=======
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.yellow);
        }
>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje
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
