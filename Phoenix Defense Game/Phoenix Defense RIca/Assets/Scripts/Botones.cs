﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour {

    public void EscenaCambia(string escena)
    {
        SceneManager.LoadScene(1);
    }
	
}
