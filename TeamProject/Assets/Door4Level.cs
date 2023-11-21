using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door4Level : MonoBehaviour
{
    public Sprite DoorOpen;
    public Sprite ChestOpened;
    bool CollisionHappening=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ChestOpened)
        {
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = DoorOpen;
        }
        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite == DoorOpen&&CollisionHappening==true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
