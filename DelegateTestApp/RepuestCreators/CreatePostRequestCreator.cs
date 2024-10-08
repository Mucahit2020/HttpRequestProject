using DelegateTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DelegateTestApp.RepuestCreators
{
    public class CreatePostRequestCreator : BaseRequestCreator
    {
        private PostModel postModel;
        public PostModel CreatePost(PostModel post)
        {
            var responseContent = base.MakeRequest();

            return JsonSerializer.Deserialize<PostModel>(responseContent);
        }
        protected override object GetBodyObject()
        {
            return postModel;
        }

        protected override string GetBaseAdress()
        {
            return "https://jsonplaceholder.typicode.com/";
        }
        protected override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }
        protected override string GetUrlPath()
        {
            return "posts";
        }
      
    }
}
