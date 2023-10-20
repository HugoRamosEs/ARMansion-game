using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escalera3Controller : MonoBehaviour {
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
            PlayerPrefs.SetFloat("PlayerX", 12.8f);
            PlayerPrefs.SetFloat("PlayerY", -14.8f);
            SceneManager.LoadScene("Planta0", LoadSceneMode.Single);
        }
    }
}
