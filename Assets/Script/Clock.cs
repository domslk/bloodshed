using UnityEngine;
using System.Collections;
using TMPro;

public class Clock : MonoBehaviour
{
    public int time = 0; // 0-6
    public int minutes = 0; //0 or 3
    public bool home = false;
    [SerializeField] TextMeshProUGUI statusText;

    private bool running = false;

    void Start() {
        StartCoroutine(clock());
    }

    void Update() {
        if (!running) {
            StartCoroutine(clock());
        }
    }
    private IEnumerator clock() {
        running = true;
        yield return new WaitForSeconds(89);
        time += 1;
        if (time >= 6) {
            home = true;
        }
        if (minutes == 3) {
            minutes = 0;   
        } else {
            minutes = 3;
        }
        running = false;
    }
    private void OnMouseEnter() {
        statusText.text = $"0{time}:{minutes}0 AM";
    }

    private void OnMouseExit() {
        statusText.text = "";
    }
}
