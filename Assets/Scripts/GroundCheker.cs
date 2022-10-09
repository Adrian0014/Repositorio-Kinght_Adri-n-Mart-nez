using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    PlayerMovement _player;
    public Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Floor")
        {
            _player.isGrounded = true;
            _player.anim.SetBool("Jump", false);
        }
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        
        _player.isGrounded = false;
    }
    
}
