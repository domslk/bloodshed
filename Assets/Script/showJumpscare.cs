using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using UnityEngine.SceneManagement;
public class showJumpscare : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject canvasVideo;
    public GameObject canvas;
    public GameObject text;


    void Start() {
        ShowVideo();
    }

    public void ShowVideo() {
        videoPlayer.Play();
        canvas.SetActive(false);
        canvasVideo.SetActive(true);
        StartCoroutine(noVideo(1));
    }

    private IEnumerator noVideo(int wait) {
        yield return new WaitForSeconds(wait);
        canvas.SetActive(true);
        text.SetActive(true);
        videoPlayer.Stop();
        canvasVideo.SetActive(false);
        StartCoroutine(goHome());
    }

    private IEnumerator goHome() {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Home");
    }
}
