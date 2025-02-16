using UnityEngine;
using System.Collections;
using TMPro;
public class Migrant : MonoBehaviour
{
    public float distance = 100f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource walkingSound;
    public int randomIntDistance;
    public int randomIntTime;
    private bool updated = false;
    public bool isOutside = false;
    [SerializeField] TextMeshProUGUI statusText;
    public bool migrantShown = true;
    public bool playing {get; private set;} = false;
    public moster monster;

    public Transform MigrantObj;
    private bool huntRunning = false;


    void Start() {
        updated = false;
        randomIntTime = Random.Range(20,30);
        randomIntDistance = Random.Range(30, 100);
        StartCoroutine(StartCountdown());
    }

    void Update() {
        if (updated) {
            updated = false;
            randomIntTime = Random.Range(15,25);
            randomIntDistance = Random.Range(10,100); // 10 - 100
            StartCoroutine(StartCountdown());
        } else if (distance <= 40f) {
            if (!huntRunning) {
                StartCoroutine(MigrantHunt());
            }
            
            if (!walkingSound.isPlaying && playing) {
                playing = false;
                walkingSound.Play();
                Debug.Log("sound is playing");
            }
            
            
        } 
    }

    
    private IEnumerator StartCountdown() {
        yield return new WaitForSeconds(randomIntTime);
        distance -= randomIntDistance;
        updated = true;
    }

    private void OnMouseEnter() {
        statusText.text = "R̸̡̧̼͙̙͖̥͙̀̊̑̃̚Ȕ̶̢̘̟͉͍̱̺̗͖̀̕̚͘N̴̢̟͕̣͉͖̥̥͖̗̫̭̲̹̣͇̉́̆̎̌̍̇͛̎͛͋̆̚͜";
    }

    private void OnMouseDown() {
        distance += Random.Range(25,60);
        HideMigrant();
    }

    private void OnMouseExit() {
        statusText.text = "";
    }

    private void ShowMigrant() {
        migrantShown = true;
        MigrantObj.transform.position = new Vector3(9.27f, 1.129f, 13.25f);
    }

    private IEnumerator MigrantHunt() {
        ShowMigrant();
        isOutside = true;
        playing = true;
        huntRunning = true;
        yield return new WaitForSeconds(3.8f);
        huntRunning = false;
        if (migrantShown) {
            StartCoroutine(monster.Death());
        }
            
        
    }

    private void HideMigrant() {
        migrantShown = false;
        audioSource.Play();
        MigrantObj.transform.position = new Vector3(9.27f, 1.129f, 0f);
    }
}
