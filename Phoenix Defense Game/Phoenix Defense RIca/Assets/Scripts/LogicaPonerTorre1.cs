using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPonerTorre1 : MonoBehaviour {

    public GameObject torre1;
	void OnMouseDown()
    {
        GameObject temp;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + 0.3f;
       //pos.x = pos.x + 0.25f;
        temp = Instantiate(torre1);        
        temp.transform.position = pos;
        temp.layer = 5;
        Destroy(this.gameObject);
    }
}
