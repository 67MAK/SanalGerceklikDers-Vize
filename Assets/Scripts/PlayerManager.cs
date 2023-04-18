using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, 5f))
        {
            if(hit.collider.gameObject.tag == "Button")
            {

            }
        }
    }
}
