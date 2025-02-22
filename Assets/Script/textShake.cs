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
        textInfo2 = text.textInfo; 
        textCharacterCount = textInfo2.characterCount;
        for (int i = 0; i < textCharacterCount; i++) { 
            int vertexIndex = text.textInfo.characterInfo[i].vertexIndex;
            randomWiggleX = Random.Range(-0.1f, 0.1f);
            randomWiggleY = Random.Range(-0.1f, 0.1f);
            for (int j = 0; j < 4; j++) {
                currentPos = text.textInfo.meshInfo[0].vertices[vertexIndex + j]; 
                text.textInfo.meshInfo[0].vertices[vertexIndex + j] = new Vector3(currentPos.x + randomWiggleX, currentPos.y + randomWiggleY, currentPos.z);
            }
            //apply new vertices
            text.textInfo.meshInfo[0].mesh.vertices = text.textInfo.meshInfo[0].vertices;
            
        }
        text.UpdateVertexData();
        
    }
}
