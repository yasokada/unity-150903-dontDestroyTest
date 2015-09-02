using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class someProcessScript : MonoBehaviour {

/*
 * v0.2 20150903
 *   - http://qiita.com/7of9/items/78f829bcbda0067c7bcd#comment-251ad36cd28d167d3743
 *   にて教えていただいた方法を実装した。Noneの問題が解決した。
 * v0.1 20150902
 *   - Main -> Other -> Mainとシーン遷移した時、someProcessに関連付けたIF_name, Toggle_testが
 *   Noneになってしまう。
 */

	public InputField IF_name;
	public Toggle Toggle_test;
	private static bool created = false;
	
	void Awake() {
		if (!created)
		{
			created = true;
			DontDestroyOnLoad(this.gameObject);
			DontDestroyOnLoad(IF_name.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy(this.gameObject);
			Destroy(IF_name.gameObject.transform.parent.gameObject);
		}
	}
	
	void Start () {
	}
	
	void Update () {
		
	}
}