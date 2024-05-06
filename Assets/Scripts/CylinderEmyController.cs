using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderEmyController : MonoBehaviour
{  

    
    public float moveSpeed = 3f;
    public Transform player2Transform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player2Transform == null)
            return;

        Vector3 direction = (player2Transform.position - transform.position).normalized;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        
    }
}
