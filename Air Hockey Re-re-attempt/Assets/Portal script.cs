using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portalscript : MonoBehaviour
{
    public float Minx, Maxx, Miny, Maxy;

    public GameObject Portal;

    // Start is called before the first frame update
  
    
    void Start()
    {
        StartCoroutine(SpawnPortal());
    }

    IEnumerator SpawnPortal()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f, 15f));

            Vector3 randomposition = new Vector3(Random.Range(Minx, Maxx), Random.Range(Miny, Maxy), 0f);

            GameObject portal = Instantiate(Portal, randomposition, Quaternion.identity);

            yield return new WaitForSeconds(15f);

            Destroy(portal);
        }
    }
}

