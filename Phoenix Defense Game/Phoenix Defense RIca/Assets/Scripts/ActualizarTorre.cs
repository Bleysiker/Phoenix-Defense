using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarTorre : MonoBehaviour {

    private ControlesTorre ct;
    public Animator estados;
    private int valormejora;
    private HudG hud;
    public GameObject mejora;
    public GameObject child;

    public ActualizarTorre()
    {
        Valormejora = 150;

    }

    void Start () {
        ct = this.GetComponentInParent<ControlesTorre>();
        estados = this.GetComponentInParent<Animator>();
      

    }
    private void OnMouseDown()
    {
        hud = HudG.GetInstance();

        if (Valormejora < hud.Contador_monedas)
        {
            estados.SetInteger("Nivel", 1);
            Instantiate(mejora, this.transform.position, Quaternion.identity);
            ct.CambiarEstadoBotones(false);
            child.SetActive(true);
            hud.DescontarSaldo(Valormejora);
        }
        else 
        {
            hud.ErrorSaldo();
        }

    }
    // Update is called once per frame
    void Update () {
		
	}
    public int Valormejora
    {
        get
        {
            return valormejora;
        }

        set
        {
            valormejora = value;
        }
    }

}
