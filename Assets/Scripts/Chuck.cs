using UnityEngine;
using System.Collections;

public class Chuck : MonoBehaviour {

	enum STATE {
		NONE,
		INIT,
		READY,
		RUNNING,
		DONE,
	}

	STATE state = STATE.NONE;

	Chuck root = null;
	Chuck left = null;
	Chuck right = null;

	Actor actor = null;
	Action action = null;

	public System.Guid Guid;

	// Use this for initialization
	void Start () {
		state = STATE.INIT;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Execute () {
		// 1. Check valid

		// 2. Execute self

		// 3. Execute left
		if (left != null)
			left.Execute ();

		// 4. If finish self, Execute right
		if (right != null)
			right.Execute ();
	}
}
