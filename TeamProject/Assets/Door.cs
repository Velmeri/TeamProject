using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Animator animator;
    float framesPerSecond = 30.0f;
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
            animator.SetBool("Victory", true);
        }

        if(animator.GetBool("Victory") == true){
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            int totalFrames = Mathf.RoundToInt(stateInfo.length * framesPerSecond);
            int currentFrame = Mathf.RoundToInt(stateInfo.normalizedTime * totalFrames);
            if (currentFrame == totalFrames - 1)
            {
                lvlFinished();
            }
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
        int lvlNum = SceneManager.GetActiveScene().buildIndex / 2;
        int completedLevelsNum = PlayerPrefs.GetInt("CompletedLevels", 0);
        if(completedLevelsNum < lvlNum){
            PlayerPrefs.SetInt("CompletedLevels", lvlNum);
        }
        Debug.Log("CompletedLevels: " + PlayerPrefs.GetInt("CompletedLevels" ,0));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
