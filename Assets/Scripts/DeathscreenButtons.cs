using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathscreenButtons : MonoBehaviour
{
    // Este método reinicia la escena actual
    public void RestartGame()
    {
        Time.timeScale = 1f;  // Vuelve a activar el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Este método cierra el juego (solo funciona en build)
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("El juego se ha cerrado."); // Para pruebas en editor
    }
}
