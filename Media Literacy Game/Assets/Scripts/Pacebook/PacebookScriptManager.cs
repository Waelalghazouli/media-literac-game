using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Pacebook
{
    public class PacebookScriptManager : MonoBehaviour
    {
        // Question Canvas
        public Button yesBtn;
        public Button noBtn;
        public Image newsImage;
        public Text questionText;

        // Feedback Canvas
        public Text feedbackText;
        public Button nextBtn;

        // Canvases
        public Canvas questionCanvas;
        public Canvas feedbackCanvas;

        HardCodedQuestions questions;

        List<QuestionModel> questionList;

        // Use this for initialization
        void Start()
        {
            // At the start of the scene
            questionCanvas.gameObject.SetActive(true);
            feedbackCanvas.gameObject.SetActive(false);
        }

        private void getQuestions()
        {
            questionList = questions.GetQuestions();
        }

        // to handle the buttons
        private void onButtonClick(Button buttonId)
        {

            // At the start


        }
    }


}
