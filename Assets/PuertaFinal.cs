using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaFinal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hola");
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Final", LoadSceneMode.Single);
        }
    }
}
