using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlEjecucion : MonoBehaviour,IPointerClickHandler {
    private bool habilitado;
     
    public void OnPointerClick(PointerEventData eventData)
    {
        HudG hud;
        hud = HudG.GetInstance();
        if (habilitado)
        {
            hud.Modo_ejecucion = HudG.EJECUCION;
            //Debug.Log("click");
            habilitado = false;
        }
    }

    // Use this for initialization
    void Start () {
        
        habilitado = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
