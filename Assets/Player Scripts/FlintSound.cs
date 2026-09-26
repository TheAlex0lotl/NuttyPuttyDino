using UnityEngine;

public class FlintSound : MonoBehaviour
{
    // The sound file you want to play
    [SerializeField] public AudioClip soundClip;
    [SerializeField] public AudioClip soundClip2;
    
    // The AudioSource component that will play the clip
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(soundClip2);
    }

    void Update()
    {
        // Check if the Spacebar is pressed down this frame
        if (Input.GetKeyDown(KeyCode.F))
        {
            // PlayOneShot allows sounds to overlap without cutting each other off
            audioSource.PlayOneShot(soundClip); 
        }
    }
}