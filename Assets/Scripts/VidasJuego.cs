using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasJuego : MonoBehaviour
{

    public GameObject[] hearts;

    public int vidas;

    public Transform Target;

    public GameObject Personaje;

    public GameObject victory;
    
    
    // Update is called once per frame
    void Update()
    {

        if ( vidas < 1)
        {
            hearts[0].gameObject.SetActive(false);
        }

        if (vidas < 2)
        {
            hearts[1].gameObject.SetActive(false);
        }

        if (vidas < 3)
        {
            hearts[2].gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Bomb")
            vidas -= 1;

        if ( vidas == 0)
        {
            victory.SetActive(true);
            vidas = 3;
            Personaje.transform.position = Target.position;
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
        


        }


    }

}