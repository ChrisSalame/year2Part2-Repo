using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrePull : MonoBehaviour
{


    /// <summary>
    /// This is an unused script, kept for documentation
    /// </summary>
    public float pullForce = 0.1f;
    public float distance;

    public Transform pullPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, pullPosition.position);

        pullForce = distance/5;

        transform.position = pullForce * pullPosition.position;

        Debug.Log(pullForce);
        
    }
}
