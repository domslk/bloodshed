using UnityEngine;
using System.Collections;
public class titlescreen : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] GameObject buttonQuit;
    [SerializeField] GameObject gitImg;
    [SerializeField] GameObject itchImg;
    [SerializeField] GameObject text;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(showButtons());
    }


    private IEnumerator showButtons() {
        yield return new WaitForSeconds(6f);
        button.SetActive(true);
        buttonQuit.SetActive(true);
        gitImg.SetActive(true);
        itchImg.SetActive(true);
        text.SetActive(true);
    }

}
