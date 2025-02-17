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
        if (isDeathCoroutineRunning) {
            return;
        }

        if ((door.isOpened || window.opened) && Beer.beerClicked) {
            StartCoroutine(Death());
        } else if (stress.stressLevelsInt >= 100 || oxygen.level < 0) {
            StartCoroutine(Death());
        } else if ((light.recharging || alarm.runSec >= 600) && migrant.isOutside) {
            StartCoroutine(Death());
        } else if ((window.opened || door.isOpened) && light.recharging) {
            StartCoroutine(Death());
        }
    }

    public IEnumerator Death() {
        isDeathCoroutineRunning = true;
        yield return new WaitForSeconds(0.0001f);
        SceneManager.LoadScene("Home");
    }

    
    
}
