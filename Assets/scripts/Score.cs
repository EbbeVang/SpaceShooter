using UnityEngine;
using UnityEngine.UI;

namespace Assets.scripts
{
    public class Score : MonoBehaviour
    {

        private Text text; 

        // Use this for initialization
        void Start ()
        {

            text = GetComponent<Text>();
        }
	
        // Update is called once per frame
        void Update () {
		
        }

        public void UpdateScore(int score)
        {
            text.text = ""+score;
        }

    }
}
