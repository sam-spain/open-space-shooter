using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) 
        {
            TogglePause();
        }
    }
    public void TogglePause() 
    {
        if(pauseMenu.activeSelf) 
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        } else 
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }
}
