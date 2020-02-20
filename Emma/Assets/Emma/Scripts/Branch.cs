using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
	ObjectDetector playerDetector;
	public GameObject acornSpawnZone;
	[SerializeField]
	bool onSpawnZone;

	// Start is called before the first frame update
	void Start()
	{
		playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
	}

	// Update is called once per frame
	void Update()
    {
        
    }

	Vector3 screenPoint;
	Vector3 offset;

	void OnMouseDown()
	{
		if (playerDetector.isObjectInRange)
		{
			screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}
	}

	void OnMouseDrag()
	{
		if (playerDetector.isObjectInRange)
		{
			Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
			transform.position = cursorPosition;
		}
	}

	private void OnMouseUpAsButton()
	{
		if (playerDetector.isObjectInRange)
		{
			if (onSpawnZone)
			{
				acornSpawnZone.GetComponent<AcornGenerator>().GenerateAcorn(transform.position, 3);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject == acornSpawnZone)
		{
			onSpawnZone = true;
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject == acornSpawnZone)
		{
			onSpawnZone = false;
		}
	}
}
