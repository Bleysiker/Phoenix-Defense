using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPonerTorre1 : MonoBehaviour {
    [SerializeField]
    private GameObject torre1;
    private HudG hud;
    private Torre torre;

    void OnMouseDown()
    {
        GameObject temp;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + 0.3f;
       //pos.x = pos.x + 0.25f;
        temp = (GameObject)Instantiate(torre1,pos,Quaternion.identity);        
        temp.transform.position = pos;
        temp.layer = 5;
        hud = HudG.GetInstance();        
        torre = temp.GetComponentInChildren<Torre>();
        

        if (torre.Valor_actual1 < hud.Contador_monedas)
        {
            torre.Esta_viva = false;
            Destroy(this.gameObject);
            hud.DescontarSaldo(torre.Valor_actual1);

        }
        else
        {
            Destroy(temp);
            hud.ErrorSaldo();
        }

    }
}
