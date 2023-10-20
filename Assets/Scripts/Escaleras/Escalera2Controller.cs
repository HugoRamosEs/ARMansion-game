using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escalera2Controller : MonoBehaviour {
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("hola");
        if (other.tag == "Player") {
            PlayerPrefs.SetFloat("PlayerX", 27.65f);
            PlayerPrefs.SetFloat("PlayerY", -14.4f);
            SceneManager.LoadScene("Planta-1", LoadSceneMode.Single);
        }
    }
}
