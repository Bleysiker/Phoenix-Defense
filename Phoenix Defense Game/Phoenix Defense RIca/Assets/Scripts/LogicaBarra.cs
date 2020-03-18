using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaBarra : MonoBehaviour {

   
    [SerializeField]
    public GameObject barraverde;
    [SerializeField]
    public GameObject barraroja;
    // float escala = 0.0001f;
    private SpriteRenderer sr;


    void Start() {

        sr = barraverde.GetComponent<SpriteRenderer>();
    }
    public void ModificarBarra(float escala)
    {
        if (sr.transform.localScale.x > 0)
        {
            sr.transform.localScale -= new Vector3(escala, 0);

        }
    }

void Update () {
        
	}
}
