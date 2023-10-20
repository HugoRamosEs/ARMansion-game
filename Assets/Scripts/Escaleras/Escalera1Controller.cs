using UnityEngine;
using UnityEngine.SceneManagement;

public class Escalera1Controller : MonoBehaviour {
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
            PlayerPrefs.SetFloat("PlayerX", 11.7f);
            PlayerPrefs.SetFloat("PlayerY", -7.9f);
            SceneManager.LoadScene("PlantaPrincipal", LoadSceneMode.Single);
        }
    }

}
