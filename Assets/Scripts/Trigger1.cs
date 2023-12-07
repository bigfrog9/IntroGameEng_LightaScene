using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger1 : MonoBehaviour
{
    public PlayableDirector GnomeAnimation;

    public bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        //the public animation clip unselected itself when I had this running. Turns out it all works fine when i remove this.
        //GnomeAnimation = GetComponent<PlayableDirector>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && triggered == false)
        {
            GnomeAnimation.Play();

            triggered = true;
        }
    }
}
