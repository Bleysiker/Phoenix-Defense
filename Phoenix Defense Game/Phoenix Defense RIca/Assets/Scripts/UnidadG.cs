using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnidadG : MonoBehaviour {

    // Use this for initialization
    public GameObject ruta;
    private int indice;
    private float tiempo;

	
	// Update is called once per frame
	void Update () {
		if (tiempo > 0.5){
            if (indice < ruta.transform.childCount)
            {
                Debug.Log(ruta.transform.GetChild(indice).transform.position.x + "" + ruta.transform.GetChild(indice).transform.position.y);
                this.transform.position = new Vector3(ruta.transform.GetChild(indice).transform.position.x, ruta.transform.GetChild(indice).transform.position.y, this.transform.position.z);  
                    indice++;

            }
            tiempo = 0;
        }
        else
        {
            tiempo += Time.deltaTime;
        }
	}
}
