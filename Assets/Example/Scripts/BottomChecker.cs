using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BottomChecker : MonoBehaviour {
	public GameObject retryButton;
	public myCamCon camCon;

	void Start()
	{
		retryButton.SetActive(false);
	}

	void OnTriggerEnter(Collider other) 
	{
		retryButton.SetActive(true);
		camCon.isLookAt = true;
	}

	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	 
}
