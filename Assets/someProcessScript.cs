using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class someProcessScript : MonoBehaviour {

/*
 * v0.1 20150902
 *   - Main -> Other -> Mainとシーン遷移した時、someProcessに関連付けたいIF_name, Toggle_testが
 *   Noneになってしまう。
 */

	public InputField IF_name;
	public Toggle Toggle_test;
	private static bool created = false;
	
	void Awake() {
		if (!created) {
			created = true;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
	
	void Start () {
	}
	
	void Update () {
		
	}
}