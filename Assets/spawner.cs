using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] GameObject objeto;
    private float timer = 0;
    private float timeOut = 5;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject = Instantiate(objeto);
        newObject.transform.position += new Vector3(21.63f, Random.Range(-4, 4));
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timeOut)
        {
            GameObject newObject = Instantiate(objeto);
            newObject.transform.position += new Vector3(21.63f, Random.Range(-4,4));
            Destroy(newObject, 20);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
