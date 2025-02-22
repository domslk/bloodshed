using UnityEngine;
using TMPro;
public class textShake : MonoBehaviour
{   

    [SerializeField] TextMeshProUGUI text;
    private TMP_TextInfo textInfo = text.textInfo;
    private float characterCount = textInfo.characterCount;
    private int j = 0;
    private Vector2 randomWiggle;
    private Vector3 currentPos;
    
    
    void Update()
    {
        for (int i = 0; i < characterCount * 4; i++) { //cc*4 because 4 vert. for each renderred letter 
            if (j == 0) {
                randomWiggle = (Random.Range(-0.03, 0.03), Random.Range(-0.03, 0.03))
            }
            currentPos = text.textInfo.meshInfo[0].vertices[i];
            text.textInfo.meshInfo[0].vertices[i] = new Vector3();
        }
    }
}
