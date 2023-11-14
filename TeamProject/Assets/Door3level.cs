using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door3level : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer spriteRenderer;
    public Sprite OpenDoor;
    public Sprite CloseDoor;
    public Sprite PressedButton;
    public Sprite DefaultButton;
    bool CollisionHappening = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        if(GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite == PressedButton )
        {
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenDoor;
        }
        else
        {
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = CloseDoor;
        }
        if (CollisionHappening&&Input.GetKeyDown(KeyCode.E) && GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite == OpenDoor)
        {
            SceneManager.LoadScene(4);
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
