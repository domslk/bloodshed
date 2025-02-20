using UnityEngine;
using UnityEngine.UI;
using System.Collections; 
using TMPro;
public class OpenDoor : MonoBehaviour
{   
    public Transform Pivot;
    public object Lock;
    public TextMeshProUGUI statusText;
    public bool isLocked { get; private set; } = true;
    public bool isOpened {get; private set;} = false;

    public AudioSource doorLocked;
    public AudioSource doorClose;
    public AudioSource doorOpen;
    public AudioSource lockityLock;

    public void toggleLock() {
        isLocked = !isLocked;
        lockityLock.Play();
    }

    public void toggleDoor() {
        if (isOpened) {
            CloseDoor();
        } 
        else if (!isOpened && isLocked) {
            doorLocked.Play();
        } 
        else {
            OpenTheDoor();
        }

    }

    private void OpenTheDoor() {
        isOpened = true;
        Pivot.transform.localEulerAngles = new Vector3(0,-69,0);
        doorOpen.Play();
    }

    private void CloseDoor() {
        isOpened = false;
        Pivot.transform.localEulerAngles = new Vector3(0,0,0);
        doorClose.Play();
    }   

    private void OnMouseDown()
    {
        toggleDoor();
    }

    private void OnMouseEnter() {
        if (isLocked) {
            statusText.text = "Locked";
        } else {
            statusText.text = "Unlocked";
        }
    }
    private void OnMouseExit() {
        statusText.text = "";
    }


}
