using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTip : MonoBehaviour
{
    public GameObject FoodTip_;
    public GameObject FoodFound;
    public SpriteRenderer FoodTipSR;
    public SpriteRenderer FoodFoundSR;
    public bool CollisionHappening = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CollisionHappening == true&& Input.GetKeyDown(KeyCode.E))
        {
            FoodTip_.tag = "Seen";
            FoodTipSR.color = new Color(1f, 1f, 1f, 1f);
        }
        if (CollisionHappening == false)
        {
            FoodTipSR.color = new Color(1f, 1f, 1f, 0f);

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
