using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_generator : MonoBehaviour
{ 
    public GameObject[] obstaclecars;
    [SerializeField] GameObject playerprefabs;
    GameObject playerprefabs_clone;

    void Start()
    {
        // InvokeRepeating take a funcation name as string ,and take another parameter for hoe much time will it callthird parameter for repeat rate
        InvokeRepeating("generateobstaclecar", 2f, 3f);
        StartCoroutine(spawnpoweup());

    }

        // Update is called once per frame
        void Update()
        {


        }
        private void generateobstaclecar()
        {

        playerprefabs_clone = Instantiate(obstaclecars[Random.Range(0, obstaclecars.Length)], new Vector3(-37.3f, transform.position.y, 0f), Quaternion.identity) as GameObject;
        Destroy(playerprefabs_clone, 3f);
                
        }
    IEnumerator spawnpoweup()
    {
       
        
            if (playerprefabs != null)
            {
   
                yield return new WaitForSeconds(3f);
            }
      
    }
}


    

    

