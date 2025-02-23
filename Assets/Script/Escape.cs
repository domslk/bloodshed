using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class Escape : MonoBehaviour
{   
    public Clock clock;
    public TextMeshProUGUI statusText;
   


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
            SceneManager.LoadScene("Win");
        }
    }
}
