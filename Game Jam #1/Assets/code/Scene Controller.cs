using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class SceneTransition : MonoBehaviour
{
    public string nextSceneName; // Name of the scene to transition to.
    [SerializeField] Animator transitionAnim;

    public Transform targetPosition; // Set this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && transform.position == targetPosition.position)
        {
            StartCoroutine(TransitionAndPlayAnimation());
        }
    }
    IEnumerator TransitionAndPlayAnimation()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(nextSceneName);
        transitionAnim.SetTrigger("Start");
    }

    
}
