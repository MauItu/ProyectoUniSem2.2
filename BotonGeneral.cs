using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonGeneral : MonoBehaviour
{
    
    public ControladorJuego controlador;

    public bool ReiniciarPuntaje;
    public bool EsPreguntaFinal;
    public void CargarNivel(string nombreNivel)
    {
        ControlPuntos.IncrementarPuntos(0);
        
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

        else if(ReiniciarPuntaje)
        {
            controlador.ReiniciarPuntosYCambiarEscena(nombreNivel);
        }
        else
        {
            //Muestralacantidad de puntos en consola
            Debug.Log(ControlPuntos.Puntos);
            controlador.CargarScena(nombreNivel);
        }
        

    }
}