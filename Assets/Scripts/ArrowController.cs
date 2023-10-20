using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public GameObject barras4;
    void Update()
    {
        var temp = transform.rotation;
        Vector3 rotation = transform.rotation.eulerAngles;
        if (rotation.z >= -80 && rotation.z <= -100)
        {
            barras4.SetActive(false);
        }
        if (rotation.z >= 250 && rotation.z <= 270)
        {
            barras4.SetActive(false);
        }
    }
}
