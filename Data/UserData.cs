using System.Collections.Generic;

namespace Post.Data{
    public class UserData{
        
        public static List<User> getUsers = new List<User>(){
            new User(){
                Id=1,
                Name="Kiran",
                Email="kiran@gmail.com",
                Address="London"
            },
            new User(){
                Id=2,
                Name="John",
                Email="john123@yahoo.com",
                Address="Liverpool"
            },
            new User(){
                Id=3,
                Name="David",
                Email="david@hotmail.com",
                Address="Norwich"
            }
        };
    }
}