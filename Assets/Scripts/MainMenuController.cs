using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("PlantaPrincipal", LoadSceneMode.Single);
    }

    // Update is called once per frame
    public void Quit()
    {
        Debug.Log("Cerrado!");
        Application.Quit();
    }
}
