using Game;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Skills
{
    public class LevelUpButtons : MonoBehaviour
    {
        [SerializeField] private int buttonCount = 3;
        [SerializeField] private int skillButtonChange = 20;
        [SerializeField] private int upgradeButtonChange = 80;

        [SerializeField] private Transform[] buttonPos;

        //[SerializeField] private GameObject fireBallSkill;
        //[SerializeField] private GameObject thunderSkill;

        [SerializeField] private Button[] skillButtons;
        [SerializeField] private Button[] upgradeButtons;

        private int _possibility;
        private int _randomButton;
        
        void Start()
        {
            
        }

        
        void Update()
        {
            if (ValueBank.levelUp)
            {
                RandomButton();
            }
        }

        void RandomButton()
        {
            for (int i = 0; i < buttonCount; i++)
            {
                _possibility = Random.Range(0, 100);
                if (_possibility <= skillButtonChange)
                {
                    var buttonCopy = Instantiate(skillButtons[1], buttonPos[i].position, Quaternion.identity);
                }
                else
                {
                    var buttonCopy = Instantiate(upgradeButtons[1], buttonPos[i].position, Quaternion.identity);
                }
            }
        }
        
        
    }
}
