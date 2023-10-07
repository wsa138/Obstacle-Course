using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 1f;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            mRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
