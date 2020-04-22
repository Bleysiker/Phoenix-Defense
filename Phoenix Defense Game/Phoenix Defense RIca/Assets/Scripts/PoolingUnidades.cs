    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour
{

  
    public static ArrayList unidades = new ArrayList();
    
    

    void Start()
    {
        unidades = new ArrayList();
        CrearPoolingUnidades();
        PosicionarUnidades();
    }


    void Update()
    {

    }
    public void CrearPoolingUnidades()
    {
        AgregarBoss("Bf");
        AgregarBoss("Ba");
        AgregarBoss("Bh");
        for (int i = 0; i < 10; i++)
        {
            CrearUnidad("Eagua");
            CrearUnidad("Efuego");
            CrearUnidad("Ehielo");
        }

        }
    public void CrearUnidad(string nombre)
    {
        GameObject temp;
        GameObject unidad = GameObject.FindGameObjectWithTag(nombre);
        temp = (GameObject)Instantiate(unidad, Vector3.zero, Quaternion.identity);
        if (!unidades.Contains(unidad))
        {
            unidades.Add(unidad);
        }
        unidades.Add(temp);
    }
    public void AgregarBoss(string  nombre)
    {
        
        GameObject unidad = GameObject.FindGameObjectWithTag(nombre);
        unidades.Add(unidad);
    }
    
    public void PosicionarUnidades()
    {
        Vector3 incremento = new Vector3(1, 0);
        Vector3 posicion_actual = new Vector3(0,4);
        foreach (GameObject item in unidades)
        {
            item.transform.position = posicion_actual;
            posicion_actual = posicion_actual + incremento;
        }
    }
}