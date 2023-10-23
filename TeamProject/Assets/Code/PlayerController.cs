using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // I don't have much time so comments will come later :)
    public float Speed;
    private Vector2 Direction;
    private Rigidbody2D rb;
    public Animator animator;
    bool isPushing;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Direction.x = Input.GetAxisRaw("Horizontal");
        Direction.y = Input.GetAxisRaw("Vertical");

        animator.SetBool("IsPushing", isPushing);
        animator.SetFloat("Horizontal", Direction.x);
        animator.SetFloat("Vertical", Direction.y);
        animator.SetFloat("Speed", Direction.sqrMagnitude);
    }

    // Called a fixed number of times per second.
    void FixedUpdate(){
        rb.MovePosition(rb.position + Direction * Speed * Time.fixedDeltaTime);
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Box")
        {
            Rigidbody box=hit.collider.GetComponent<Rigidbody>();
            if(box!=null)
            {
                Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, 0);
                box.velocity = pushDirection;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
        if (other.CompareTag("Box"))
        {
            isPushing = true;
            animator.SetBool("IsPushing", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D");
        if (other.CompareTag("Box"))
        {
            isPushing = false;
            animator.SetBool("IsPushing", false);
        }
    }
}
