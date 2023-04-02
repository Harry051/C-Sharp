using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challange_1
{
    internal class ImagePost : Post
    {
        // ImagePost derives from Post and adds a property (ImageURL) and two constructors

            public string ImageURL { get; set; }

            public ImagePost() { }

            public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
            {
                // The following properties and the GetNexID method are inherited from Post.
                this.ID = GetNextID();
                this.Title = title;
                this.SendByUsername = sendByUsername;
                this.IsPublic = isPublic;

                // Property ImageUrl is a member of ImagePost, but not of Post
                this.ImageURL = imageURL;
            }

            public override string ToString()
            {
                return String.Format($"Post #{this.ID} - {this.Title} \n{this.ImageURL} --- {this.SendByUsername}");
            }
    }
}

