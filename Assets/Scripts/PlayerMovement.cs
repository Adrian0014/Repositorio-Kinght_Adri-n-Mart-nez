using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerMovement : MonoBehaviour
{   
    public float speed = 5;
    private float horizontal;
    public bool isGrounded;
    public float jumpForce = 10f;

    float dirX;
    
    
    //private Transform playerTransform;
    private Rigidbody2D rb;
    public Animator anim;

    public PlayableDirector director;
    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = GetComponent<Transform>();

    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        //flip character
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;


        if(horizontal == 0)
        {
            anim.SetBool("Correr", false);

        }

        else
        {
            anim.SetBool("Correr", true);
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetBool("Jump", true);
        }

        /*void FixedUpdate()
        {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }*/
     
        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
        //Otras Opciones de hacer el movimiento horizontal del personaje
        //playerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0); 
        //playerTransform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime; 
        
        rb.velocity = new Vector2 (horizontal * speed , rb.velocity.y);
        
    }

   
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Cinematica")
        {
            director.Play();
        }
        
    }

    //gg

}
