using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calavera5Controller : MonoBehaviour
{
    public GameObject imagenPrueba5;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba5.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            imagenPrueba5.SetActive(false);
        }
    }
}
