using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, ILockable
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
    private NewBehaviourScript script;
	// Start is called before the first frame update
	void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
		script = MainCharacter.GetComponent<NewBehaviourScript>();
	}

    // Update is called once per frame
    void Update()
    {
		if (CollisionHappening && Input.GetKeyDown(KeyCode.E)) {
			if (PlayerHasKey()) {
				Unlock();
			} else {
				Debug.Log("The chest is locked. You need the key to open it.");
			}
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

	public void Unlock()
	{
		Debug.Log("Chest is now unlocked!");

		MainCharacter.transform.position = new Vector3(-10.97f, -8.42f, 0);
	}

	private bool PlayerHasKey()
	{
        foreach (Item item in script.playerInventory.Items) {
			if(item is Key) {
                Key key = (Key)item;
                if(key.LockableTarget == gameObject) return true;
            }
		}
        return false;
	}
}