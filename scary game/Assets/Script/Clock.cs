using UnityEngine;
using System.Collections;
using TMPro;

public class Clock : MonoBehaviour
{
    public int time = 0; // 0-6
    public int minutes = 0; //0 or 3
    [SerializeField] TextMeshProUGUI statusText;




    private void OnMouseEnter() {
        statusText.text = $"0{time}:{minutes}0 AM";
    }

    private void OnMouseExit() {
        statusText.text = "";
    }
}
