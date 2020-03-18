using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    public const float Tiempo_Disparo = .5f;
    private GameObject objetivo;
    private float velocidad;
    private bool disparada;

    private Vector3 punto_inicial;

    private float tiempo;
    private SpriteRenderer sr;

    public bool Disparada
    {
        get
        {
            return disparada;
        }

        set
        {
            disparada = value;
        }
    }

    void Start () {
        velocidad = 7f;
        sr = this.GetComponent<SpriteRenderer>();
        punto_inicial = new Vector3(-5, 4);
        CambiarOpacidad(0f);

	}
	
	
	void Update () {

     
        if (objetivo != null)
        {
            if (TiempoVida())
            {
                MoverBalaAUnPunto();
            }
            else
            {
                ReciclarBala();
            }

        }
        if (!Disparada)
        {
            ReciclarBala();
        }

	}
    private bool TiempoVida()
    {
        tiempo += Time.deltaTime;
        return tiempo < Tiempo_Disparo;
    }

    private void MoverBalaAUnPunto()
    {
        Vector3 direccion;
        UnidadG unidad = objetivo.GetComponent<UnidadG>();

        if (unidad.Esta_viva)
        {
            Disparada = true;
            direccion = objetivo.transform.position - this.transform.position;
            this.transform.position += velocidad * direccion * Time.deltaTime;
        }
    }
    private void CambiarOpacidad(float valor)
    {
        sr.color = new Color(1f, 1f, 1f, valor);
    }
    private void ReciclarBala()
    {
        this.transform.position = punto_inicial;
        objetivo = null;
        Disparada = false;
        CambiarOpacidad(0f);
        tiempo = 0;
    }
    public void ActivarBala(Torre torre)
    {
        Disparada = true;
        objetivo = torre.Enemigo;
        tiempo = 0;
        punto_inicial = torre.transform.position;
        transform.position = punto_inicial;
        CambiarOpacidad(1f);
    }
}
