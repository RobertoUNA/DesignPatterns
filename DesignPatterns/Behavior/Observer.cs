using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior
{
    public interface Observable
    {
        void Attatch(Observer obs);
        void Deattach(Observer obs);
        void Notify();
    }
    public interface Observer
    {
        void Update();
    }

    public class Follower : Observer
    {
        public Observable InstaProfile = null;
        public void Update()
        {
            Console.WriteLine((this.InstaProfile as InstagramProfile).LastPost);
        }
    }

    public class InstagramProfile : Observable
    {
        List<Observer> followers;
        public string LastPost= "";
        public void Attatch(Observer follower)
        {
            this.followers.Add(follower);
        }

        public void Deattach(Observer follower)
        {
            this.followers.Remove(follower);
        }

        public void Notify()
        {
            foreach (var follower in this.followers)
            {
                follower.Update();
            }
        }

        public void NewPost(string caption)
        {
            this.LastPost = caption;
            this.Notify();
            Console.WriteLine("New post has been uploaded");
        }
    }
}
