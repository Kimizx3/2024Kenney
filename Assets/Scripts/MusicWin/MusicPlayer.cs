using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public List<AudioClip> songs;
    public GameObject songCover;
    public List<GameObject> Panels;
    private int currentCoverIndex = 0;
    private int currentSongIndex = 0;

    private void Start()
    {
        if (songs.Count > 0)
        {
            audioSource.clip = songs[currentSongIndex];

            songCover = Panels[currentCoverIndex];
            songCover.SetActive(true);
        }
    }

    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void PauseMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    public void NextSong()
    {
        songCover.SetActive(false);
        currentSongIndex = (currentSongIndex + 1) % songs.Count;
        audioSource.clip = songs[currentSongIndex];
        audioSource.Play();

        currentCoverIndex = (currentCoverIndex + 1) % Panels.Count;
        songCover = Panels[currentCoverIndex];
        songCover.SetActive(true);
    }

    public void PreviousSong()
    {
        songCover.SetActive(false);
        currentSongIndex = (currentSongIndex - 1 + songs.Count) % songs.Count;
        audioSource.clip = songs[currentSongIndex];
        audioSource.Play();
        
        currentCoverIndex = (currentCoverIndex - 1 + Panels.Count) % Panels.Count;
        songCover = Panels[currentCoverIndex];
        songCover.SetActive(true);
    }
}
