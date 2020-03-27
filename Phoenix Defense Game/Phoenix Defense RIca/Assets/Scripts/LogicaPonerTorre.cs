using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPonerTorre : MonoBehaviour {
    [SerializeField]
    private GameObject go_torre;
    private HudG hud;
    private Torre torre;

    void OnMouseDown()
    {
        GameObject temp;

         Vector3 pos = this.transform.position;
         pos.y = pos.y + 0.48f;
         pos.x = pos.x + 0.25f;
         temp = (GameObject)Instantiate(go_torre, pos, Quaternion.identity);
         temp.transform.position = pos;
         temp.layer = 5;
        hud = HudG.GetInstance();

        torre = temp.GetComponentInChildren<Torre>();       


        if (torre.Valor_actual1 < hud.Contador_monedas)
        {
            torre.Esta_viva = true;
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
