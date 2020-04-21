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
    [SerializeField]
    private Canvas muerte;
    private int contador_monedas;
    private int contador_vidas;
    private uint modo_ejecucion;
   
    private AudioSource sonido;
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
        sonido = this.GetComponent<AudioSource>();
        modo_ejecucion = CONSTRUCCION;
        contador_monedas = 300;
        contador_vidas = 25;
        instancia = this;
        muerte.enabled = false;
    }
    public void ActualizaMonedas(int total)
    {
        Contador_monedas += total;
        sonido.Play();
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
        else //GameOver
        {
            muerte.enabled = true;
            Time.timeScale = 0;
        }
    }
    public void DescontarSaldo(int valor)
    {
        contador_monedas -= valor;
        StartCoroutine("CambiarColor", Color.black);
        sonido.Play();
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
