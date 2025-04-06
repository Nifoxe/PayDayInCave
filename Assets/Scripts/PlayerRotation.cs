using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public GameObject obj;
    private Animator animator;
    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float yRotation = obj.transform.eulerAngles.y + 180f;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        bool isMoving = horizontalInput != 0 || verticalInput != 0;

        if (isMoving)
        {
            animator.Play("walk");
        }
        else
        {
            animator.Play("idle");
        }
    }
}
