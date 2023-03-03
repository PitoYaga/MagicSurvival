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
        private int _randomSkillButton;
        private int _randomUpgradeButton;
        
        void Start()
        {
            RandomButton();
        }

        
        void Update()
        {
           
        }

        void RandomButton()
        {
            for (int i = 0; i < buttonCount; i++)
            {
                int skill;
                int upgrade;
                _possibility = Random.Range(0, 100);
                
                if (_possibility <= skillButtonChange - 1)
                {
                    skill = Random.Range(0, skillButtons.Length);
                    Button buttonCopy = Instantiate(skillButtons[skill], buttonPos[i].position, Quaternion.identity);

                    buttonCopy.transform.SetParent(buttonPos[i]);
                }
                else
                {
                    upgrade = Random.Range(0, skillButtons.Length - 1);
                    Button buttonCopy = Instantiate(upgradeButtons[upgrade], buttonPos[i].position, Quaternion.identity);

                    buttonCopy.transform.SetParent(buttonPos[i]);
                }
            }
        }
        
        
    }
}
