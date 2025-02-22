using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using UnityEngine.SceneManagement;
public class showJumpscare : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject canvasVideo;
    public GameObject canvas;


    void Start() {
        ShowVideo();
    }

    public void ShowVideo() {
        canvasVideo.SetActive(true);
        canvas.SetActive(false);
        videoPlayer.Play();
        StartCoroutine(noVideo(1));
    }

    private IEnumerator noVideo(int wait) {
        yield return new WaitForSeconds(wait);
        videoPlayer.Stop();
        canvasVideo.SetActive(false);
        canvas.SetActive(true);
        StartCoroutine(goHome());
    }

    private IEnumerator goHome() {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Home");
    }
}
