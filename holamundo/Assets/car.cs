using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class car : MonoBehaviour {
    float velocidad = 0.3f;
    public KeyCode teclaavanzar = KeyCode.W;
    public KeyCode teclagirarDr = KeyCode.D;
    public KeyCode teclagirarIz = KeyCode.A;
    public string nombre;
    int cuenta = 0;
    public GameObject canvas;
    bool heTerminado = false;
    public Text marcador;
    public Text winer;
    
    void Update() {
        
        



        if (heTerminado == false)
        {
            if (Input.GetKeyDown(teclagirarIz))
            {
                this.transform.Translate(new Vector3(-velocidad, 0, 0));
            }

            
            if (Input.GetKeyDown(teclagirarDr))
            {
                this.transform.Translate(new Vector3(velocidad, 0, 0));
            }

          if (Input.GetKeyDown(teclaavanzar))
            {
                this.transform.Translate(new Vector3(0, velocidad, 0));
                cuenta++;
                
                marcador.text = "" + cuenta;
            }
        }
        

    
        }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("El ganador es " + nombre);
        // velocidad = 0;
        heTerminado = true;
        winer.text = "el ganador es: " + nombre;
        velocidad = 0;
        
    }
}

