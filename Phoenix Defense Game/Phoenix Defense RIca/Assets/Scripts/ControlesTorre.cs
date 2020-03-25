using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTorre : MonoBehaviour {
    [SerializeField]
    private GameObject btn_actualizar;
    [SerializeField]
    private GameObject btn_vender;

	// Use this for initialization
    private void OnMouseDown()
    {
        CambiarEstadoBotones(true);
    }
	void Start () {
        CambiarEstadoBotones(false);
	}
    public void CambiarEstadoBotones(bool estado)
    {
        btn_actualizar.SetActive(estado);
        btn_vender.SetActive(estado);
    }
   
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
