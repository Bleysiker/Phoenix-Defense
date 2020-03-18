using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour {

    public static ArrayList unidades = new ArrayList();
	
	void Start () {
<<<<<<< HEAD
<<<<<<< HEAD
        GameObject unidad1 = GameObject.FindGameObjectWithTag("Efuego");
        GameObject temp1;
        GameObject unidad2 = GameObject.FindGameObjectWithTag("Eagua");
       GameObject temp2;
        GameObject unidad3 = GameObject.FindGameObjectWithTag("Ehielo");
       GameObject temp3;
        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicion_actual1 = unidad1.transform.position;
        Vector3 posicion_actual2 = unidad2.transform.position;
        Vector3 posicion_actual3 = unidad3.transform.position;
=======
        GameObject unidad = GameObject.FindGameObjectWithTag("Enemigos");
        GameObject temp;
        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicion_actual = unidad.transform.position;
>>>>>>> parent of 44b4b08... 1
=======
        GameObject unidad = GameObject.FindGameObjectWithTag("Enemigos");
        GameObject temp;
        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicion_actual = unidad.transform.position;
>>>>>>> parent of 9283ba6... animaciones de magos y movimiento de personaje
        for (int i = 0; i < 10; i++)
        {
            temp = (GameObject)Instantiate(unidad, posicion_actual + incremento, Quaternion.identity);
            posicion_actual = temp.transform.position;
            unidades.Add(temp);  
        }
	}
	
	
	void Update () {
		
	}
}
