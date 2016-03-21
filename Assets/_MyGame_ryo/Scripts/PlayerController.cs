using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private float moveHorizontal;
	private float moveVertical;
	public float speed;

	// Use this for initialization
	void Start () {
		// 初期化
		rb = GetComponent<Rigidbody>(); // Unity側のPlayerのRigitBodyを取得できる
	}
	
	// Update is called once per frame
	void Update () {
		// Input系はUpdateで呼ぶルール
		moveHorizontal = Input.GetAxis("Horizontal");
		moveVertical   = Input.GetAxis("Vertical");
	}

	void FixedUpdate () {
		// 実際に動かすのはFixedUpdateで。物理運動に関するアップデートここで。
		Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );
	
		rb.AddForce(movement * speed);
	}

	// 接触した時に呼ばれる関数
	void OnTriggerEnter(Collider other) {
		// アイテムゲット(接触がItemだったら、Itemを非アクティブにする)
		if ( other.gameObject.CompareTag("Item") ) {
			other.gameObject.SetActive(false);
		}
	}
}
