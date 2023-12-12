using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializableAttribute]
public class NewBehaviourScript : MonoBehaviour
{
    // I don't have much time so comments will come later :)
    public float Speed = 2;
    public float fastSpeed = 4;
    public float realSpeed;
    private Vector2 Direction;
    private Rigidbody2D rb;
    public Animator animator;
	public Inventory playerInventory;
	bool isPushing;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

		GameObject inventoryObject = GameObject.FindGameObjectWithTag("Inventory");
		if (inventoryObject != null) {
			playerInventory = inventoryObject.GetComponent<Inventory>();
		}

		realSpeed = Speed;
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
        if(Input.GetKey(KeyCode.LeftShift))
        {
            realSpeed = fastSpeed;
        }
        else
        {
            realSpeed = Speed;
        }
    }

    // Called a fixed number of times per second.
    void FixedUpdate(){
        rb.MovePosition(rb.position + Direction * realSpeed * Time.fixedDeltaTime);
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
		if (other.gameObject.CompareTag("Item"))
		{
			PickUp(other.gameObject);
		}
	}

	private void PickUp(GameObject item)
	{
        Item newItem = item.GetComponent<Item>();
        playerInventory.Add(newItem);

		Destroy(item);
	}
}
