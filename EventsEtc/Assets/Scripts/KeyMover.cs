using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyMover : MonoBehaviour {
	
	protected bool _locked = false;
	protected Renderer _renderer;

    private void Awake()
    {
        // cache our renderer in a local variable.
        // No need to call GetComponent more than once.
        _renderer = gameObject.GetComponent<Renderer>();

    }

    void Start() {
        // Set up initial unlocked state
        _locked = false;
        gameObject.BroadcastMessage("SetLockedState", _locked);

        // Register with TriggerMoveEventOnClick that we'd like to be 
        // notified of any OnMoveRequested if it has any events. We give it
        // the local function we would like to run when it happens.
        TriggerMoveEventOnClick.OnMoveRequested += MoveRequestedHandler;
		
	}

    // Define the function we'd like to handle any OnMoveRequested events
    private void MoveRequestedHandler(String wayToMove)
    {
        if (!_locked)
        {
            switch (wayToMove)
            {
                case "up":
                    transform.position += transform.up;
                    break;
                case "down":
                    transform.position -= transform.up;
                    break;
            }
        }
    }

    private void OnMouseUpAsButton() {
        // toggle locked
        _locked = !_locked;

        //List<String> gary = new List<String> { "gary", "garry", "garree" };

        // call "SetLockedState" function on any components (monobehaviours)
        // on this gameObject and any child objects (child in scene heirarchy, 
        // not inheritance.
        gameObject.BroadcastMessage("SetLockedState", _locked);
        
        /* if (_locked)
		{ 
			_locked = false;
			
		} else {
			_locked = true;
			
		} */

    }
	
	
	// Update is called once per frame
	
	private void OnDestroy() {
		TriggerMoveEventOnClick.OnMoveRequested -= MoveRequestedHandler;
	}
}
