using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]private float parallaxMultipler;

    private Transform cameraTransform;
    private Vector3 cameraPreviousPos;
    private float spriteWidht;
    private float startPos;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        cameraPreviousPos = cameraTransform.position;

        spriteWidht = GetComponent<SpriteRenderer>().bounds.size.x;
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float x = (cameraTransform.position.x - cameraPreviousPos.x) * parallaxMultipler;
        float spriteMoveAmount = cameraTransform.position.x * (1 - parallaxMultipler);

        transform.Translate(new Vector3(x, 0f, 0f));
        cameraPreviousPos = cameraTransform.position;

        if(spriteMoveAmount > startPos + spriteWidht)
        {
            transform.Translate(new Vector3(spriteWidht, 0f, 0f));
            startPos += spriteWidht;
        }
        else if(spriteMoveAmount < startPos -spriteWidht)
        {
            transform.Translate(new Vector3(-spriteWidht, 0f, 0f));
            startPos -= spriteWidht;
        }
    }
}
