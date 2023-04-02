using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_Challange_1
{
    internal class VideoPost : Post
    {
        //timer bits
        protected bool isPlaying = false;
        protected int time = 0;

        protected string VideoURL { get; set; }
        protected float VideoLength { get; set; }
        public VideoPost()
        {

        }

        public VideoPost(string title, string videoURL, float videoLength, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername= sendByUsername;
            this.VideoURL = videoURL;
            this.VideoLength = videoLength;
            this.IsPublic = true;
        }

        public override string ToString()
        {
            return String.Format($"Post #{this.ID} - {this.Title} \n{this.VideoURL}, {this.VideoLength} seconds  --- {this.SendByUsername}.");
        }

        public void Stop()
        {
            Console.ReadKey();
            Console.WriteLine($"you stopped the video after {time} seconds");
        }
        public void Play()
        {
            Timer myTimer = new Timer(TimerCallback, null, 0, 1000);
        }
        private void TimerCallback(object o)
        {
         if(time < VideoLength)
            {
                time++;
                Console.WriteLine($"{time}s");
            }
            else
            {
                Stop();
            }
              
        }

        
    }
}
