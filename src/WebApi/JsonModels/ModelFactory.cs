using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.JsonModels
{
    public class ModelFactory
    {
        public static CommentModel Map(Comments comment, IUrlHelper url)
        {
            // hint: use AutoMapper
            return new CommentModel
            {
                Url = url.Link(Config.CommentRoute, new { id = comment.id }),
                id = comment.id,
                postid = comment.postid,
                score = comment.score,
                text = comment.text,
                createdate = comment.createdate,
                userid = comment.userid
            };
        }

        public static Comments Map(CommentModel model)
        {
            // hint: use AutoMapper
            return new Comments
            {
                id = model.id,
                postid = model.postid,
                score = model.score,
                text = model.text,
                createdate = model.createdate,
                userid = model.userid
            };
        }
    }
}
