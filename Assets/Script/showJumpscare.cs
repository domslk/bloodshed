using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using UnityEngine.SceneManagement;
public class showJumpscare : MonoBehaviour
{
    public GameObject canvas;
    public GameObject text;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;

    private int[] list = {1,2,3,4,5,4,5,4,2,3,4,5,3,5,3,2,3,4,5,3,5,3,2,3,4,5,3,5,3,2};
    void Start() {
        StartCoroutine(StartVideo());
    }

    private IEnumerator StartVideo() {
        for (int i = 0; i < list.Length; i++) {
            switch(list[i]) {
                case 1: 
                    img1.SetActive(true);
                    yield return new WaitForSeconds(0.04f);
                    img1.SetActive(false);
                    break;
                case 2:
                    img2.SetActive(true);
                    yield return new WaitForSeconds(0.04f);
                    img2.SetActive(false);
                    break;
                case 3:
                    img3.SetActive(true);
                    yield return new WaitForSeconds(0.04f);
                    img3.SetActive(false);
                    break;
                case 4:
                    img4.SetActive(true);
                    yield return new WaitForSeconds(0.04f);
                    img4.SetActive(false);
                    break;
                case 5:
                    img5.SetActive(true);
                    yield return new WaitForSeconds(0.04f);
                    img5.SetActive(false);
                    break;

            }
        }
        noVideo(1);
    }
    private void noVideo(int wait) {
        text.SetActive(true);
        StartCoroutine(goHome());
    }

    private IEnumerator goHome() {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Home");
    }
}
