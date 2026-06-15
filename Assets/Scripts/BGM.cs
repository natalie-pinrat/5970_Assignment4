using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.PlayOneShot(bgm);
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(bgm);
        }
    }
}
