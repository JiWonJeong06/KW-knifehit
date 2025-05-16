using UnityEngine;

public class Apple_Spawner : MonoBehaviour
{

    public GameObject apple_prefab;
    public GameObject apple_inst;

    void Start()
    {
        Apple_Spawn();
    }
    public void Apple_Spawn()
    {
        apple_inst = Instantiate(apple_prefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }
}
