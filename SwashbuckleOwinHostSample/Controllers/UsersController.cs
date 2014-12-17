using SwashbuckleOwinHostSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SwashbuckleOwinHostSample.Controllers
{
	public class UsersController : ApiController
	{
		/// <summary>
		/// ユーザをすべて取得します
		/// </summary>
		/// <returns></returns>
		public IEnumerable<User> Get()
		{
			var tag = new Tag() { Id = 1, Text = "class-a" };

			return new List<User>() 
			{
				new User() { Id = 1, Name = "Jon", Tags = new List<Tag>() { tag }  },
				new User() { Id = 2, Name = "Allison", Tags = new List<Tag>() { tag } }
			};
		}

		public User Get(int id)
		{
			return new User();
		}

		public void Post([FromBody]User user)
		{
		}

		public void Put(int id, [FromBody]User user)
		{
		}

		public void Delete(int id)
		{
		}
	}
}
