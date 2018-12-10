using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rumrum : MonoBehaviour
{

    public KeyCode teclaAsignada = KeyCode.F1;
    float velocidad = 0.2f;
    public string nombre;
    int cuenta = 0;
    public Text marcador1;
    public Text winer;
    // Update is called once per frame
    void Update()
    {
        if (cuenta==115)
        {
            winer.text ="el ganador es: "+nombre;
          
        }
        else
        {
            if (Input.GetKeyDown(teclaAsignada))
            {
                this.transform.Translate(new Vector3(0, velocidad, 0));
                cuenta++;
                marcador1.text = "" + cuenta;

            }
            
        }


    }
}