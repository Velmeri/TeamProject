using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject Chest_;
    public GameObject MainCharacter;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer MCspriteRenderer;
    public SpriteRenderer TipRenderer;
    public Sprite OpenedChest;
    public Sprite ClosedChest;
    public Sprite KeyFound;
    public Sprite KeyNotFound;
    public Sprite ClosedChestText;
    public Sprite OpenedDoor;
    public bool CollisionHappening = false;
    public float xPos;
    public float yPos;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CollisionHappening==true && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite = OpenedChest;
            xPos=-10.97f;
            yPos = -8.42f;

            Vector3 newPos = new Vector3(xPos, yPos, 0);

            MainCharacter.transform.position = newPos;
            MainCharacter.transform.position = newPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        CollisionHappening = true;

        /*        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ClosedChest && GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == KeyFound)
                {
                    GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite = OpenedChest;

                    GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenedDoor;
                }*/
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        CollisionHappening = true;
        /*        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ClosedChest && GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == KeyFound)
                {
                    GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite = OpenedChest;
                    GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenedDoor;
                }*/
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        CollisionHappening = false;
    }
}
