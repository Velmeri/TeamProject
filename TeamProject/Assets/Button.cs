using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public SpriteRenderer TipRenderer;
    public SpriteRenderer spriteRenderer;
    public Sprite PressedButton;
    public Sprite DefaultButton;
    public Sprite OpenDoor;
    public Sprite CloseDoor;

    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite = PressedButton;
        GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenDoor;
        TipRenderer.color = new Color(1f, 1f, 1f, 1f);
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite = PressedButton;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite = DefaultButton;
        TipRenderer.color = new Color(1f, 1f, 1f, 0f);
        GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = CloseDoor;
    }
}
