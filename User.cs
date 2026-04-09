using System;

namespace MainfreightProject
{
    //this is the user class whihc is used to stotre common user details, for all the different users in the mainfreihgt system
    public class User
    {
        // i have used private to make sure that external perosnalle cannot enter or view user informaiton, for privacu reasons
        private string userID;
        private string name;
        private string email;

        //this will intialise the user object
        public User(string userID, string name, string email)
        {
        }

        public string ViewProfile()
        {
            return "";// i am using return so that when there is an object it can be viewed , nd whatver the object is inside it will be returned and viewable
        }
    }
}