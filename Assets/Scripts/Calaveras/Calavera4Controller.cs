using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calavera4Controller : MonoBehaviour
{
    public GameObject imagenPrueba4;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba4.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba4.SetActive(false);
        }
    }
}
