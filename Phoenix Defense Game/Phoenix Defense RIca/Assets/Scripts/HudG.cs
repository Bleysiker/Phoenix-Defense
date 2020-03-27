using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudG : MonoBehaviour {

    private static HudG instancia;
    [SerializeField]
    private Text monedas;
    private int contador_monedas;
  
    public int Contador_monedas
    {
        get
        {
            return contador_monedas;
        }

        set
        {
            contador_monedas = value;
        }
    }
   
    private void Start()
    {
        instancia = this;
        contador_monedas = 1000;
    }
    public void ActualizaMonedas(int total)
    {
        Contador_monedas += total;
    }

    public static HudG GetInstance()
    {
        return instancia;
    }
    void Update () {

        monedas.text = Contador_monedas.ToString();
		
	}
    public void DescontarSaldo(int valor)
    {
        contador_monedas -= valor;
        StartCoroutine("CambiarColor", Color.black);
    }
    public void ErrorSaldo()
    {
        StartCoroutine("CambiarColor", Color.red);
    }
    public IEnumerator CambiarColor(Color color)
    {
        monedas.color = color;
        yield return new WaitForSeconds(.5f);
        ResetearColorSaldo();
    }
    public void ResetearColorSaldo()
    {
        monedas.color = Color.white;
    }
}
