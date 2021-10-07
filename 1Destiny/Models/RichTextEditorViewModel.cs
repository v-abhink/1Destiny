using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web.Mvc;
namespace RichTextEditor.Models
{
    public class RichTextEditorViewModel
    {
        [AllowHtml]
        [Display(Name = "Here goes the case notes.")]
        public string Message
        {
            get;
            set;
        }
    }
}