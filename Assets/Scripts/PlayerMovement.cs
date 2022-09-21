using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public float speed = 5;
    private float horizontal;
    //private Transform playerTransform;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = GetComponent<Transform>();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
        //Otras Opciones de hacer el movimiento horizontal del personaje
        //playerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0); 
        //playerTransform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime; 
        
        rb.velocity = new Vector2 (horizontal * speed , 0f);
        

    }
}
