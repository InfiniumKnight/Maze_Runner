using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Countdown : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] private PlayerController player_script;
    [SerializeField] private GameObject world_music;
    public AudioSource failure;
    public AudioClip end;
    public Text gameOverText;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            player_script.GameOver = true;
            timerText.color = Color.red;
            Destroy(world_music);
            failure.PlayOneShot(end);
            gameOverText.gameObject.SetActive(true);
            gameOverText.text = "You lost! Press R to Restart!";
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
