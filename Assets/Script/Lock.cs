using UnityEngine;

public class Lock : MonoBehaviour
{
    public OpenDoor door;
    

    private void OnMouseDown()
    {
        door.toggleLock();
        Debug.Log($"Lock clicked! Value: {door.isLocked}");
    }
}
