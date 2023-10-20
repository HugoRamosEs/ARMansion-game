using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalMainController : MonoBehaviour
{
    public GameObject botonMenu;
    public void OnClick()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
