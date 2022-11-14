using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ToggleAudio : MonoBehaviour
{
    [Tooltip("Toggle the audio on or off")]
    public bool isOn = false;
    private AudioSource currentaudio = null;
    // Start is called before the first frame update

    private void Awake()
    {
        currentaudio = GetComponent<AudioSource>();
    }
    private void Start()
    {
        currentaudio.enabled = isOn;
    }

    public void Flip()
    {
        isOn = !isOn;
        currentaudio.enabled = isOn;
    }

    private void OnValidate()
    {
        if (currentaudio)
            currentaudio.enabled = isOn;
    }

   
}
