using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    [SerializeField] AudioSource running;
    [SerializeField] GameObject text;
    void Start()
    {
        StartCoroutine(winStart());
    }

    private IEnumerator winStart() {
        running.Play();
        yield return new WaitForSeconds(2f);
        text.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Home");
    }
}
