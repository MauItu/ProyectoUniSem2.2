using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonGanador : MonoBehaviour
{
    public ControladorJuego controlador;
    
    public bool EsPreguntaFinal;
    public void CargarNivel(string nombreNivel)
    {
        ControlPuntos.IncrementarPuntos(10);
        
        if(EsPreguntaFinal)
        {
            if (ControlPuntos.Puntos >= 30)
            {
                controlador.CargarScena(nombreNivel);
            }
            else
            {
                controlador.CargarScena(nombreNivel);
            }
        }

        else
        {
            //Muestralacantidad de puntos en consola
            Debug.Log(ControlPuntos.Puntos);
            controlador.CargarScena(nombreNivel);
        }

    }

    
}