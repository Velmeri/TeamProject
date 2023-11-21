using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool CollisionHappening = false;
    public SpriteRenderer spriteRenderer;
    public Sprite OpenDoor;
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        if(CollisionHappening==true&&Input.GetKeyDown(KeyCode.E) && GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite == OpenDoor)
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

    private void lvlFinished(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
