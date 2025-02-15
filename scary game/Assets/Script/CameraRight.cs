using UnityEngine;
using System.Collections;
public class CameraRight : MonoBehaviour {
    public Camera main;
    public Camera pixelated2;
    private float currentY = 0f;
    public void turnRight() {
        currentY += 90f;
        main.transform.rotation = Quaternion.Euler(0, currentY, 0);
        pixelated2.transform.rotation = Quaternion.Euler(0, currentY, 0);
    }

    public void turnLeft() {
        currentY -= 90f;
        main.transform.rotation = Quaternion.Euler(0, currentY, 0);
        pixelated2.transform.rotation = Quaternion.Euler(0, currentY, 0);
    }
}
