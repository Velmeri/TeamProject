using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainCharacter;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer MCspriteRenderer;
    public Sprite OpenedCloset;
    public Sprite ClosedCloset;
    public Collider2D wall1c;
    public Collider2D wall2c;
    public Collider2D wall3c;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite == OpenedCloset)
        {
            GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite = ClosedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            wall1c.isTrigger = false;
            wall2c.isTrigger = false;
            wall3c.isTrigger = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite == ClosedCloset)
        {
            GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite = OpenedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            wall1c.isTrigger = true;
            wall2c.isTrigger = true;
            wall3c.isTrigger = true;
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite == OpenedCloset)
        {
            GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite = ClosedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            wall1c.isTrigger = true;
            wall2c.isTrigger = true;
            wall3c.isTrigger = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite == ClosedCloset)
        {
            GameObject.Find("Closet3").GetComponent<SpriteRenderer>().sprite = OpenedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            wall1c.isTrigger = true;
            wall2c.isTrigger = true;
            wall3c.isTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {

    }
}
