using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] AudioClipArr;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Play();
            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioSource.volume = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            audioSource.volume = -0.5f;
        }
    }
}
