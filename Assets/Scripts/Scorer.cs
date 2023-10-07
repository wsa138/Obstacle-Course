using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hits;

    private void Start()
    {
        hits = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstable")
        {
            hits += 1;
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            collision.gameObject.tag = "Hit";
        }        
    }
}
