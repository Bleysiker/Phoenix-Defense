    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour {

    public static ArrayList unidades = new ArrayList();
	
	void Start () {
        GameObject unidad = GameObject.FindGameObjectWithTag("Enemigos");
        GameObject temp;
        Vector3 incremento = new Vector3(0, 2);
        Vector3 posicion_actual = unidad.transform.position;
        unidades = new ArrayList();
        unidades.Add(unidad);
        for (int i = 0; i < 7; i++)
        {
            temp = (GameObject)Instantiate(unidad, posicion_actual + incremento, Quaternion.identity);
            posicion_actual = temp.transform.position;
            unidades.Add(temp);  
        }
	}
	
	
	void Update () {
		
	}
}
