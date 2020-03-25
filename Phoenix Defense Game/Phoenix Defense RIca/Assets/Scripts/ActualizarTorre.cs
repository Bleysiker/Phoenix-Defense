using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarTorre : MonoBehaviour {

    private ControlesTorre ct;
    public GameObject ki;
    public Transform inicio_t;

   

    // Use this for initialization
    void Start () {
        ct = this.GetComponentInParent<ControlesTorre>();
        
	}
	
    private void OnMouseDown()
    {
        ct.CambiarEstadoBotones(false);
        Instantiate(ki, this.inicio_t.position,Quaternion.identity);
    }
	// Update is called once per frame
	void Update () {
		
	}

}
