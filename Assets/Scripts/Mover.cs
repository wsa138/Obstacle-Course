using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float controllerSpeed;
    [SerializeField] private float yVel;
    private Vector3 moveInputValue;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ControllerMoveLogic();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);

        if (xValue != 0 || zValue != 0)
        {
            animator.SetBool("isMoving", true);
        } else
        {
            animator.SetBool("isMoving", false);
        }
        
    }

    private void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
    }

    private void ControllerMoveLogic()
    {
        Vector3 result = moveInputValue * controllerSpeed * Time.deltaTime;
        rb.velocity = new Vector3(result.x, yVel, result.z);
    }

}
