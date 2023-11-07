using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageBin : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer TipRenderer;
    public Sprite GarbageKey;
    public Sprite GarbageNoKey;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        TipRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("GarbageBin").GetComponent<SpriteRenderer>().sprite == GarbageKey)
        {
            GameObject.Find("Garbage").GetComponent<SpriteRenderer>().sprite = GarbageNoKey;
            TipRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("GarbageBin").GetComponent<SpriteRenderer>().sprite == GarbageKey)
        {
            GameObject.Find("Garbage").GetComponent<SpriteRenderer>().sprite = GarbageNoKey;
            TipRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
    }
}
