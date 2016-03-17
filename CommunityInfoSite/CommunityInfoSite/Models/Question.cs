using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityInfoSite.Models
{
    public class Question
    {
        private static Random generator = new Random();

        public List<Question> questions = new List<Question>();
        public List<string> Answers = new List<string>();
        public int QuestionId { get; set; }
        //public int ImageId { get; set; }

        public string Filename
        {
            get { return "Question" + ".jpg"; }
        }

        private void LoadQuestions()
        {

        }

        private void ShuffleQuestions()
        {
            //foreach
        }
        
    }
}