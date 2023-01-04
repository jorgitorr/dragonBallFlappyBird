using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]float playerSpeed = 12f;
    private float inputHorizontal;
    private float inputVertical;
  
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        inputHorizontal = 0;
        inputVertical = 0;
    }

    // Update is called once per frame
    void Update()
    {

        inputHorizontal = Input.GetAxisRaw("Horizontal"); //siempre va a dar -1, 0 o 1
        inputVertical = Input.GetAxisRaw("Vertical");

        if (inputHorizontal != 0 | inputVertical != 0) //si el personaje se mueve:
        {
            //se puede usar addForce o velocity, los dos dan efectos diferentes
            rb.velocity = new Vector2(inputHorizontal * playerSpeed, inputVertical * playerSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
