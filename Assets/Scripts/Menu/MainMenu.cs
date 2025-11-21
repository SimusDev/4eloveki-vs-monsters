using TMPro;
using UnityEngine;

namespace Interface
{
    public class MainMenu : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI textArea;

        private Network network;

        private void Start()
        {
            network = Network.singleton;
        }

        public void HostGame()
        {
            network.StartHost();
        }

        public void ConnectToGame()
        {
            network.networkAddress = textArea.text;
            network.StartClient();
        }

    }
}
