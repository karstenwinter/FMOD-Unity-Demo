using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + "'s Trigger 2D with " + collision.gameObject);
        // FMODUnity.RuntimeManager.StudioSystem.setParameterByName("EQ Global", eq);
    }
}
