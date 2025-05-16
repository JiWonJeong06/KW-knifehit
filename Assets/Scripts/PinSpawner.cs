using UnityEngine;

public class PinSpawner : MonoBehaviour
{
	[SerializeField]
	private	GameObject	pinPrefab;
	public GameObject Apple_Spawner;
	private void Update()
	{
		if ( Input.GetMouseButtonDown(0) )
		{
			Instantiate(pinPrefab, transform.position, Quaternion.identity).GetComponent<Pin>().Apple_Spawner = Apple_Spawner;
		}
	}
}
