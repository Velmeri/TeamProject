using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // I don't have much time so comments will come later :)
    public float Speed;
    private Vector2 Direction;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Direction.x = Input.GetAxisRaw("Horizontal");
        Direction.y = Input.GetAxisRaw("Vertical");
    }

    // Called a fixed number of times per second.
    void FixedUpdate(){
        rb.MovePosition(rb.position + Direction * Speed * Time.fixedDeltaTime);
    }
}
