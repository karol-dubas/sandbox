using System;
using AutoMapper;

namespace AutoMapper_examples
{
    internal class Program
    {
        private static void Main()
        {
            var mapper = Config();
            Basics(mapper);
            Flattening(mapper);
        }

        private static IMapper Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // 2 opcje
                cfg.AddProfile<MapperProfile>();
                //cfg.AddProfile(new MapperProfile());

                // można też automatycznie wyszkuać i dodać
                // https://docs.automapper.org/en/latest/Configuration.html#assembly-scanning-for-auto-configuration
            });

            // 2 opcje
            var mapper = config.CreateMapper();
            //var mapper = new Mapper(config);
            return mapper;
        }

        private static void Basics(IMapper mapper)
        {
            var user = new User
            {
                FirstName = "Karol",
                LastName = "Fajny",
                Gender = 'M',
                BirthDate = new DateTime(1999, 3, 22)
            };

            var userDto = new UserDto();
            // tutaj przemapuje, ale nigdzie nie zapisze
            mapper.Map<UserDto>(user);
            // teraz zapisze
            userDto = mapper.Map<User, UserDto>(user);
            //userDto1 = mapper.Map<UserDto>(user1);
            userDto.PrintDetails();

            var userDto2 = new UserDto();
            // wpisanie 2 obiektów do () = zapisze do tego 2-giego obiektu
            mapper.Map(user, userDto2);
            userDto2.PrintDetails();
        }

        private static void Flattening(IMapper mapper)
        {
            var customer = new Customer
            {
                Name = "George Costanza"
            };

            var order = new Order
            {
                Customer = customer
            };

            order.AddOrderLineItem(new Product
            {
                Name = "Bosco",
                Price = 4.99m
            }, 15);

            order.AddOrderLineItem(new Product
            {
                Name = "Bread",
                Price = 1.49m
            }, 4);

            var dto = mapper.Map<OrderDto>(order);

            // unflattening tylko dla ReverseMap()
            var unflattened = mapper.Map<Order>(dto);
        }
    }
}