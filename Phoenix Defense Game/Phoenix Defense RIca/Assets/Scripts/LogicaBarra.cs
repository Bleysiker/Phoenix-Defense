using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaBarra : MonoBehaviour {

    public GameObject esbirro;
    public GameObject barra_verde;
    public GameObject barra_roja;
    float escala = .001f;
    SpriteRenderer sr;
	// Use this for initialization
	void Start () {
        sr = barra_verde.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (sr.transform.localScale.x > 0)
        {
            sr.transform.localScale -= new Vector3(escala, 0);
            barra_verde.transform.position = esbirro.transform.position- new Vector3(.03f-sr.bounds.size.x/2 ,-.3f);
            barra_roja.transform.position = esbirro.transform.position - new Vector3(.05f,-3f);
        }
	}
}
