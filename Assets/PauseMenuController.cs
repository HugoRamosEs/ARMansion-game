using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public static bool JuegoEnPausa = false;
    public GameObject MenuPausa;
    public GameObject joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoEnPausa)
            {
                Continuar();
            }
            else
            {
                Pausa();
            }
        }
    }
    public void Continuar()
    {
        MenuPausa.SetActive(false);
        joystick.SetActive(true);
        Time.timeScale = 1f;
        JuegoEnPausa = false;
    }
    void Pausa()
    {
        MenuPausa.SetActive(true);
        joystick.SetActive(false);
        Time.timeScale = 0f;
        JuegoEnPausa = true;
    }
    public void SalirMenu()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }

    //public void AyudaMenu()
    //{
    //Debug.Log("Ayuda");
    //}
}


