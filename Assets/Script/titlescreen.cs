using UnityEngine;
using System.Collections;
public class titlescreen : MonoBehaviour
{
    [SerializeField] GameObject button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(showButtons());
    }


    private IEnumerator showButtons() {
        yield return new WaitForSeconds(6f);
        button.SetActive(true);
    }

}
