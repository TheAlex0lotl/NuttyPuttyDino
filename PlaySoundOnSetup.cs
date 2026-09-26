using UnityEngine;

[RequireComponent(typeof(AudioSource))] // Ensures the GameObject has an Audio Source attached
public class PlaySoundOnSetup : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the Audio Source component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Play the sound immediately during setup
        audioSource.Play();
    }
}