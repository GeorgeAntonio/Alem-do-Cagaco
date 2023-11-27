using UnityEngine;

public class AudioGuide : MonoBehaviour
{
    public AudioClip[] guideAudioClips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayRandomAudio();
    }

    void PlayRandomAudio()
    {
        if (guideAudioClips.Length > 0)
        {
            int randomIndex = Random.Range(0, guideAudioClips.Length);
            audioSource.clip = guideAudioClips[randomIndex];
            audioSource.Play();
        }
    }
}
