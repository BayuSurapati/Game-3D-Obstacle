using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Tabrak Tembok");

        if(other.collider.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            StartCoroutine(SwitchColor(1f));

            //gameObject.tag = "Hit";
        }

        IEnumerator SwitchColor(float timeToSeconds)
        {
            if (other.collider.tag != "Player")
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
            }
            yield return new WaitForSeconds(timeToSeconds);

            GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
