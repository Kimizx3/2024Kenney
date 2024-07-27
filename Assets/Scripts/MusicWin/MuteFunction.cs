using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteFunction : MonoBehaviour
{
    public Button muteButton; // Reference to the mute button

    private bool isMuted = false;

    void Start()
    {
        // Add click listener to the button
        muteButton.onClick.AddListener(ToggleMute);
    }

    void ToggleMute()
    {
        // Toggle the mute state
        isMuted = !isMuted;

        // Set the audio volume based on the mute state
        AudioListener.volume = isMuted ? 0 : 1;
    }
    
}
