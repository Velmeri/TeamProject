using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject MainCharacter;
    public float xPos;
    public float yPos;
    public bool CollisionHappening = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(CollisionHappening==true && Input.GetKeyDown(KeyCode.E)){
            Vector3 newPos = new Vector3(xPos, yPos, 0);

            MainCharacter.transform.position = newPos;
            MainCharacter.transform.position = newPos;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        //float xPos = -6.97f;
        //float yPos = 5.21f;

        CollisionHappening = true;
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        //float xPos = -6.97f;
        //float yPos = 5.21f;

        CollisionHappening = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        CollisionHappening = false;
    }
}
