using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.Pacebook
{
    class DialogManager
    {
        List<DialogModel> dialogs;
        HardCodedDialogs introductioDialogs;

        public int currentDialog { get; set; }


        public DialogManager(List<DialogModel> dialogs)
        {
            this.dialogs = dialogs;
            introductioDialogs = new HardCodedDialogs();
            // start from the first dialog
            currentDialog = 0;
        }

        public int amountOfDialogs()
        {
            return dialogs.Count();
        }

        public DialogModel loadDialog()
        {
            var dialog = dialogs[currentDialog];
            return dialog;
        }

        public DialogModel nextDialog()
        {
            
            if (currentDialog < dialogs.Count())
            {
                
                var dialog = dialogs[currentDialog];
                return dialog;
            }
            else
            {
                return null;
            }
        }



        public DialogModel previousDialog()
        {

                var dialog = dialogs[currentDialog];
                return dialog;
           
        }
    }
}

