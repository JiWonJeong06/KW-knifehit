using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pin : MonoBehaviour
{
    [SerializeField]
    private Transform hitEffectSpawnPoint;
    [SerializeField]
    private GameObject hitEffectPrefab;

    private Movement2D movement2D;

    public GameObject Apple_Spawner;
	private bool isPaused = false;

    public float damage = 10f;

    public float add_value = 10f;

    public float max_hp;
    private void Update()

    {
        movement2D = GetComponent<Movement2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		isPaused = !isPaused;
        if (collision.CompareTag("Pin"))
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Apple_Hp.Apple_Hp_Bar = 100f;
            GameManager.stagelevel = 1;
        }
        else if (collision.CompareTag("Target"))
        {
            movement2D.MoveTo(Vector3.zero);

            transform.SetParent(collision.transform);
            collision.GetComponent<Target>().Hit();

            Instantiate(hitEffectPrefab, hitEffectSpawnPoint.position, hitEffectSpawnPoint.rotation);

       
            Apple_Hp.Apple_Hp_Bar -= damage;
            print(Apple_Hp.Apple_Hp_Bar);



            if (Apple_Hp.Apple_Hp_Bar <= 0)
            {
                print("Clear");
                Destroy(collision.gameObject);
                GameManager.stagelevel += 1;

                Apple_Spawner.GetComponent<Apple_Spawner>().Apple_Spawn();
                Apple_Hp.Apple_Hp_Bar = 100 + add_value;
                max_hp = 100 + add_value;
                GameManager.max_hp = max_hp;
            }





        }
    }
}
