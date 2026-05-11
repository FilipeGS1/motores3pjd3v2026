using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState CurrentState;

    [SerializeField] private PlayerInput playerInput;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);

        LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;

        Debug.Log("Estado Atual: " + CurrentState);
    }

    public void LoadScene(string sceneName)
    {
        switch (sceneName)
        {
            case "Splash":
                ChangeState(GameState.Iniciando);
                break;

            case "MenuPrincipal":
                ChangeState(GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                ChangeState(GameState.Gameplay);
                break;
        }

        SceneManager.LoadScene(sceneName);
    }

    public void AssignPlayerInput()
    {
        if (playerInput != null)
        {
            Debug.Log("Input atribuído ao jogador.");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}