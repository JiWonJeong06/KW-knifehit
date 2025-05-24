using UnityEngine;

public class PinSpawner : MonoBehaviour
{
	[SerializeField]
	private	GameObject	pinPrefab;
	public GameObject Apple_Spawner;

	public GameObject gameManager;

	public GameObject inst_pin;

	public GameObject[] KnifeList;

	public Sprite[] KnifeSprite;

	public GameObject weaponEvolution;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			inst_pin = Instantiate(pinPrefab, transform.position, Quaternion.identity);
			inst_pin.GetComponent<Pin>().Apple_Spawner = Apple_Spawner;
			inst_pin.GetComponent<Pin>().gameManager = gameManager;
			inst_pin.GetComponent<Pin>().weaponEvolution = weaponEvolution;
			
		}
	}
}
