using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyManager : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            Destroy(other.gameObject);
            Invoke("GameEndSuccess", 2f);
        }
    }


    void GameEndSuccess()
    {
        SceneManager.LoadScene("_Scene_3");
    }

      
}
