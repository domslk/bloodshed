using UnityEngine;
using TMPro;
public class textShake : MonoBehaviour
{   

    [SerializeField] TextMeshProUGUI text;
    private float textCharacterCount;
    private TMP_TextInfo textInfo2;
    private int j = 0;
    private float randomWiggle;
    private Vector3 currentPos;
    
    
    void Update()
    {
        textInfo2 = text.textInfo;
        textCharacterCount = textInfo2.characterCount;
        for (int i = 0; i < textCharacterCount * 4; i++) { //cc*4 because 4 vert. for each renderred letter 
            if (j == 0) {
                randomWiggle = Random.Range(-0.03f, 0.03f);
            }
            currentPos = text.textInfo.meshInfo[0].vertices[i];
            text.textInfo.meshInfo[0].vertices[i] = new Vector3(currentPos.x + randomWiggle, currentPos.y + randomWiggle, currentPos.z);
            j += 1;
        }
    }
}
