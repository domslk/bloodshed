using UnityEngine;
using System.Collections;
using TMPro;
public class Alarm : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    public bool playing {get; private set;} = false;
    public int randomint;
    public bool firstClick = true;
    public TextMeshProUGUI statusText;

    
    
    void Start()
    {
        
       
        randomint = Random.Range(15, 25);
        StartCoroutine(StartCountdown());
        
            
        
    }

    private IEnumerator StartCountdown() {
        yield return new WaitForSeconds(randomint);
        audioSource.Play();
        playing = true;
        

    }

    public void OnMouseDown() {
        if (firstClick) {
            firstClick = false;
            statusText.text = "Alarm";    
            return;
        }
        if (playing) {
            StopAllCoroutines();
            randomint = Random.Range(10, 24);
            audioSource.Stop();
            playing = false;
            StartCoroutine(StartCountdown());
            Debug.Log(randomint);
        }
        

        
    }
    private void OnMouseEnter() {
        statusText.text = "Alarm";
    }

    private void OnMouseExit() {
        statusText.text = "";
    }
}
