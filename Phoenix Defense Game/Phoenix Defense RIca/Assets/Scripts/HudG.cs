using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudG : MonoBehaviour {

    private static HudG instancia;
    [SerializeField]
    private Text monedas;
    [SerializeField]
    private Text vidas;
    private int contador_monedas;
    private int contador_vidas;
    private uint modo_ejecucion;

    public const uint CONSTRUCCION=1;
    public const uint EJECUCION = 2;


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

    public uint Modo_ejecucion
    {
        get
        {
            return modo_ejecucion;
        }

        set
        {
            modo_ejecucion = value;
        }
    }

    private void Start()
    {
        modo_ejecucion = CONSTRUCCION;
        contador_monedas = 1000;
        contador_vidas = 30;
        instancia = this;
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
        vidas.text = contador_vidas.ToString();
	}
    public void Descontarvidas()
    {
        if (contador_vidas-1>0)
        {

            contador_vidas--;
        }
        else
        {
            //juego termina
        }
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
