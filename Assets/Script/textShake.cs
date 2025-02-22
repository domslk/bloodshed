using UnityEngine;
using TMPro;
public class textShake : MonoBehaviour
{   
    [SerializeField] TextMeshProUGUI text;
    private float wiggleAmount;
    private Vector3 position = new Vector3(-123f, -282f, 0f);

    public bool animationEnd = false;
    void Update()
    {   
        wiggleAmount = Random.Range(-0.2f, 0.2f);
        text.transform.position = new Vector3(text.transform.position.x + wiggleAmount, text.transform.position.y + wiggleAmount, text.transform.position.z);
    }


}
