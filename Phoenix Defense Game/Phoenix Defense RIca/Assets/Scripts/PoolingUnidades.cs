    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour {

    //private int contesbirros;
    //private UnidadG verificaresbirros;
    //public GameObject boss1;

   // public Transform pboss1;
    public static ArrayList unidades = new ArrayList();

   /* public int Contesbirros
    {
        get
        {
            return contesbirros;
        }

        set
        {
            contesbirros = value;
        }
    }*/

    void Start () {
        //Contesbirros = 0;
        
        GameObject unidad1 = GameObject.FindGameObjectWithTag("Eagua");
        GameObject temp1;
        GameObject unidad2 = GameObject.FindGameObjectWithTag("Efuego");
        GameObject temp2;
        GameObject unidad3 = GameObject.FindGameObjectWithTag("Ehielo");
        GameObject temp3;

        GameObject unidad4 = GameObject.FindGameObjectWithTag("Bf");
        GameObject unidad5 = GameObject.FindGameObjectWithTag("Bh");
        GameObject unidad6 = GameObject.FindGameObjectWithTag("Ba");

        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicion_actual1 = unidad1.transform.position;
        Vector3 posicion_actual2 = unidad2.transform.position;
        Vector3 posicion_actual3 = unidad3.transform.position;
        
        unidades = new ArrayList();
        unidades.Add(unidad1);
        unidades.Add(unidad2);
        unidades.Add(unidad3);
        unidades.Add(unidad4);
        unidades.Add(unidad5);
        unidades.Add(unidad6);
        for (int i = 0; i < 9; i++)
        {
            temp1 = (GameObject)Instantiate(unidad1, posicion_actual1 + incremento, Quaternion.identity);
            posicion_actual1 = temp1.transform.position;
            unidades.Add(temp1);
            temp2 = (GameObject)Instantiate(unidad2, posicion_actual2+ incremento, Quaternion.identity);
            posicion_actual2 = temp2.transform.position;
            unidades.Add(temp2);
            temp3 = (GameObject)Instantiate(unidad3, posicion_actual3 + incremento, Quaternion.identity);
            posicion_actual3 = temp3.transform.position;
            unidades.Add(temp3);
        }

	}
	
	
	void Update () {
        /*if (Contesbirros == 7)
        {
            Instantiate(boss1, pboss1.transform.position, Quaternion.identity);
        }*/
	}
   /* public void Contarmuertes(int x)
    {
        Contesbirros=Contesbirros+x;
        Debug.Log("se han muerto: " + Contesbirros);
        
    }*/
}
