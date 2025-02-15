using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Oxygen : MonoBehaviour
{
    public int level = 100;
    public Image oxygenLevel;
    public TextMeshProUGUI statusText;
    public OpenWindow window;
    public ToggleLight light;

    void Start() {
        
        StartCoroutine(Resizing());
    }

    private void resizeImageLength() {
        float width = oxygenLevel.rectTransform.sizeDelta.x;
        float height = oxygenLevel.rectTransform.sizeDelta.y;

        oxygenLevel.rectTransform.sizeDelta = new Vector2(width - 50, height);
        level -= 14;
    }
    private IEnumerator Resizing() {
        
        while (true) {
            
            if (!window.opened) {
                resizeImageLength();
            }
            else if (window.opened) {
                oxygenLevel.rectTransform.sizeDelta = new Vector2(350, 6); 
                level = 100;
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
    


