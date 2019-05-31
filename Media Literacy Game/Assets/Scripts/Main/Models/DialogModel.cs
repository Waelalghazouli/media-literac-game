using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Models
{
    class DialogModel
    {
        public int id { get; set; }
        public string text { get; set; }
        public string descImage { get; set; }
        public string speakerImage { get; set; }

        public DialogModel(int id, string text, string descImage, string speakerImage)
        {
            this.id = id;
            this.text = text;
            this.descImage = descImage;
            this.speakerImage = speakerImage;
        }

        public DialogModel()
        {
            // default
        }
    }
}
