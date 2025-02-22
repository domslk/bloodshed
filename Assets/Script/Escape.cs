using UnityEngine;
using TMPro;
using System.Collections;
public class Escape : MonoBehaviour
{   
    public Clock clock;
    public TextMeshProUGUI statusText;
    void Update() {
        return;
    }


    private void OnMouseEnter() {
        if (clock.home) {
            statusText.text = "ESCAPE";
        } 
    }

    private void OnMouseExit() {
        statusText.text = "";
    }

    private void OnMouseDown() {
        if (clock.home) {
            Debug.Log("you won");
        }
    }
}
