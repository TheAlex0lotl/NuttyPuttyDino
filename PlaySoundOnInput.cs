using UnityEngine;

public class PlaySoundOnInput : MonoBehaviour
{
    // The sound file you want to play
    public AudioClip soundClip;
    
    // The AudioSource component that will play the clip
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
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