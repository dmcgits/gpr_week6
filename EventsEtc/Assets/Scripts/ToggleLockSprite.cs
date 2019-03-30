using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLockSprite : MonoBehaviour {

	protected Renderer _renderer;
    // Use this for initialization
    private void Awake()
    {
        // Using awake here because in Start it was sometimes not
        // ready when the first SendMessage came in
        _renderer = gameObject.GetComponent<Renderer>();
    }
    
	void Start () {
		
	}
	
	public void SetLockedState(bool state)
	{
		if (gameObject.name == "lock_closed")
		{
			_renderer.enabled = state;
		} else if (gameObject.name == "lock_open") {
			_renderer.enabled = !state;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
