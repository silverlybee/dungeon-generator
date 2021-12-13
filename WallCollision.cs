using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, .01f);

        foreach (Collider collider in colliders)
        {
            if(collider.tag == "Wall")
            {
                Destroy(gameObject);
                return;
            }
        }

        GetComponent<Collider>().enabled = true;
    }
}
