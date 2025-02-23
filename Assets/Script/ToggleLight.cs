using UnityEngine;
using UnityEngine.UI;
using System.Collections; 
using TMPro;
public class ToggleLight : MonoBehaviour
{
    public bool on = false;
    public float batteryLevel = 100;
    public Light spotLight;
    public TextMeshProUGUI statusText;
    public Sprite batteryFull;
    public Sprite battery34;
    public Sprite battery24;
    public Sprite battery14;
    public Sprite batteryDead;
    private int randomint;
    private float batteryTimer;
    public bool recharging = false;
    public Image originalBattery;
    public Image RightArm;
    public Image LeftArm;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource click;

    public void lightToggle() {
        StartCoroutine(lightToggleIE());
        click.Play();
    }

    private IEnumerator lightToggleIE() {
        if (batteryLevel <= 0) yield break;
        on = !on;
        if (on && batteryLevel > 0) {
            batteryTimer = 0f;
            spotLight.enabled = true;
            LeftArm.enabled = true;
            RightArm.enabled = true;
            while (on) {
                randomint = Random.Range(30, 60);
                spotLight.intensity = randomint; 
                yield return new WaitForSeconds(0.15f);
                batteryTimer += 0.15f;

                if (batteryTimer >= 4f) {
                    batteryLevel -= 25; 
                    batteryStatus();
                    if (batteryLevel <= 0)
                        {
                            spotLight.enabled = false; 
                            LeftArm.enabled = false;
                            RightArm.enabled = false;
                            on = false; 
                        }
                    batteryTimer = 0f;
                }
            } 
    } else {
        spotLight.enabled = false;
        LeftArm.enabled = false;
        RightArm.enabled = false;
        }
    }
    public void recharge() {
        StartCoroutine(rechargeIE());
    }

    private IEnumerator rechargeIE() {
        if (!on) {
        statusText.text = "Changing...";
        recharging = true;
        audioSource.Play();
        yield return new WaitForSeconds(2f); 
        recharging = false;
        statusText.text = "";
        batteryLevel = 100;
        batteryStatus();
        } else {
            statusText.text = "Turn flashlight off";
        }
        
    }

    private void batteryStatus() {
        if (batteryLevel == 100) {
            originalBattery.sprite = batteryFull;
        } else if (batteryLevel >= 75) {
            originalBattery.sprite = battery34;
        } else if (batteryLevel >= 50) {
            originalBattery.sprite = battery24;
        } else if (batteryLevel >= 25) {
            originalBattery.sprite = battery14;
        } else {
            originalBattery.sprite = batteryDead;
        }
    }

    
    
}
