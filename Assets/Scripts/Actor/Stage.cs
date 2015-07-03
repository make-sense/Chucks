using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Stage : Actor {

	public void ToggleRunStop ()
	{
		_isRun = !_isRun;
		SetUI ();
	}

	public void Run ()
	{
		_isRun = true;
		SetUI ();
	}

	public void Stop ()
	{
		_isRun = false;
		SetUI ();
	}

	public bool IsRun ()
	{
		return _isRun;
	}

	public void Restart ()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	void SetUI ()
	{
		Image image = GetComponentInChildren<Image> ();
		if (image == null)
			return;

		if (_isRun) 
			image.name = "1408105883_traffic_lights_green";
		else 
			image.name = "1408105883_traffic_lights_red";
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log("Stage::OnTriggerEnter");
		if (other.tag == "Chuck") 
		{
			Debug.Log(other.name);
		}
	}

	bool _isRun = false;

	// Use this for initialization
	void Start () {
		base.Start ();
	}
	
	public override void Refresh () 
	{
	}

	// Update is called once per frame
	void Update () {

		List<Actor> actors = ActorManager.Instance.GetActors ();
		foreach (Actor actor in actors) 
		{
			actor.Refresh ();
		}

//		if (IsRun ()) 
//		{
//			List<Chuck> chucks = ChuckManager.Instance.GetChucks ();
//			foreach (Chuck chuck in chucks)
//			{
//				if (chuck.IsRoot ())
//				{
//					chuck.Execute ();
//				}
//			}
//		}
	}
}
