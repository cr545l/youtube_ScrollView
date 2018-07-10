using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewAdd : MonoBehaviour
{
	[SerializeField]
	private GameObject _elementPrefab = null;

	[SerializeField]
	private Transform _content = null;

	public void AddElement ()
	{
		var instance = Instantiate( _elementPrefab );
		instance.transform.SetParent( _content );
		
	}
}
