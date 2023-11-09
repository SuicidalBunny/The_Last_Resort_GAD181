using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class NextScene : MonoBehaviour
{
    public string destinationSceneName; // The name of the destination scene

    private bool canInteract = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
               if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            ChangeScene();
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
       
            canInteract = true;
       
    }

    private void OnTriggerExit(Collider other)
    {
    
            canInteract = false;
        
    }

    private void ChangeScene()
    {
        if (!string.IsNullOrEmpty(destinationSceneName))
        {
            SceneManager.LoadScene(destinationSceneName);
        }
    }
}
