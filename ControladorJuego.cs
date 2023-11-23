using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour
{
    public static void EvaluarPuntosYCambiarEscena(int puntos, string nombreNivel)
    {
        if (puntos >= 30)
        {
            SceneManager.LoadScene("FinalBueno");
        }
        else
        {
            SceneManager.LoadScene("FinalMalo");
        }
    }

    public void ReiniciarPuntosYCambiarEscena(string nombreNivel)
    {
        ControlPuntos.ReiniciarPuntos();
        SceneManager.LoadScene(nombreNivel);
    }
    public void CargarScena(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
}
