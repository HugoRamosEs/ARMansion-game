using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escalera0Controller : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("hola");
        if (other.tag == "Player") {
            PlayerPrefs.SetFloat("PlayerX", 17);
            PlayerPrefs.SetFloat("PlayerY", 0.25f);
            SceneManager.LoadScene("Planta0", LoadSceneMode.Single);
        }
    }
}
