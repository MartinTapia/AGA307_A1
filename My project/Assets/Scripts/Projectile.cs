using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public LayerMask mask;


    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Target")
        { 
            col.collider.GetComponent<MeshRenderer>().material.color = Color.red;
            Destroy(col.collider.gameObject, 1);
            Destroy(this.gameObject);
        }
    }
}
