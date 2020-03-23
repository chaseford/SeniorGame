using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator _animator;

    private bool _isInsideTrigger = false;

    void Start()
    {
        _animator = transform.Find("Door").GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;
            _animator.SetBool("open", false);
        }
    }

    void Update()
    {

        if (_isInsideTrigger)
        {
            //Pushing "A" button on the Oculus controller when within the collider opens the door
            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                _animator.SetBool("open", true);
            }
        }
    }
}