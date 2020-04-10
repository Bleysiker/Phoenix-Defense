﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarTorre : MonoBehaviour {

    private ControlesTorre ct;
    public Animator estados;
    private int valormejora;
    private HudG hud;


    public ActualizarTorre()
    {
        valormejora=50;

    }

    void Start () {
        ct = this.GetComponentInParent<ControlesTorre>();
        estados = this.GetComponentInParent<Animator>();    
	}	
    private void OnMouseDown()
    {
        hud = HudG.GetInstance();
        estados.SetInteger("Nivel", 1);
        ct.CambiarEstadoBotones(false);
        hud.DescontarSaldo(valormejora);
       
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
