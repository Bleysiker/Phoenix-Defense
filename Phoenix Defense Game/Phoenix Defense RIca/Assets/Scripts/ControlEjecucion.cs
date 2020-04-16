using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlEjecucion : MonoBehaviour,IPointerClickHandler {
    private bool habilitado;
    private AudioSource batalla;
    public void OnPointerClick(PointerEventData eventData)
    {
        HudG hud;
        hud = HudG.GetInstance();
        if (habilitado)
        {
            hud.Modo_ejecucion = HudG.EJECUCION;
            batalla.Play();
            //Debug.Log("click");
            habilitado = false;
        }
    }

    // Use this for initialization
    void Start () {
        batalla = this.GetComponent<AudioSource>();
        habilitado = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
