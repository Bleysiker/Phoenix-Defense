using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidad : MonoBehaviour {
	public GameObject ruta;
	private int indice;
	private Vector3 posicion_siguiente;
	public float velocidad;
	private float distancia_punto=0.5f;

	// Use this for initialization
	void Start(){
		posicion_siguiente = ruta.transform.GetChild (0).position;

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 dir = posicion_siguiente - this.transform.position;
		this.transform.position += dir * velocidad * Time.deltaTime;

		if (dir.magnitude<=distancia_punto) {
			if (indice+1 < ruta.transform.childCount) {
				indice++;
				posicion_siguiente = ruta.transform.GetChild (indice).position;
				Debug.Log ("xs"+posicion_siguiente.x+"ys"+posicion_siguiente.y);

					
			}

		} else {


		}

	}
}
