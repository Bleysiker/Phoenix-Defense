using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour {

    public static ArrayList unidades = new ArrayList();
	
	void Start () {
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
        for (int i = 0; i < 10; i++)
        {
            temp1 = (GameObject)Instantiate(unidad1, posicion_actual1 + incremento, Quaternion.identity);
          temp2 = (GameObject)Instantiate(unidad2, posicion_actual2 + incremento, Quaternion.identity);
            temp3 = (GameObject)Instantiate(unidad3, posicion_actual3 + incremento, Quaternion.identity);
            posicion_actual1 = temp1.transform.position;
            unidades.Add(temp1);
            posicion_actual2 = temp2.transform.position;
            unidades.Add(temp2);
            posicion_actual3 = temp3.transform.position;
            unidades.Add(temp3);
        }
	}
	
	
	void Update () {
		
	}
}
