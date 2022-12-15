using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int ILevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToLoadLevel = false;
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
        GameObject collisionGameObject = collision.gameObject;
            LoadScene();
    }
    void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(ILevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}
