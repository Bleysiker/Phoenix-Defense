using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    public GameObject enemigo;
    private float distancia_umbral=2;
    void Start()
    {

    }
	
	// Update is called once per frame
	void Update () {
       float distancia = (enemigo.transform.position - this.transform.position).magnitude;
       
        if (distancia <= distancia_umbral)
        {
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.green);
        }
	}
}
