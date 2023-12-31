using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Closet2 : MonoBehaviour
{
    public GameObject MainCharacter;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer MCspriteRenderer;
    public Sprite OpenedCloset;
    public Sprite ClosedCloset;
    // Start is called before the first frame update
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

        if (GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == OpenedCloset)
        {
            GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite = ClosedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == OpenedCloset)
        {
            GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite = ClosedCloset;
            MCspriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {

    }
}
