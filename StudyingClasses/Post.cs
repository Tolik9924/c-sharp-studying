using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingClasses
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _timeCreated;
        private int _vote;

        public void titleOfPost(string initialPost)
        {
            _title = initialPost;
        }

        public void descriptionOfPost(string initialDescription) 
        { 
            _description = initialDescription;
        }

        public string showPost() 
        {
            _timeCreated = DateTime.Now;   
            
            return $"{_title}\n\n{_description}\n{_timeCreated}\n\n{_vote}\n\n{_timeCreated}";
        }

        public  int likeDislikePost (string likeOrDislike)
        {
            if (likeOrDislike == "like") 
            {
                _vote++;
            }
            else if (likeOrDislike == "dislike")
            {
                 _vote--;
            }


            return _vote;
        }

    }
}
