using UnityEngine;
using UnityEngine.UI;

public class StageText : MonoBehaviour


{
    public Text stagetext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if(Pin.CountPin >= 10) {
            GameManager.stagelevel += 1;
            stagetext.text = "Stage " + GameManager.stagelevel;
        }
    }
}
