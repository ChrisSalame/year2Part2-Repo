using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementCode : MonoBehaviour
{
    //sets player speed
    public float speed;

    CharacterController charControl;

    // Start is called before the first frame update
    void Start()
    {
        //calls character controller
        charControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //directions in which the player can move when arrowkeys are pressed
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        charControl.Move(new Vector3(x, 0, z));
    }
}
