using UnityEngine;
using UnityEngine.UI;

public class ClearText : MonoBehaviour


{
    public Text cleartext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if(Pin.CountPin >= 7) {
            cleartext.text = "Clear";
        }
    }
}
