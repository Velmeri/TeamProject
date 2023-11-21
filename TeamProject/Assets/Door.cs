using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite OpenDoor;
    public Sprite CloseDoor;
    public bool CollisionHappening=false;
    public Sprite DefaultButton;
    public Sprite PressedButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite == OpenDoor && CollisionHappening==true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite == PressedButton)
        {
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenDoor;
        }
        else
        {
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = CloseDoor;
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
