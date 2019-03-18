using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

#pragma warning disable 649
    [SerializeField] Slider volumeSlider, difficultySlider;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] int defaultDifficulty = 1;
#pragma warning restore 649

    MusicPlayer musicPlayer;


    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
    }

    void Update()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();
        if (!musicPlayer) { return; }
        musicPlayer.SetVolume(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
