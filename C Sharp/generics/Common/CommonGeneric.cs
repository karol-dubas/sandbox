using System;

namespace generics.Common
{
    public class CommonGeneric
    {
        public CommonGeneric()
        {
            var userRepository = new Repository<User>();
            
            var bookRepository = new Repository<Book>();
        }
    }
}