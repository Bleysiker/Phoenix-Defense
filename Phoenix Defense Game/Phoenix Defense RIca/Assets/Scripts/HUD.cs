using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

    private static Hud instacia;

    [SerializeField]
    private Text monedas;
    private  int contador_monedas;

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
        instacia = this;
        Contador_monedas = 1000;
    }

    public  void ActualizarMoneda(int valor)
    {
        Contador_monedas += valor;
    }
    public static Hud GetInstance()
    {
        return instacia;
    }

    void Update () {
        monedas.text = Contador_monedas.ToString();
		
	}
}
