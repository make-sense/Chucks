using UnityEngine;
using System.Collections.Generic;

public class ChuckManager : MonoBehaviour {

	List< BinaryTree<Chuck> > _chucks = new List< BinaryTree<Chuck> > ();

	void Insert (Chuck at, Chuck value) {
		
	}

	public void Add (Chuck chuck) {
//		_chucks.Add(chuck);
	}
	
	public void Remove (Chuck chuck) {
//		_chucks.Remove(chuck);
	}
	
	public int Count () {
		return _chucks.Count;
	}
	
	public Chuck Get(System.Guid guid) {
//		foreach (Chuck chuck in _chucks) {
//			if (chuck.Guid == guid)
//				return chuck;
//		}
		return null;
	}
	
	public List<Chuck> GetChucks() {
//		return _chucks;
		return null;
	}
	
	private static ChuckManager _instance = null;
	public static ChuckManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindObjectOfType(typeof(ChuckManager)) as ChuckManager;
			}
			return _instance;
		}
	}
}
