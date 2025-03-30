using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrePull : MonoBehaviour
{
    public float pullForce = 5;
    public float distance;

    public Transform dogEnemy;
    public Transform pullPosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(dogEnemy.transform.position, transform.position);

        pullForce = (distance/5);

        dogEnemy.transform.position = pullForce * pullPosition.position;

        Debug.Log(pullForce);
        
    }
}
