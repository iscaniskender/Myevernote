using MyEvernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.BusinessLayer
{

    public class Test
    {
        private Repository<EvernoteUser> repo_user = new Repository<EvernoteUser>();


        public void TestList()
        {
            List<EvernoteUser> deger = repo_user.List();
            List<EvernoteUser> ozelarama = repo_user.List(x => x.Id > 5);
        }
        public void TestInsert()
        {
            int yeni =repo_user.Insert(new EvernoteUser
            {
                Name = "İskender",
                Surname = "İşcan",
                Email = "iscaniskender@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "iskenderiscan",
                ProfileImageFilename = "user_boy.png",
                Password = "123456789",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "iskenderiscan"

            });

        }
        public void TestUpdate()
        {
            EvernoteUser updateuser = repo_user.Find(x => x.Name == "iskender");

            if (updateuser != null)
            {
                updateuser.Name = "İsko Paşa";

                repo_user.Update(updateuser);
            }

        }
        public void TestDelete()
        {
            EvernoteUser deleteuser = repo_user.Find(x => x.Name == "iskender");
            if (deleteuser != null)
            {
                repo_user.Delete(deleteuser);
            }
        }
        public void CommentTest()
        {

        }

    }
}
