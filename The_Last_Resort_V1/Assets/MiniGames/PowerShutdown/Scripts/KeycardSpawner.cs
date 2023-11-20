using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardSpawner : MonoBehaviour
{
    //GameObjects to tie the spawners into the actual game world
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;

    //Used to hold the prefab of the keycard that will be spawned into the world
    public GameObject keycardPrefab;

    //Will hold the spawn location of the keycard
    private GameObject keycardSpawn;

    //Creates a list for the spawners
    List<GameObject> spawners = new List<GameObject>() {};

    // Start is called before the first frame update
    void Start()
    {
        //Adds the spawners to the spawn list
        AddSpawners();

        //Calls to spawn the keycard
        SpawnKeycard();
    }

    //When called it will spawn the keycard where the chosen spawner is at
    private void SpawnKeycard()
    {
        //Obtains a spawner from the spawner list to be used as the spawner for the keycard
        keycardSpawn = spawners[Random.Range(0, spawners.Count)];
        //Logs which spawner was selected in the console
        Debug.Log(keycardSpawn);

        //Generates the keycard from where the spawner is located
        Instantiate(keycardPrefab, keycardSpawn.transform.position, keycardSpawn.transform.rotation);
    }

    //When called it will add the spawners into the spawn list
    private void AddSpawners()
    {
        //Inserts all the gameobjects in manually to the spawn list
        spawners.Add(spawner1);
        spawners.Add(spawner2);
        spawners.Add(spawner3);

        //Tells the console all the spawners found in the spawner list
        foreach (GameObject str in spawners)
        {
            print(str);
        }
    }
}