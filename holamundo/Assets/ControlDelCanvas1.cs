using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public interface IMisEventosCanvas : IEventSystemHandler
{
    // functions that can be called via the messaging system
    void MostrarPuntos(int valor);
}

public class ControlDelCanvas1 : MonoBehaviour, IMisEventosCanvas
{
    public Text marcador;
    public Text marcador2;

    public void MostrarPuntos(int valor)
    {
        marcador.text = "Puntos: " + valor;
        marcador2.text = "Puntos: " + valor;
    }
}
