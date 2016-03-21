using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		// 差を取っておく
		offset = this.transform.position - player.transform.position;
	}
	
	// LateUpdate は全てのUpdateが終わったら処理される
	void LateUpdate () {
		// 毎フレーム差を足しておく
		this.transform.position = player.transform.position + offset;
	}
}
