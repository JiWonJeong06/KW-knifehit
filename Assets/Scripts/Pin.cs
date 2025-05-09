using UnityEngine;
using UnityEngine.SceneManagement;


public class Pin : MonoBehaviour
{
    [SerializeField]
    private Transform hitEffectSpawnPoint;
    [SerializeField]
    private GameObject hitEffectPrefab;

    private Movement2D movement2D;

    public static  int CountPin = 0; // 모든 핀이 공유하는 정적 변수

    public static int MaxPinCount = 10;
	private bool isPaused = false;

    private void Awake()
    
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		isPaused = !isPaused;
        if (collision.CompareTag("Target"))
        {
            movement2D.MoveTo(Vector3.zero);

            transform.SetParent(collision.transform);
            collision.GetComponent<Target>().Hit();

            Instantiate(hitEffectPrefab, hitEffectSpawnPoint.position, hitEffectSpawnPoint.rotation);

            CountPin++; // 핀이 타겟에 닿았으므로 카운트 증가

            if (CountPin >= MaxPinCount)
            {

                CountPin = 0;
				

            }
	
		
		


        }
        else if (collision.CompareTag("Pin"))
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            CountPin = 0; 
            GameManager.gameoverui.SetActive(true);

        }
    }
}
