using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public Joystick joystickMove;
    private Rigidbody2D rb;
    Vector2 input;
    public float velocidad;
    private Animator animator;
    private bool isMoving;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //Debug.Log("PlayerController " + PlayerPrefs.HasKey("PlayerX"));
        if (PlayerPrefs.HasKey("PlayerX"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = joystickMove.Horizontal;
        float moveVertical = joystickMove.Vertical;
        rb.velocity = new Vector2(moveHorizontal * velocidad, moveVertical * velocidad);
        animator.SetBool("isMoving", rb.velocity.sqrMagnitude > 0);
        animator.SetFloat("moveX", moveHorizontal);
        animator.SetFloat("moveY", moveVertical);
    }
}