using Booking_Movie.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<AppUser>();
            _ = modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { Id = Guid.Parse("AB778D64-0D3E-4AB6-BC7C-A50B93DE737B"), FirstName = "Đăng", LastName = "Nguyễn Minh", UserName = "dangnhinho", Email = "dangit19@gmail.com", PhoneNumber = "0364125410", PasswordHash = hasher.HashPassword(null, "Huy!123") },
                new AppUser() { Id = Guid.Parse("D83AC55F-EF97-468F-A493-E9A8EEEC395E"), FirstName = "Khánh", LastName = "Nguyễn", UserName = "khanhalone", Email = "khanhit19@gmail.com", PhoneNumber = "0364125420", PasswordHash = hasher.HashPassword(null, "Huy!123") },
                new AppUser() { Id = Guid.Parse("C8A04D06-2334-4806-92A6-6F6DB3ED6692"), FirstName = "Thảo", LastName = "Nguyễn Hoàng", UserName = "thaoit", Email = "thaoit19@gmail.com", PhoneNumber = "0364125430", PasswordHash = hasher.HashPassword(null, "Huy!123") });
            modelBuilder.Entity<Nationality>().HasData(
                new Nationality() { Id= "vi", Code= "vi", Name="Việt Nam", Description="Quốc gia Việt Nam", FlagActor=true, FlagDirector=true,FlagMovie=true,FlagProducer=true},
                new Nationality() { Id = "es", Code = "es", Name = "Tây Ban Nha", Description = "Quốc gia Tây Ban Nha", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "en", Code = "en", Name = "Mỹ", Description = "Quốc gia Mỹ", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "ko", Code = "ko", Name = "Hàn Quốc", Description = "Quốc gia Hàn Quốc", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "zh", Code = "zh", Name = "Trung Quốc", Description = "Quốc gia Trung Quốc", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "au", Code = "au", Name = "Úc", Description = "Quốc gia Úc", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "tha", Code = "tha", Name = "Thái Lan", Description = "Quốc gia Thái Lan", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "ms", Code = "ms", Name = "MaLaysia", Description = "Quốc gia Malaysia", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true },
                new Nationality() { Id = "ukr", Code = "ukr", Name = "Ukraina", Description = "Quốc gia Ukraina", FlagActor = true, FlagDirector = true, FlagMovie = true, FlagProducer = true }
                );

            modelBuilder.Entity<Location>().HasData(
                new Location() { Id = 1, Name = "TP Hồ Chí Minh"},
                new Location() { Id = 2, Name = "TP Hà Nội" },
                new Location() { Id = 3, Name = "Cà Mau" },
                new Location() { Id = 4, Name = "Đồng Tháp" },
                new Location() { Id = 5, Name = "Cần Thơ" },
                new Location() { Id = 6, Name = "Đà Nẵng" },
                new Location() { Id = 7, Name = "Ang Giang" },
                new Location() { Id = 8, Name = "Nghệ An" },
                new Location() { Id = 9, Name = "Bến Tre" },
                new Location() { Id = 10, Name = "Hải Phòng" });


            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1,Name = "Hành động", Image = "", HomeFlag = false},
                new Category() { Id = 2,Name = "Hình sự", Image = "", HomeFlag = false},
                new Category() { Id = 3, Name = "Chiến tranh", Image = "", HomeFlag = false },
                new Category() { Id = 4, Name = "Hoạt hình", Image = "", HomeFlag = false },
                new Category() { Id = 5, Name = "Kinh dị", Image = "", HomeFlag = false },
                new Category() { Id = 6, Name = "Lãnh mạng", Image = "", HomeFlag = false },
                new Category() { Id = 7, Name = "Lịch sử", Image = "", HomeFlag = false },
                new Category() { Id = 8, Name = "Phiêu lưu", Image = "", HomeFlag = false },
                new Category() { Id = 9, Name = "Tâm lý", Image = "", HomeFlag = false },
                new Category() { Id = 10, Name = "Ly kì", Image = "", HomeFlag = false },
                new Category() { Id = 11, Name = "Thần thoại", Image = "", HomeFlag = false });


            modelBuilder.Entity<Director>().HasData(
                new Director() { ID = new Guid("01C9B39B-AD45-41FE-ACE0-244B38254F99"), Name = "Jaume Collet-Serra", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "es" },
                new Director() { ID = new Guid("88034877-A697-472C-A2D8-3D133792C463"), Name = "Bảo Nhân", DateOfBirth = new DateTime(1986, 02, 23), Height = 1.85f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "vi" },
                new Director() { ID = new Guid("55266710-251A-45A1-B11B-D2E2E7E104EA"), Name = "Nam Cito", DateOfBirth = new DateTime(1985, 07, 23), Height = 1.65f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "vi" },
                new Director() { ID = new Guid("C089DB2A-468A-4287-8B45-A832BB10FE93"), Name = "Jaume Collet-Serra", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "es" },
                new Director() { ID = new Guid("FF9A4CC9-3191-4DA4-9BF8-6CD8BD129138"), Name = "Ilya Maksimov", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "en" },
                new Director() { ID = new Guid("E37EDC8F-48FF-40FE-BCFC-D37A689A5B04"), Name = "Lee Seok Hoon", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "ukr" },
                new Director() { ID = new Guid("EB504714-17F9-4AA3-8B5B-6360102F8453"), Name = "Brando Lee", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "en" },
                new Director() { ID = new Guid("7E02A8DB-94E7-4842-8B35-96C48D0E0C63"), Name = "Parker Finn", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "ms" },
                new Director() { ID = new Guid("E717C0C2-82F5-46A8-8E50-95999E661A67"), Name = "Park Gyu Tae", DateOfBirth = new DateTime(1974, 03, 23), Height = 1.75f, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Description = "", ViewCount = 0, Image = "", NationalityId = "tha" }
                );

            modelBuilder.Entity<Producer>().HasData(
                new Producer() { ID = new Guid("7935C4E4-A92A-401C-A994-7BCF420E00AA"), Name= "MAR6 Pictures", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="vi" },
                new Producer() { ID = new Guid("8E82C641-C8F2-4AC9-820A-F59789BBD12F"), Name= "GDH 559", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="tha" },
                new Producer() { ID = new Guid("E8A07088-DE72-4B6C-BDD8-14370AB2A3AB"), Name= "Warner Bros", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="en" },
                new Producer() { ID = new Guid("272D7CD7-6ED5-428D-9BD9-DDEB0F5AFFEA"), Name= "CJ Entertainment", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="ko" },
                new Producer() { ID = new Guid("34652A25-E4CE-4994-A412-84AE013D775B"), Name= "Lionsgate", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="en" },
                new Producer() { ID = new Guid("C6C6386C-78D9-4E32-B993-D7B660210437"), Name= "Bliss Pictures", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="ms" },
                new Producer() { ID = new Guid("3F8BA972-52DA-4A37-B152-A92628E4B714"), Name= "95 Animation Studio", Image="", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId="ukr" }
                );
            modelBuilder.Entity<Actor>().HasData(
               new Actor() { ID = new Guid("354B3FAE-02FC-482F-BF68-1CC40B04C34F"), Name = "Ninh Dương Lan Ngọc", DateOfBirth= new DateTime(1990,4,4), Height = 1.64f, Description= "", Image = "",ViewCount =0, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId = "vi"  },
               new Actor() { ID = new Guid("1FA1A35A-D969-4B44-8CC0-1F6FBFF578FB"), Name = "Katy Nguyễn", DateOfBirth = new DateTime(1991, 3, 12), Height = 1.67f, Description = "", Image = "", ViewCount = 0, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId = "vi" },
               new Actor() { ID = new Guid("343D4B37-C4F7-4D24-ADB6-05ABEDA8AA41"), Name = "NSƯT Lê Khanh", DateOfBirth = new DateTime(1989, 4, 3), Height = 1.70f, Description = "", Image = "", ViewCount = 0, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId = "vi" },
               new Actor() { ID = new Guid("BF79E94C-2B38-4763-AACD-8161006E8347"), Name = "Hữu Châu", DateOfBirth = new DateTime(1988, 8, 1), Height = 1.65f, Description = "", Image = "", ViewCount = 0, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId = "vi" },
               new Actor() { ID = new Guid("26340D49-35D2-4696-ADDF-E4FC97CD5300"), Name = "Lãnh Thanh", DateOfBirth = new DateTime(1987, 4, 4), Height = 1.81f, Description = "", Image = "", ViewCount = 0, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId = "vi" },
               new Actor() { ID = new Guid("376EF100-3A18-45DD-B83C-517D2CAFC0DC"), Name = "Lê Xuân Tiền", DateOfBirth = new DateTime(1986, 2, 4), Height = 1.76f, Description = "", Image = "", ViewCount = 0, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, NationalityId = "vi" });


            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Name= "Cô Gái Từ Quá Khứ", Alias="Co_Gai_Den_Tu_Qua_Khu", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="vi", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("7935C4E4-A92A-401C-A994-7BCF420E00AA"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 2, Name= "Black Adam", Alias= "Black_Adam", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="en", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("3F8BA972-52DA-4A37-B152-A92628E4B714"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 3, Name= "Confidential Assignment 2: International", Alias= "Confidential_Assignment_2_:_International", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="vi", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("7935C4E4-A92A-401C-A994-7BCF420E00AA"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 4, Name= "Prey For The Devil", Alias= "Prey_For_The_Devil", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="ukr", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("C6C6386C-78D9-4E32-B993-D7B660210437"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 5, Name= "Don't Look At The Demon", Alias= "Don't_Look_At_The_Demon", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="tha", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("34652A25-E4CE-4994-A412-84AE013D775B"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 6, Name= "Gulliver Returns", Alias= "Gulliver_Returns", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="ms", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("272D7CD7-6ED5-428D-9BD9-DDEB0F5AFFEA"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 7, Name= "Life Is Beautiful", Alias= "Life_Is_Beautiful", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="ko", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("E8A07088-DE72-4B6C-BDD8-14370AB2A3AB"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 8, Name= "Smile", Alias="Smile", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="es", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("8E82C641-C8F2-4AC9-820A-F59789BBD12F"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" },
                new Movie() { Id = 9, Name= "Love Destiny The Movie", Alias= "Love_Destiny_The_Movie", Duration=105, VideoTrailer = "duongdan.mp4", NationalityId="vi", ReleaseDate=new DateTime(2022,10,13), ProducerId= Guid.Parse("7935C4E4-A92A-401C-A994-7BCF420E00AA"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Content ="" }
                );

            modelBuilder.Entity<MovieCategory>().HasData(
                new MovieCategory() { Id = 1, MovieId = 1, CategoryId= 9},
                new MovieCategory() { Id = 2, MovieId = 1, CategoryId = 10 },
                new MovieCategory() { Id = 3, MovieId = 2, CategoryId = 2 },
                new MovieCategory() { Id = 4, MovieId = 2, CategoryId = 3 },
                new MovieCategory() { Id = 5, MovieId = 3, CategoryId = 4 },
                new MovieCategory() { Id = 6, MovieId = 3, CategoryId = 5 },
                new MovieCategory() { Id = 7, MovieId = 4, CategoryId = 6 },
                new MovieCategory() { Id = 8, MovieId = 5, CategoryId = 6 },
                new MovieCategory() { Id = 9, MovieId = 6, CategoryId = 7 },
                new MovieCategory() { Id = 10, MovieId = 6, CategoryId = 8 },
                new MovieCategory() { Id = 11, MovieId = 7, CategoryId = 9 },
                new MovieCategory() { Id = 12, MovieId = 7, CategoryId = 10 },
                new MovieCategory() { Id = 13, MovieId = 8, CategoryId = 1 },
                new MovieCategory() { Id = 14, MovieId = 8, CategoryId = 3 },
                new MovieCategory() { Id = 15, MovieId = 9, CategoryId = 4 },
                new MovieCategory() { Id = 16, MovieId = 9, CategoryId = 5 }
                );

           modelBuilder.Entity<MovieDirector>().HasData(
                new MovieDirector() { Id = 1, DirectorId= Guid.Parse("55266710-251A-45A1-B11B-D2E2E7E104EA"), MovieId = 1},
                new MovieDirector() { Id = 2, DirectorId = Guid.Parse("88034877-A697-472C-A2D8-3D133792C463"), MovieId = 1 }, 
                new MovieDirector() { Id = 3, DirectorId = Guid.Parse("E717C0C2-82F5-46A8-8E50-95999E661A67"), MovieId = 2 }, 
                new MovieDirector() { Id = 4, DirectorId = Guid.Parse("7E02A8DB-94E7-4842-8B35-96C48D0E0C63"), MovieId = 3 }, 
                new MovieDirector() { Id = 5, DirectorId = Guid.Parse("EB504714-17F9-4AA3-8B5B-6360102F8453"), MovieId = 4 }, 
                new MovieDirector() { Id = 6, DirectorId = Guid.Parse("E717C0C2-82F5-46A8-8E50-95999E661A67"), MovieId = 5 }, 
                new MovieDirector() { Id = 7, DirectorId = Guid.Parse("7E02A8DB-94E7-4842-8B35-96C48D0E0C63"), MovieId = 6 }, 
                new MovieDirector() { Id = 8, DirectorId = Guid.Parse("88034877-A697-472C-A2D8-3D133792C463"), MovieId = 7 }, 
                new MovieDirector() { Id = 9, DirectorId = Guid.Parse("55266710-251A-45A1-B11B-D2E2E7E104EA"), MovieId = 8 }, 
                new MovieDirector() { Id = 10, DirectorId = Guid.Parse("88034877-A697-472C-A2D8-3D133792C463"), MovieId = 9 }
                );


            modelBuilder.Entity<Cast>().HasData(
                new Cast() { Id = 1, MovieId = 1, ActorId=Guid.Parse("354B3FAE-02FC-482F-BF68-1CC40B04C34F") },
                new Cast() { Id = 2, MovieId = 1, ActorId = Guid.Parse("1FA1A35A-D969-4B44-8CC0-1F6FBFF578FB") },
                new Cast() { Id = 3, MovieId = 1, ActorId = Guid.Parse("343D4B37-C4F7-4D24-ADB6-05ABEDA8AA41") },
                new Cast() { Id = 4, MovieId = 1, ActorId = Guid.Parse("BF79E94C-2B38-4763-AACD-8161006E8347") },
                new Cast() { Id = 5, MovieId = 1, ActorId = Guid.Parse("26340D49-35D2-4696-ADDF-E4FC97CD5300") },
                new Cast() { Id = 6, MovieId = 1, ActorId = Guid.Parse("376EF100-3A18-45DD-B83C-517D2CAFC0DC") },
                new Cast() { Id = 7, MovieId = 2, ActorId = Guid.Parse("bdef1607-3be2-4613-b6db-eef50a851237") },
                new Cast() { Id = 8, MovieId = 2, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 9, MovieId = 3, ActorId = Guid.Parse("376EF100-3A18-45DD-B83C-517D2CAFC0DC") },
                new Cast() { Id = 10, MovieId = 3, ActorId = Guid.Parse("bdef1607-3be2-4613-b6db-eef50a851237") },
                new Cast() { Id = 11, MovieId = 4, ActorId = Guid.Parse("376EF100-3A18-45DD-B83C-517D2CAFC0DC") },
                new Cast() { Id = 12, MovieId = 4, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 13, MovieId = 5, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 14, MovieId = 6, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 15, MovieId = 7, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 16, MovieId = 8, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 17, MovieId = 9, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 18, MovieId = 7, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") },
                new Cast() { Id = 19, MovieId = 8, ActorId = Guid.Parse("a9886af6-ede6-422b-a808-a6dcce2d18e6") }
                );


            modelBuilder.Entity<Cinema>().HasData(
                new Cinema() { Id=1, Name= "Galaxy Nguyễn Du", LocationId = 1 },
                new Cinema() { Id = 2, Name = "Galaxy Cà Mau", LocationId = 3 },
                new Cinema() { Id = 3, Name = "Galaxy Tân Bình", LocationId = 1 },
                new Cinema() { Id = 4, Name = "Galaxy Kinh Dương Vương", LocationId = 1 },
                new Cinema() { Id = 5, Name = "Galaxy Quang Trung", LocationId = 1 },
                new Cinema() { Id = 6, Name = "Galaxy Bến Tre", LocationId =  9},
                new Cinema() { Id = 7, Name = "Galaxy Đà Nẵng", LocationId = 6 },
                new Cinema() { Id = 8, Name = "Galaxy Hải Phòng", LocationId = 10 });


            modelBuilder.Entity<Auditorium>().HasData(
                new Auditorium() { Id = 1, CinemaId = 1, Name = "Phong-01"},
                new Auditorium() { Id = 2, CinemaId = 1, Name = "Phong-02" },
                new Auditorium() { Id = 3, CinemaId = 2, Name = "Phong-01" },
                new Auditorium() { Id = 4, CinemaId = 3, Name = "Phong-01" },
                new Auditorium() { Id = 5, CinemaId = 4, Name = "Phong-01" },
                new Auditorium() { Id = 6, CinemaId = 5, Name = "Phong-01" },
                new Auditorium() { Id = 7, CinemaId = 6, Name = "Phong-01" },
                new Auditorium() { Id = 8, CinemaId = 6, Name = "Phong-02" },
                new Auditorium() { Id = 9, CinemaId = 6, Name = "Phong-03" },
                new Auditorium() { Id = 10, CinemaId = 7, Name = "Phong-01" });

            modelBuilder.Entity<ScreeningType>().HasData(
                new ScreeningType() { Id = 1, Name = "2D - Phụ đề"},
                new ScreeningType() { Id = 2, Name = "3D - Phụ đề" });

           modelBuilder.Entity<Screening>().HasData(
                new Screening() { Id = 1, MovieId= 1, AuditoriumId = 1, MovieTypeId = 1, ShowTime = new DateTime(2022,10, 29, 09, 29, 59)},
                new Screening() { Id = 2, MovieId= 1, AuditoriumId = 2, MovieTypeId = 1, ShowTime = new DateTime(2022,10, 29, 17, 29, 59)},
                new Screening() { Id = 3, MovieId= 1, AuditoriumId = 5, MovieTypeId = 1, ShowTime = new DateTime(2022,10, 30, 09, 29, 59)},
                new Screening() { Id = 4, MovieId= 1, AuditoriumId = 6, MovieTypeId = 1, ShowTime = new DateTime(2022,10, 31, 10, 29, 59)},
                new Screening() { Id = 5, MovieId= 1, AuditoriumId = 7, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 1, 11, 29, 59)},
                new Screening() { Id = 6, MovieId= 2, AuditoriumId = 2, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 2, 13, 29, 59)},
                new Screening() { Id = 7, MovieId= 3, AuditoriumId = 3, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 3, 14, 29, 59)},
                new Screening() { Id = 8, MovieId= 4, AuditoriumId = 4, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 4, 15, 29, 59)},
                new Screening() { Id = 9, MovieId= 4, AuditoriumId = 5, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 5, 16, 29, 59)},
                new Screening() { Id = 10, MovieId= 5, AuditoriumId = 6, MovieTypeId = 1, ShowTime = new DateTime(2022,1, 6, 17, 29, 59)},
                new Screening() { Id = 11, MovieId= 5, AuditoriumId = 7, MovieTypeId = 1, ShowTime = new DateTime(2022,1, 7, 18, 29, 59)},
                new Screening() { Id = 12, MovieId= 6, AuditoriumId = 6, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 8, 19, 29, 59)},
                new Screening() { Id = 13, MovieId= 7, AuditoriumId = 5, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 9, 20, 29, 59)},
                new Screening() { Id = 14, MovieId= 8, AuditoriumId = 4, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 10, 21, 29, 59)},
                new Screening() { Id = 15, MovieId= 9, AuditoriumId = 3, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 11, 22, 29, 59)},
                new Screening() { Id = 16, MovieId= 2, AuditoriumId = 2, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 12, 08, 29, 59)},
                new Screening() { Id = 17, MovieId= 3, AuditoriumId = 1, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 13, 09, 29, 59)},
                new Screening() { Id = 18, MovieId= 4, AuditoriumId = 2, MovieTypeId = 1, ShowTime = new DateTime(2022,11, 14, 14, 29, 59)}
                );


            modelBuilder.Entity<Ticket>().HasData(
                new Ticket() { Id = 1, Name = "Người lớn", Description = "Vé 2D sử dụng từ 16 tuổi trở lên", Price = 90000},
                new Ticket() { Id = 2, Name = "Người trẻ em", Description = "Vé 2D sử dụng dưới 16", Price = 75000},
                new Ticket() { Id = 3, Name = "Sau 22h", Description = "Vé 2D chỉ sử dụng cho suất chiếu sau 22h", Price = 50000}
                );

            modelBuilder.Entity<Combo>().HasData(
               new Combo() { Id = 1, Name = "iCombo 1 Big Extra", Description = "1 BẮP + 1 NƯỚC 32 Oz (LIPTON/SUỐI/DIET PEPSI) + 1 SNACK", Price = 99000 },
               new Ticket() { Id = 2, Name = "iCombo Friends 1 Big", Description = "1 BẮP + 3 NƯỚC 32 Oz (LIPTON/SUỐI/DIET PEPSI) + 1 SNACK", Price = 139000 },
               new Ticket() { Id = 3, Name = "iCombo 2 BIG Extra", Description = "1 BẮP + 2 NƯỚC 32 Oz (LIPTON/SUỐI/DIET PEPSI) + 1 SNACK", Price = 120000 }
               );


            modelBuilder.Entity<SeatStyle>().HasData(
                new SeatStyle() { Id = 1, Name = "Ghế VIP" },
                new SeatStyle() { Id = 2, Name = "Ghế Couple" },
                new SeatStyle() { Id = 3, Name = "Ghế Cao cấp" },
                new SeatStyle() { Id = 4, Name = "Ghế Không thể chọn" },
                new SeatStyle() { Id = 5, Name = "Ghế Thường" });

            modelBuilder.Entity<Seat>().HasData(
                new Seat() { SeatId = "00", Row = "0", Number=0},
                new Seat() { SeatId = "A1", Row = "A", Number=1},
                new Seat() { SeatId = "A2", Row = "A", Number=2},
                new Seat() { SeatId = "A3", Row = "A", Number=3},
                new Seat() { SeatId = "A4", Row = "A", Number=4},
                new Seat() { SeatId = "A5", Row = "A", Number=5},
                new Seat() { SeatId = "A6", Row = "A", Number=6},
                new Seat() { SeatId = "A7", Row = "A", Number=7},
                new Seat() { SeatId = "A8", Row = "A", Number=8},
                new Seat() { SeatId = "A9", Row = "A", Number=9},
                new Seat() { SeatId = "A10", Row = "A", Number=10},
                new Seat() { SeatId = "A11", Row = "A", Number=11},
                new Seat() { SeatId = "A12", Row = "A", Number=12},
                new Seat() { SeatId = "B1", Row = "B", Number = 1 },
                new Seat() { SeatId = "B2", Row = "B", Number = 2 },
                new Seat() { SeatId = "B3", Row = "B", Number = 3 },
                new Seat() { SeatId = "B4", Row = "B", Number = 4 },
                new Seat() { SeatId = "B5", Row = "B", Number = 5 },
                new Seat() { SeatId = "B6", Row = "B", Number = 6 },
                new Seat() { SeatId = "B7", Row = "B", Number = 7 },
                new Seat() { SeatId = "B8", Row = "B", Number = 8 },
                new Seat() { SeatId = "B9", Row = "B", Number = 9 },
                new Seat() { SeatId = "B10", Row = "B", Number = 10 },
                new Seat() { SeatId = "B11", Row = "B", Number = 11 },
                new Seat() { SeatId = "B12", Row = "B", Number = 12 },
                new Seat() { SeatId = "C1", Row = "C", Number = 1 },
                new Seat() { SeatId = "C2", Row = "C", Number = 2 },
                new Seat() { SeatId = "C3", Row = "C", Number = 3 },
                new Seat() { SeatId = "C4", Row = "C", Number = 4 },
                new Seat() { SeatId = "C5", Row = "C", Number = 5 },
                new Seat() { SeatId = "C6", Row = "C", Number = 6 },
                new Seat() { SeatId = "C7", Row = "C", Number = 7 },
                new Seat() { SeatId = "C8", Row = "C", Number = 8 },
                new Seat() { SeatId = "C9", Row = "C", Number = 9 },
                new Seat() { SeatId = "C10", Row = "C", Number = 10 },
                new Seat() { SeatId = "C11", Row = "C", Number = 11 },
                new Seat() { SeatId = "C12", Row = "C", Number = 12 },
                new Seat() { SeatId = "D1", Row = "D", Number = 1 },
                new Seat() { SeatId = "D2", Row = "D", Number = 2 },
                new Seat() { SeatId = "D3", Row = "D", Number = 3 },
                new Seat() { SeatId = "D4", Row = "D", Number = 4 },
                new Seat() { SeatId = "D5", Row = "D", Number = 5 },
                new Seat() { SeatId = "D6", Row = "D", Number = 6 },
                new Seat() { SeatId = "D7", Row = "D", Number = 7 },
                new Seat() { SeatId = "D8", Row = "D", Number = 8 },
                new Seat() { SeatId = "D9", Row = "D", Number = 9 },
                new Seat() { SeatId = "D10", Row = "D", Number = 10 },
                new Seat() { SeatId = "D11", Row = "D", Number = 11 },
                new Seat() { SeatId = "D12", Row = "D", Number = 12 },
                new Seat() { SeatId = "E1", Row = "E", Number = 1 },
                new Seat() { SeatId = "E2", Row = "E", Number = 2 },
                new Seat() { SeatId = "E3", Row = "E", Number = 3 },
                new Seat() { SeatId = "E4", Row = "E", Number = 4 },
                new Seat() { SeatId = "E5", Row = "E", Number = 5 },
                new Seat() { SeatId = "E6", Row = "E", Number = 6 },
                new Seat() { SeatId = "E7", Row = "E", Number = 7 },
                new Seat() { SeatId = "E8", Row = "E", Number = 8 },
                new Seat() { SeatId = "E9", Row = "E", Number = 9 },
                new Seat() { SeatId = "E10", Row = "E", Number = 10 },
                new Seat() { SeatId = "E11", Row = "E", Number = 11 },
                new Seat() { SeatId = "E12", Row = "E", Number = 12 },
                new Seat() { SeatId = "F1", Row = "F", Number = 1 },
                new Seat() { SeatId = "F2", Row = "F", Number = 2 },
                new Seat() { SeatId = "F3", Row = "F", Number = 3 },
                new Seat() { SeatId = "F4", Row = "F", Number = 4 },
                new Seat() { SeatId = "F5", Row = "F", Number = 5 },
                new Seat() { SeatId = "F6", Row = "F", Number = 6 },
                new Seat() { SeatId = "F7", Row = "F", Number = 7 },
                new Seat() { SeatId = "F8", Row = "F", Number = 8 },
                new Seat() { SeatId = "F9", Row = "F", Number = 9 },
                new Seat() { SeatId = "F10", Row = "F", Number = 10 },
                new Seat() { SeatId = "F11", Row = "F", Number = 11 },
                new Seat() { SeatId = "F12", Row = "F", Number = 12 },
                new Seat() { SeatId = "G1", Row = "G", Number = 1 },
                new Seat() { SeatId = "G2", Row = "G", Number = 2 },
                new Seat() { SeatId = "G3", Row = "G", Number = 3 },
                new Seat() { SeatId = "G4", Row = "G", Number = 4 },
                new Seat() { SeatId = "G5", Row = "G", Number = 5 },
                new Seat() { SeatId = "G6", Row = "G", Number = 6 },
                new Seat() { SeatId = "G7", Row = "G", Number = 7 },
                new Seat() { SeatId = "G8", Row = "G", Number = 8 },
                new Seat() { SeatId = "G9", Row = "G", Number = 9 },
                new Seat() { SeatId = "G10", Row = "G", Number = 10 },
                new Seat() { SeatId = "G11", Row = "G", Number = 11 },
                new Seat() { SeatId = "G12", Row = "G", Number = 12 },
                new Seat() { SeatId = "H1", Row = "H", Number = 1 },
                new Seat() { SeatId = "H2", Row = "H", Number = 2 },
                new Seat() { SeatId = "H3", Row = "H", Number = 3 },
                new Seat() { SeatId = "H4", Row = "H", Number = 4 },
                new Seat() { SeatId = "H5", Row = "H", Number = 5 },
                new Seat() { SeatId = "H6", Row = "H", Number = 6 },
                new Seat() { SeatId = "H7", Row = "H", Number = 7 },
                new Seat() { SeatId = "H8", Row = "H", Number = 8 },
                new Seat() { SeatId = "H9", Row = "H", Number = 9 },
                new Seat() { SeatId = "H10", Row = "H", Number = 10 },
                new Seat() { SeatId = "H11", Row = "H", Number = 11 },
                new Seat() { SeatId = "H12", Row = "H", Number = 12 },
                new Seat() { SeatId = "I1", Row = "I", Number = 1 },
                new Seat() { SeatId = "I2", Row = "I", Number = 2 },
                new Seat() { SeatId = "I3", Row = "I", Number = 3 },
                new Seat() { SeatId = "I4", Row = "I", Number = 4 },
                new Seat() { SeatId = "I5", Row = "I", Number = 5 },
                new Seat() { SeatId = "I6", Row = "I", Number = 6 },
                new Seat() { SeatId = "I7", Row = "I", Number = 7 },
                new Seat() { SeatId = "I8", Row = "I", Number = 8 },
                new Seat() { SeatId = "I9", Row = "I", Number = 9 },
                new Seat() { SeatId = "I10", Row = "I", Number = 10 },
                new Seat() { SeatId = "I11", Row = "I", Number = 11 },
                new Seat() { SeatId = "I12", Row = "I", Number = 12 },
                new Seat() { SeatId = "J1", Row = "J", Number = 1 },
                new Seat() { SeatId = "J2", Row = "J", Number = 2 },
                new Seat() { SeatId = "J3", Row = "J", Number = 3 },
                new Seat() { SeatId = "J4", Row = "J", Number = 4 },
                new Seat() { SeatId = "J5", Row = "J", Number = 5 },
                new Seat() { SeatId = "J6", Row = "J", Number = 6 },
                new Seat() { SeatId = "J7", Row = "J", Number = 7 },
                new Seat() { SeatId = "J8", Row = "J", Number = 8 },
                new Seat() { SeatId = "J9", Row = "J", Number = 9 },
                new Seat() { SeatId = "J10", Row = "J", Number = 10 },
                new Seat() { SeatId = "J11", Row = "J", Number = 11 },
                new Seat() { SeatId = "J12", Row = "J", Number = 12 },
                new Seat() { SeatId = "J13", Row = "J", Number = 13 },
                new Seat() { SeatId = "J14", Row = "J", Number = 14 },
                new Seat() { SeatId = "K1", Row = "K", Number = 1 },
                new Seat() { SeatId = "K2", Row = "K", Number = 2 },
                new Seat() { SeatId = "K3", Row = "K", Number = 3 },
                new Seat() { SeatId = "K4", Row = "K", Number = 4 },
                new Seat() { SeatId = "K5", Row = "K", Number = 5 },
                new Seat() { SeatId = "K6", Row = "K", Number = 6 },
                new Seat() { SeatId = "K7", Row = "K", Number = 7 },
                new Seat() { SeatId = "K8", Row = "K", Number = 8 },
                new Seat() { SeatId = "K9", Row = "K", Number = 9 },
                new Seat() { SeatId = "K10", Row = "K", Number = 10 },
                new Seat() { SeatId = "K11", Row = "K", Number = 11 },
                new Seat() { SeatId = "K12", Row = "K", Number = 12 },
                new Seat() { SeatId = "K13", Row = "K", Number = 13 },
                new Seat() { SeatId = "K14", Row = "K", Number = 14 },
                new Seat() { SeatId = "L1", Row = "L", Number = 1 },
                new Seat() { SeatId = "L2", Row = "L", Number = 2 },
                new Seat() { SeatId = "L3", Row = "L", Number = 3 },
                new Seat() { SeatId = "L4", Row = "L", Number = 4 },
                new Seat() { SeatId = "L5", Row = "L", Number = 5 },
                new Seat() { SeatId = "L6", Row = "L", Number = 6 },
                new Seat() { SeatId = "L7", Row = "L", Number = 7 },
                new Seat() { SeatId = "L8", Row = "L", Number = 8 },
                new Seat() { SeatId = "L9", Row = "L", Number = 9 },
                new Seat() { SeatId = "L10", Row = "L", Number = 10 },
                new Seat() { SeatId = "L11", Row = "L", Number = 11 },
                new Seat() { SeatId = "L12", Row = "L", Number = 12 },
                new Seat() { SeatId = "L13", Row = "L", Number = 13 },
                new Seat() { SeatId = "L14", Row = "L", Number = 14 },
                new Seat() { SeatId = "L15", Row = "L", Number = 15 },
                new Seat() { SeatId = "L16", Row = "L", Number = 16 }
                );
            int i = 0;
            modelBuilder.Entity<SeatNo>().HasData(
                new SeatNo() { Id = ++i, SeatId = "A1", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A2", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A3", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A4", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A5", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A6", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A7", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A8", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A9", AuditoriumId = 1, Stauts = false , RowIndex = 1, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A10", AuditoriumId = 1, Stauts = false, RowIndex = 1, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A11", AuditoriumId = 1, Stauts = false, RowIndex = 1, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "A12", AuditoriumId = 1, Stauts = false, RowIndex = 1, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B1", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B2", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B3", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B4", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B5", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B6", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B7", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B8", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B9", AuditoriumId = 1, Stauts = false , RowIndex = 2, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B10", AuditoriumId = 1, Stauts = false, RowIndex = 2, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B11", AuditoriumId = 1, Stauts = false, RowIndex = 2, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "B12", AuditoriumId = 1, Stauts = false, RowIndex = 2, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C1", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C2", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C3", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C4", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C5", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C6", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C7", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C8", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C9", AuditoriumId = 1, Stauts = false , RowIndex = 3, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C10", AuditoriumId = 1, Stauts = false, RowIndex = 3, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C11", AuditoriumId = 1, Stauts = false, RowIndex = 3, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "C12", AuditoriumId = 1, Stauts = false, RowIndex = 3, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D1", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D2", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D3", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D4", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D5", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D6", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D7", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D8", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D9", AuditoriumId = 1, Stauts = false , RowIndex = 4, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D10", AuditoriumId = 1, Stauts = false, RowIndex = 4, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D11", AuditoriumId = 1, Stauts = false, RowIndex = 4, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "D12", AuditoriumId = 1, Stauts = false, RowIndex = 4, ColumnIndex=14, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E1", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=1, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E2", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=2, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E3", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=5, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E4", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=6, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E5", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=7, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E6", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=8, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E7", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=9, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E8", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=10, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E9", AuditoriumId = 1, Stauts = false , RowIndex = 5, ColumnIndex=11, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E10", AuditoriumId = 1, Stauts = false, RowIndex = 5, ColumnIndex=12, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E11", AuditoriumId = 1, Stauts = false, RowIndex = 5, ColumnIndex=13, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "E12", AuditoriumId = 1, Stauts = false, RowIndex = 5, ColumnIndex=14, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F1", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=1, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F2", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=2, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F3", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=5, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F4", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=6, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F5", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=7, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F6", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=8, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F7", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=9, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F8", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=10, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F9", AuditoriumId = 1, Stauts = false , RowIndex = 6, ColumnIndex=11, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F10", AuditoriumId = 1, Stauts = false, RowIndex = 6, ColumnIndex=12, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F11", AuditoriumId = 1, Stauts = false, RowIndex = 6, ColumnIndex=13, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "F12", AuditoriumId = 1, Stauts = false, RowIndex = 6, ColumnIndex=14, SeatStyleId=1},
                new SeatNo() { Id = ++i, SeatId = "G1", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=1, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "G2", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=2, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "G3", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=5, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "G4", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=6, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "G5", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=7, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "G6", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=8, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "G7", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "G8", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "G9", AuditoriumId = 1, Stauts = false , RowIndex = 7, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "G10", AuditoriumId = 1, Stauts = false, RowIndex = 7, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "G11", AuditoriumId = 1, Stauts = false, RowIndex = 7, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "G12", AuditoriumId = 1, Stauts = false, RowIndex = 7, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "H1", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "H2", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=2, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H3", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=5, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H4", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=6, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H5", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=7, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H6", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=8, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H7", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=9, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H8", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=10, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H9", AuditoriumId = 1, Stauts = false , RowIndex = 8, ColumnIndex=11, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H10", AuditoriumId = 1, Stauts = false, RowIndex = 8, ColumnIndex=12, SeatStyleId=5},
                new SeatNo() { Id = ++i, SeatId = "H11", AuditoriumId = 1, Stauts = false, RowIndex = 8, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "H12", AuditoriumId = 1, Stauts = false, RowIndex = 8, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I1", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I2", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I3", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I4", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I5", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I6", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I7", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I8", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I9", AuditoriumId = 1, Stauts = false , RowIndex = 9, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I10", AuditoriumId = 1, Stauts = false, RowIndex = 9, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I11", AuditoriumId = 1, Stauts = false, RowIndex = 9, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "I12", AuditoriumId = 1, Stauts = false, RowIndex = 9, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "00", AuditoriumId = 1, Stauts = null, RowIndex = null, ColumnIndex=null, SeatStyleId=null},
                new SeatNo() { Id = ++i, SeatId = "J1", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J2", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J3", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=3, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J4", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=4, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J5", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J6", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J7", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J8", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J9", AuditoriumId = 1, Stauts = false , RowIndex = 11, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J10", AuditoriumId = 1, Stauts = false, RowIndex = 11, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J11", AuditoriumId = 1, Stauts = false, RowIndex = 11, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J12", AuditoriumId = 1, Stauts = false, RowIndex = 11, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J13", AuditoriumId = 1, Stauts = false, RowIndex = 11, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "J14", AuditoriumId = 1, Stauts = false, RowIndex = 11, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K1", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K2", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K3", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=3, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K4", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=4, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K5", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K6", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K7", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K8", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K9", AuditoriumId = 1, Stauts = false , RowIndex = 12, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K10", AuditoriumId = 1, Stauts = false, RowIndex = 12, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K11", AuditoriumId = 1, Stauts = false, RowIndex = 12, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K12", AuditoriumId = 1, Stauts = false, RowIndex = 12, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K13", AuditoriumId = 1, Stauts = false, RowIndex = 12, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "K14", AuditoriumId = 1, Stauts = false, RowIndex = 12, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L1", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=1, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L2", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=2, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L3", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=3, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L4", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=4, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L5", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=5, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L6", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=6, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L7", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=7, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L8", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=8, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L9", AuditoriumId = 1, Stauts = false , RowIndex = 13, ColumnIndex=9, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L10", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=10, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L11", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=11, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L12", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=12, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L13", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=13, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L14", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=14, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L15", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=15, SeatStyleId=4},
                new SeatNo() { Id = ++i, SeatId = "L16", AuditoriumId = 1, Stauts = false, RowIndex = 13, ColumnIndex=16, SeatStyleId=4});

            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod() { Id = 1, Name = "Ví điện tử momo", Alias = "Vi_dien_tu_momo", Cost = 0, CostAdditional = 0, Status = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now},       
                new PaymentMethod() { Id = 2, Name = "Ví Zalo", Alias = "Vi_Zalo", Cost = 0, CostAdditional = 0, Status = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now},       
                new PaymentMethod() { Id = 3, Name = "VNPAY", Alias = "VNPAY", Cost = 0, CostAdditional = 0, Status = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now},       
                new PaymentMethod() { Id = 4, Name = "HSBC/Payoo - ATM/VISA/MASTER/JCB/QRCODE", Alias = "HSBC/Payoo-ATM/VISA/MASTER/JCB/QRCODE", Cost = 0, CostAdditional = 0, Status = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now},       
                new PaymentMethod() { Id = 5, Name = "Ví ShopeePay", Alias = "Vi_ShoppePay", Cost = 0, CostAdditional = 0, Status = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now}       
                );

            modelBuilder.Entity<Coupon>().HasData(
                new Coupon() { Id = 1, Name="GEKIJFNFCCMAJ", Alias= "GEKIJFNF785MAJ", AvailableQuantity = 10, Discount=5000, ValidFrom = new DateTime(2022, 10, 29), ValidTo = new DateTime(2022, 11, 15), Status = true},
                new Coupon() { Id = 2, Name="GEKIJFNFCCMAJ", Alias= "KJMNNVDD452YTR", AvailableQuantity = 5, Discount=2000, ValidFrom = new DateTime(2022, 10, 29), ValidTo = new DateTime(2022, 11, 15), Status = true}
                );

            modelBuilder.Entity<Booking>().HasData(
                    new Booking() { Id = 1, AppUserId = Guid.Parse("C8A04D06-2334-4806-92A6-6F6DB3ED6692"), ScreeningId = 1, PaymentMethodId = 1, CouponId = 2, Total = 420000, Stauts = true}
                );

            modelBuilder.Entity<BookingCombo>().HasData(
                new BookingCombo() { Id = 1, BookingId = 1, ComboId = 1, Quantity = 2, Stauts = true},
                new BookingCombo() { Id = 2, BookingId = 1, ComboId = 2, Quantity = 1, Stauts = true},
                new BookingCombo() { Id = 3, BookingId = 1, ComboId = 3, Quantity = 1, Stauts = true}
                );
            modelBuilder.Entity<BookingTicket>().HasData(
                new BookingTicket() { Id = 1, BookingId = 1, TicketId = 1, Quantity = 2, Stauts = true},
                new BookingTicket() { Id = 2, BookingId = 1, TicketId = 2, Quantity = 1, Stauts = true}
                );

            modelBuilder.Entity<SeatReserved>().HasData(
                new SeatReserved() { Id = 1, BookingId = 1, SeatNoId = 2, Stauts = true},
                new SeatReserved() { Id = 2, BookingId = 1, SeatNoId = 3, Stauts = true},
                new SeatReserved() { Id = 3, BookingId = 1, SeatNoId = 4, Stauts = true}
                );
        }
    }
}
