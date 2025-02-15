using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public Transform leftW;
    public Transform rightW;
    public bool opened {get; private set;} = false;

    public void OnMouseDown() {
        if (opened) {
            CloseWindow();
        } else {
            OpenWindow2();
        }
    }

    private void OpenWindow2() {
        opened = true;
        leftW.transform.localEulerAngles = new Vector3(0,-76,0);
        rightW.transform.localEulerAngles = new Vector3(0, 168, 0);

    }

    private void CloseWindow() {
        opened = false;
        leftW.transform.localEulerAngles = new Vector3(0,0,0);
        rightW.transform.localEulerAngles = new Vector3(0, 90, 0);
    }



}
