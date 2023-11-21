using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Closet : MonoBehaviour
{
    public GameObject MainCharacter;
    public GameObject wall1;
    public GameObject wall2;
    public Collider2D wall1c;
    public Collider2D wall2c;
    public Collider2D wall3c;
    public GameObject wall3;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer MCspriteRenderer;
    public Sprite OpenedCloset;
    public Sprite ClosedCloset;
    bool CollisionHappening = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CollisionHappening==true&&Input.GetKeyDown(KeyCode.E) && GameObject.Find("Closet").GetComponent<SpriteRenderer>().sprite == OpenedCloset)
        {
            GameObject.Find("Closet").GetComponent<SpriteRenderer>().sprite = ClosedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            wall1c.isTrigger = false;
            wall2c.isTrigger = false;
            wall3c.isTrigger = false;
        }
        else if (CollisionHappening == true && Input.GetKeyDown(KeyCode.E) && GameObject.Find("Closet").GetComponent<SpriteRenderer>().sprite == ClosedCloset)
        {
            GameObject.Find("Closet").GetComponent<SpriteRenderer>().sprite = OpenedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            wall1c.isTrigger = true;
            wall2c.isTrigger = true;
            wall3c.isTrigger = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        CollisionHappening = true;

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        CollisionHappening = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        CollisionHappening = false;
    }
}
