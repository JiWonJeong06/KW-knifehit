using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static int stagelevel = 1;

    public static GameObject gameoverui;

    public Slider slider;

    public static float max_hp;

    void Update()
    {
        slider.value = Apple_Hp.Apple_Hp_Bar/max_hp;
    }




}
