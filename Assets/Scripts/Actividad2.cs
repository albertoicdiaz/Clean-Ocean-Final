﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actividad2 : MonoBehaviour
{
    public Conexiones conexiones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void act2(){
        SceneManager.LoadScene("CargaSuma");
        conexiones.PlayTimeSuma();
    }
}