using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class someProcessScript : MonoBehaviour {
	
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