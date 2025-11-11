1. Nội dung học
   - Phát triển website giải quyết một bài toán trên thực tế theo kiến trúc .Net MVC
   - .Net C#, Git, Github
   - Công nghệ: .Net Core C#, Code First, Entity Framework
   - Kiến trúc phát triển website: MVC (Model View Controller)
   - Đánh giá kết quả học phần
     + Điểm C: Điểm danh + Làm bài thực hành
     + Điểm B: Bài kiểm tra
     + Điểm A: Làm bài thi (Thực hành + Vấn đáp)
   - Nội dung học:
     + HTML: https://www.w3schools.com/html/default.asp
     + CSS: https://www.w3schools.com/bootstrap5/index.php
     + C#: Basic, OOP => tự học
     + Tìm hiểu về kiến trúc MVC trong .Net
     + CSDL sử dụng: SQLite/Sql Server
     + Kết nối và làm việc với CSDL
     + Sử dụng Code first + Migrations để quản lý các phiên bản CSDL
     + Xây dựng chức năng CRUD + Code Generation để sinh mã nguồn dựa trên Model
     + Nhập xuất dữ liệu với Excel => Học đủ nội dung đạt 4đ-5đ
     + Phân trang dữ liệu
     + Xác thực và uỷ quyền người dùng với Identity
   - Thiết lập môi trường lập trình:
     + .Net 9.0: https://dotnet.microsoft.com/en-us/download
     + Git: https://git-scm.com/install/
     + Github: https://github.com/
     + Visual Studio Code: https://code.visualstudio.com/
     + Dbeaver: https://dbeaver.io/
     + Extensions for VS Code: C# Dev Kit, C#, IntelliCode for C# Dev Kit, C# Snippets, C# Namespace Autocompletion, Auto Close Tag, Auto Complete Tag, Auto Rename Tag
     + Docker: https://www.docker.com/
     + Tải về image SQL Server: 'docker pull mcr.microsoft.com/mssql/server:2022-latest'
     + Tạo container SQL server: 'docker run -d --name sql_server_container -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest'
2. Tài liệu môn học
   - Slide bài giảng: https://drive.google.com/drive/folders/1HQXd0UEd4v293ILj8vrp7ziWy4oBmM7E?usp=sharing
   - Tài liệu của microsoft: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio-code
3. Link thông tin môn học: https://docs.google.com/spreadsheets/d/1cWDlgvMLzJL4UX9wyLanddn-CDM-B7nJz7av0gv4RA8/edit?usp=sharing
4. Buổi học số 2
   - Branch trong git
   - Các lệnh git: git clone, git pull, git push, git merge, git checkout
5. Buổi học số 3:
   - Cách tạo project .net MVC: dotnet new mvc ...
   - namespace là gì, cách đặt tên
   - Cách tạo Controller và View
   - Định tuyến (route) trong mvc
   - IActionResult là gì? Các kiểu trả về: ViewResult, RedirectResult, RedirectToActionResult, JsonResult, FileResult, StatusCodeResult
6. Buổi học số 4: gửi nhận dữ liệu giữa Model-View-Controller
   - ViewBag, ViewData, TempData
   - Form trong HTML, Submit form (asp-action, asp-controller)
   - Tạo class trong model => Gửi nhận dữ liệu theo model
7. Bài thực hành
   - Bài thực hành buổi 1:
     + Tạo repository trên github
     + Tạo repository trên localhost => tạo file ReadMe.md => đẩy lên github
   - Bài thực hành buổi 2:
     + Làm bài thực hành HTML và CSS (Bootstrap)
     + Mỗi nội dung trong HTML, CSS làm ra một file riêng
     + Làm từ đầu đến hết phần table
   - Bài thực hành buổi 3:
     + Tạo project DemoMvc + 3 số cuối mã sinh viên => đẩy lên github => điểm danh
     + Tạo Controller: DemoController
     + Tạo view Index => chứa các nội dung của buổi học số 3
     + Tạo các action và view tương ứng để lấy ví dụ về: ViewResult, RedirectResult, RedirectToActionResult, JsonResult, FileResult, StatusCodeResult
   - Bài thực hành buổi 4:
    + Sử dụng  ViewBag, ViewData, TempData để gửi nhận dữ liệu => Cần ví dụ demo
    + Gửi nhận dữ liệu giữa Controller và View => Lấy ví dụ demo
    + Gửi nhận dữ liệu giữa Model (tạo class Student trong thư mục Models) - View (tạo form để nhập dữ liệu và có giao diện để hiển thị dữ liệu) và Controller (Có action để trả về view, và action để nhận dữ liệu và xử lý) => Lấy ví dụ demo
   - Bài thực hành buổi 5:
    + Xây dựng chức năng cho phép hiển thị view nhập tên người dùng, sau đó gửi lên controller nhận và xử lý hiển thị lên view: Xin chào + tên người dùng, ví dụ: Xin chào Phạm Quang Hiển
    + Thêm vào chức năng trên, nhập vào năm sinh và hiển thị tuổi của người dùng.
    + Xây dựng chức năng giải phương trình bậc 2
   - 