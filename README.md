# EF_EBookStore
- Basic Web API using EF core to build
- Front-end : Razor page use Entity Frameword to build automatic
- Bạck=end: Use API .NET core web API
- Database : SQL Server

- Thay đổi đương dẫn databse trong file BusinessObject/Models/ApplicationDbContext.cs ở line 23
- Thực hiện mìgration trong project BusinessObject để tạo database :
  + Mở Terminal dùng lệnh EF : dotnet ef migrations add [InitDB]
  + Lệnh trên chạy xong tiếp tục chạy lệnh : dotnet ef database update để SQL server cập nhật database
- Chạy file data.sql bên ngoài project để lấy data cho database
- Chạy project với 2 project chạy song song là eBookStore và eBookStoreWebAPI

Login với 
+ username : admin@ebookstore.com
+ pass : admin@@
* Có thể thay đổi thông tin đăng nhập trong eBookStoreWebAPI/appsettings.json
