using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        StartCoroutine(Disappear(0.1f));

        IEnumerator Disappear(float timeSec)
        {
            GetComponent<MeshRenderer>().enabled = true;
            yield return new WaitForSeconds(timeSec);
            if (other.collider.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}
