using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool CollisionHappening = false;
    public Sprite SwitchFalse;
    public Sprite SwitchTrue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CollisionHappening==true && GameObject.Find("Switch").GetComponent<SpriteRenderer>().sprite == SwitchTrue && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Switch").GetComponent<SpriteRenderer>().sprite = SwitchFalse;
        }
        else if (CollisionHappening==true && GameObject.Find("Switch").GetComponent<SpriteRenderer>().sprite == SwitchFalse && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Switch").GetComponent<SpriteRenderer>().sprite = SwitchTrue;
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
