using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrePull : MonoBehaviour
{
    public float pullForce = 5;

    public Rigidbody dogPull;

    public Transform pullPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pullPosition = Vector3.zero;
        dogPull.AddForce(pullPosition * pullForce, ForceMode.Force);
        
    }
}
