using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Stress : MonoBehaviour
{
    public Image stressLevel;
    public TextMeshProUGUI statusText;
    public Alarm alarm;
    public OpenDoor door;
    public OpenWindow window;
    public Oxygen oxygen;
    public beer Beer;
    public double stressLevelsInt = 0;
    [SerializeField] Migrant migrant;
    

    void Start() {
        StartCoroutine(Resizing2());
    }

    private void resizeImageLength2(float amount) {
        if (amount != 0) {
            float width = stressLevel.rectTransform.sizeDelta.x;
            float height = stressLevel.rectTransform.sizeDelta.y;

            stressLevel.rectTransform.sizeDelta = new Vector2(width + amount, height);
        } else {
            stressLevel.rectTransform.sizeDelta = new Vector2(0f, 5.900299f);
        }
        
    }
    private IEnumerator Resizing2() {
        float width = stressLevel.rectTransform.sizeDelta.x;
        while (true) {
            
            if (alarm.playing && width <= 350) {
                resizeImageLength2(80f);
                stressLevelsInt += 22.88;
            } else if (door.isOpened && width <= 350) {
                resizeImageLength2(20f);
                stressLevelsInt += 5.72;
            } else if (window.opened && width <= 350) {
                resizeImageLength2(10f);
                stressLevelsInt += 2.86;
            } else if (oxygen.level < 25 && width <= 350) {
                resizeImageLength2(50f);
                stressLevelsInt += 14.3;
            } else if (Beer.beerClicked) {
                resizeImageLength2(0);
                stressLevelsInt = 0;
            } else if (migrant.isOutside) {
                resizeImageLength2(30f);
                stressLevelsInt += 8.58;
            }
            
            yield return new WaitForSeconds(2f);
        }
    }
}
    


