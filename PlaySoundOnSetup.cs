public class PlaySoundOnSetup : MonoBehaviour
{
    // The sound file you want to play
    public AudioClip openingClip;
    
    // The AudioSource component that will play the clip
    private AudioSource audioSourceTwo;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(soundClip); 
    }
}

    