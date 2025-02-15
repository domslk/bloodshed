using UnityEngine;
using System.Collections;
using TMPro;

public class beer : MonoBehaviour
{
    public bool beerClicked = false;
    public int beerClickCounter = 0;
    public TextMeshProUGUI statusText;
    public Stress stress;
    public moster monster;


    private IEnumerator isClicked() {
        beerClicked = true;
        yield return new WaitForSeconds(2f);
        beerClicked = false;
        beerClickCounter += 1;
    }
    public void OnMouseDown() {
        StartCoroutine(isClicked());
    }

    private void OnMouseEnter() {
        statusText.text = "fun drink";
    }

    private void OnMouseExit() {
        statusText.text = "";
    }
}
