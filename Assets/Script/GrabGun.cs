using UnityEngine;
using UnityEngine.UI;
using System.Collections; 
// only the grab animation for right hand
public class GrabGun : MonoBehaviour
{

    
    public Sprite NextImage;
    public Sprite NextNextImage;
    public Sprite prevNextImage;
    public Sprite originalSprite;
    public Image originalObject;
    public Light gunfire;
   
 
    
    public Vector2 size = new Vector2(304.8593f, 288.6477f);
    public Vector2 size2 = new Vector2(304.8593f, 288.6477f);
    
    private void OnMouseDown()
    {
        StartCoroutine(ChangeArmSprites());
    }

    private IEnumerator ChangeArmSprites()
    {
        
        originalObject.sprite = NextImage;
        Rotate(originalObject, size, 0f, 0f, 0f);
        yield return new WaitForSeconds(0.2f); 

        gunfire.enabled = true;
        originalObject.sprite = NextNextImage;
        Rotate(originalObject, size2, 0f, 0f, 0f);
        
        yield return new WaitForSeconds(0.1f); 
        gunfire.enabled = false;
        originalObject.sprite = prevNextImage;
        Rotate(originalObject, size, 0f, 0f, 0f);
        yield return new WaitForSeconds(0.4f); 

        originalObject.sprite = originalSprite;
        Rotate2(originalObject, size);
    }

    private void Rotate(Image image, Vector2 newSize, float rotationx, float rotationy, float rotationz) { //for the animated hand
        RectTransform rectTransform = image.rectTransform;
        rectTransform.sizeDelta = newSize;
        rectTransform.localEulerAngles = new Vector3(rotationx,rotationy,rotationz);
    }

    private void Rotate2(Image image, Vector2 newSize) { //for the normal hand
        RectTransform rectTransform = image.rectTransform;
        rectTransform.sizeDelta = size;
        rectTransform.localEulerAngles = new Vector3(0,0,-90);
    }


}
