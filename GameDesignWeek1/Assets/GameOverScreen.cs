using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    public void Setup(float finalTime) {
        Debug.Log("hey");
        gameObject.SetActive(true);
        timeText.text = "YOU LASTED " + finalTime.ToString() + " SECONDS!";
    }

    public void RestartButton() {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitButton() {
        Application.Quit();
    }
}
