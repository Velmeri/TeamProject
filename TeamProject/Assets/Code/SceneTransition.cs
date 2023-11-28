using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private static SceneTransition instance;

    private Animator componentAnimator;
    private AsyncOperation loadingSceneOperation;

    private static bool shouldPlayOpeningAnimation = false;

    public static void SwitchToScene(int sceneIndex)
    {
        instance.componentAnimator.SetTrigger(name: "sceneClosing");

        instance.loadingSceneOperation = SceneManager.LoadSceneAsync(sceneIndex);
        instance.loadingSceneOperation.allowSceneActivation = false;
    }

    void Start()
    {
        instance = this;

        componentAnimator = GetComponent<Animator>();

        if (shouldPlayOpeningAnimation) componentAnimator.SetTrigger(name: "sceneOpening");
    }

    void Update()
    {

    }

    public void OnAnimationOver()
    {
        shouldPlayOpeningAnimation = true;
        instance.loadingSceneOperation.allowSceneActivation = true;
    }
}
