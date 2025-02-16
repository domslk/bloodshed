using UnityEngine;
using UnityEngine.UI;
using System.Collections; 
using TMPro;
using UnityEngine.SceneManagement;
public class moster : MonoBehaviour
{

    public OpenDoor door;
    public OpenWindow window;
    public Alarm alarm;
    public beer Beer;
    public Stress stress;
    public Oxygen oxygen;
    public ToggleLight light;
    private bool isDeathCoroutineRunning = false;
    public Migrant migrant;
    

    public TextMeshProUGUI statusText;
    
    
    void Update() {
        if (!isDeathCoroutineRunning && door.isOpened && Beer.beerClicked || !isDeathCoroutineRunning && window.opened && Beer.beerClicked) {
            StartCoroutine(Death());
        } else if (!isDeathCoroutineRunning && stress.stressLevelsInt >= 100) {
            StartCoroutine(Death());
        } else if (!isDeathCoroutineRunning && oxygen.level < 0) {
            StartCoroutine(Death());
        } else if (!isDeathCoroutineRunning && light.recharging && migrant.isOutside) {
            StartCoroutine(Death());
        } else if (!isDeathCoroutineRunning && alarm.runSec >= 600 && migrant.isOutside) {
            StartCoroutine(Death());
        } else if (!isDeathCoroutineRunning && light.recharging && window.opened || !isDeathCoroutineRunning && light.recharging && door.isOpened) {
            StartCoroutine(Death());
        } 
    }

    public IEnumerator Death() {
        isDeathCoroutineRunning = true;
        yield return new WaitForSeconds(0.0001f);
        SceneManager.LoadScene("Home");
    }

    
    
}
