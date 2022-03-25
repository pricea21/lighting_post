using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public void Next ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
