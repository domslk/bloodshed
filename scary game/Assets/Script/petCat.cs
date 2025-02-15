using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections;

public class petCat : MonoBehaviour
{
    public TextMeshProUGUI statusText;
    private int number = 0;
    public VideoPlayer videoPlayer;
    public GameObject canvasVideo;
    public GameObject canvas;
    public void OnMouseDown() {
        number++;
        statusText.text = $"meow x{number}";
        if (number == 5) {
            ShowVideo();
        }
    }

    public void ShowVideo() {
        canvasVideo.SetActive(true);
        canvas.SetActive(false);
        videoPlayer.Play();
        StartCoroutine(noVideo(2));
    }

    private IEnumerator noVideo(int wait) {
        yield return new WaitForSeconds(wait);

        videoPlayer.Stop();
        canvasVideo.SetActive(false);
        canvas.SetActive(true);
        number = 0;
    }
}
