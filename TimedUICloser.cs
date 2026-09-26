using System.Collections;
using UnityEngine;

public class TimedUICloser : MonoBehaviour
{
    [Tooltip("Time in seconds before the UI element closes.")]
    public float delayInSeconds = 43f;

    void OnEnable()
    {
        // Start the coroutine every time the UI element becomes active
        StartCoroutine(CloseAfterDelay(delayInSeconds));
    }

    IEnumerator CloseAfterDelay(float delay)
    {
        // Wait for the specified time
        yield return new WaitForSeconds(delay);

        // Disable the UI element (or use Destroy(gameObject) if you want to delete it entirely)
        gameObject.SetActive(false);
    }
}
