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

        [SerializeField] private GameObject[] skillButtons;
        [SerializeField] private GameObject[] upgradeButtons;

        private int possibility;
        private int randomButton;
        
        void Start()
        {
            
        }

        
        void Update()
        {
            
        }

        void RandomButton()
        {
            for (int i = 0; i < buttonCount; i++)
            {
                possibility = Random.Range(0, 100);
                if (possibility <= 20)
                {
                    //GameObject buttonCopy = Instantiate(skillButtons[1], buttonPos[i], Quaternion.identity);
                }
                else
                {
                    //GameObject buttonCopy = Instantiate(upgradeButtons[1], buttonPos[i], Quaternion.identity);
                }
            }
        }

       
    }
}
