using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hp = 1;
    public GameObject hitMaterial;
    private Material defaultMaterial;
    // Start is called before the first frame update
    void Start()
    {
        defaultMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private IEnumerator Grow()
    {
        GetComponent<Renderer>().material = hitMaterial;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material = defaultMaterial;
    }
}
