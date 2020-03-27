using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarTorre : MonoBehaviour {

    private ControlesTorre ct;
    public Animator estados;  

    void Start () {
        ct = this.GetComponentInParent<ControlesTorre>();
        estados = this.GetComponentInParent<Animator>();    
	}	
    private void OnMouseDown()
    {
        estados.SetInteger("Nivel", 1);
        ct.CambiarEstadoBotones(false);
       
    }
	// Update is called once per frame
	void Update () {
		
	}

}
