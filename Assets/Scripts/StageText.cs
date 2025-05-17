using UnityEngine;
using UnityEngine.UI;

public class StageText : MonoBehaviour


{
    public Text stagetext;
    public GameManager gameManager;
    void Start() {

   gameManager = gameManager.GetComponent<GameManager>();
    }
    void Update()
    {
       
            
            stagetext.text = "Stage " + gameManager.GetComponent<GameManager>().stagelevel;
        
    }
}
