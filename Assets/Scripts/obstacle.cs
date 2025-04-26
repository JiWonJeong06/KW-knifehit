using UnityEngine;
using UnityEngine.SceneManagement;
public class obstacle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Pin>() != null)
        {
            Debug.Log("GameOver by Obstacle");
            Pin.CountPin = 0;
            SceneManager.LoadScene(0);
        }
    }
}
