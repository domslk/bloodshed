using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using UnityEngine.SceneManagement;
public class showJumpscare : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject canvasVideo;
    public GameObject canvas;
    public GameObject canvasVideoImg;
    public GameObject canvasVideoVideo;
    public GameObject text;


    void Start() {
        canvas.SetActive(true);
        StartCoroutine(StartVideo());
    }

    private IEnumerator StartVideo() {
        videoPlayer.Play();
        canvasVideoVideo.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        canvasVideoImg.SetActive(false);
        canvas.SetActive(false);
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
