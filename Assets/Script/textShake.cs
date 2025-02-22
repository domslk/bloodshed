using UnityEngine;
using TMPro;
public class textShake : MonoBehaviour
{   

    [SerializeField] TextMeshProUGUI text;
    private float textCharacterCount;
    private TMP_TextInfo textInfo2;
    private int j = 0;
    private float randomWiggleX;
    private float randomWiggleY;
    private Vector3 currentPos;
    
    
    void Update()
    {   
        j = 0;
        textInfo2 = text.textInfo;
        textCharacterCount = textInfo2.characterCount;
        for (int i = 0; i < textCharacterCount * 4; i++) { //cc*4 because 4 vert. for each renderred letter 
            if (j == 0) {
                randomWiggleX = Random.Range(-0.5f, 0.5f);
                randomWiggleY = Random.Range(-0.5f, 0.5f);
            } else if (j == 4) {
                j = 0;
            }
            currentPos = text.textInfo.meshInfo[0].vertices[i];
            text.textInfo.meshInfo[0].vertices[i] = new Vector3(currentPos.x + randomWiggleX, currentPos.y + randomWiggleY, currentPos.z);
            j += 1;
        }
        //apply new vertices
        text.textInfo.meshInfo[0].mesh.vertices = text.textInfo.meshInfo[0].vertices;
        text.UpdateVertexData();
    }
}
