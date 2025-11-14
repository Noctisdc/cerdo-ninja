using System;
using UnityEditor;
using UnityEngine;

public class botonpausa : MonoBehaviour
{
    [SerializeField] private GameObject Botonpausa;
    [SerializeField] private GameObject menupausa;

    public void pausa()
    {
        Time.timeScale = 0f;
        Botonpausa.SetActive(false);
        menupausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        Botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }
    public void cerrar()
    {
        Application.Quit();
        Debug.Log("Cerrando...");
    }
}
