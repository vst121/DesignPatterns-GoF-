using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ArticleDialogBox : DialogBox
    {
        private ListBox articleListBox;
        private TextBox articleTextBox;
        private Button articleButton;

        public ArticleDialogBox()
        {
            articleListBox = new ListBox(this);
            articleTextBox = new TextBox(this);
            articleButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            //articleListBox.Selection = "New Selection";
            articleTextBox.Content = "";
            //articleTextBox.Content = "New Content";

            Console.WriteLine("TextBox: " + articleTextBox.Content);
            Console.WriteLine("Button: " + articleButton.Enabled);
            
        }
        public override void Changed(UIControl control)
        {
            if (control == articleListBox)
            {
                articleTextBox.Content = articleListBox.Selection;
                articleButton.Enabled = true;
            }
            else if (control == articleTextBox)
            {
                var content = articleTextBox.Content;
                articleButton.Enabled = !(content == null || content.Trim() == "");
            }
        }
    }
}
