using BurguerMania.Models;

namespace BurguerMania.Data
{
    public class DbSeeder
    {
        public static void Seed(MyDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Id = 1,
                        Title = "X-Vegan",
                        Text = "Hamburguers feitos para clientes Veganos.",
                        Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__"
                    },
                    new Category
                    {
                        Id = 2,
                        Title = "X-Fitness",
                        Text = "Hamburguers feitos para quem segue uma rotina Fitness.",
                        Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Id = 1,
                        Title = "X-Alface-Premium",
                        Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
                        DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
                        Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
                        Price = 45,
                        CategoryId = 1
                    },
new Product
{
    Id = 2,
    Title = "X-Tomate",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 1
},
new Product
{
    Id = 3,
    Title = "X-Frutas",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 1
},
new Product
{
    Id = 4,
    Title = "X-Terremoto",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 3
},
new Product
{
    Id = 5,
    Title = "X-Tsunami",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 3
},
new Product
{
    Id = 6,
    Title = "X-Pressão-Alta",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 3
},
new Product
{
    Id = 7,
    Title = "X-Whey",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 2
},
new Product
{
    Id = 8,
    Title = "X-Creatina",
    Text = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    DetailedDescription = "Pão, Habúrguer, alface, tomate, queijo e maionese",
    Image = "https://s3-alpha-sig.figma.com/img/62e9/60a8/916fccb3e9f039a653a71fe3c3b305a0?Expires=1734307200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=Zmf8y8aitL8FKBOcn4QqX1F1O2zRKzNdmJcOivGe1hOdBWa6t74U7rqv6zXSx-TCAQWArDFljug4IH0JXqJZP2NxVxpyDToiFrf4QlvNZVFeASIsUy0QKUmJuiWceV7TbI3No0PyUz4okFFvSIEvNhqmPYfck9gcZ8fm1eedjGGaqorYvED~GdWuGi-t6Lu6tk6tW-2yKPOLqntBK3I6ks2RwqGJE6UG6nhWvHUHNmi2O~RncR9q70XSXH28ORDxx2boYrtJ7iMIYOrQzS739MFDkKOwlt4qdcgWDz7cZ6HC1iUmLI~BtmMrf6mT9EWzLi7J9BavfnjhKhscKgQRwQ__",
    Price = 45,
    CategoryId = 2
}

                );
                context.SaveChanges();
            }
        }
    }
}
