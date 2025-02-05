using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Domain;
using MusicStore.Domain.Identity;
using NuGet.DependencyResolver;

namespace MusicStoreApplication.Repository
{
    public class ApplicationDbContext : IdentityDbContext<MusicStoreApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
 
        public DbSet<Album> Albums { get; set; }
       
        public DbSet<ShoppingCartItem> CartItems { get; set; }
       
        public DbSet<BoughtItem> BoughtItems { get; set; }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserPlaylist> UserPlaylists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var artistIds = Enumerable.Range(1, 5).Select(_ => Guid.NewGuid()).ToArray();
            var albumIds = Enumerable.Range(1, 10).Select(_ => Guid.NewGuid()).ToArray();


            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.HasMany(a => a.Albums)
                      .WithOne(al => al.Artist)
                      .HasForeignKey(al => al.ArtistId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Artist deletes Albums

                // Seed data for Artist
                entity.HasData(
                    new Artist { Id = artistIds[0], Name = "Pink Floyd", Bio = "A legendary rock band." },
                    new Artist { Id = artistIds[1], Name = "The Beatles", Bio = "One of the most influential rock bands." },
                    new Artist { Id = artistIds[2], Name = "Led Zeppelin", Bio = "A rock band known for its heavy sound." },
                    new Artist { Id = artistIds[3], Name = "Queen", Bio = "A rock band known for its eclectic musical style." },
                    new Artist { Id = artistIds[4], Name = "Nirvana", Bio = "A grunge band that shaped the 90s music scene." }
                );
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(al => al.Id);

                entity.HasOne(al => al.Artist)
                      .WithMany(a => a.Albums)
                      .HasForeignKey(al => al.ArtistId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Artist deletes Albums

                entity.HasMany(al => al.Tracks)
                      .WithOne(tr => tr.Album)
                      .HasForeignKey(tr => tr.AlbumId)
                      .OnDelete(DeleteBehavior.Cascade); // Cascade: Deleting Album deletes Tracks

                // Seed data for Album (linked to the Artist)
                entity.HasData(
                    new Album { Id = albumIds[0], Title = "The Dark Side of the Moon", ReleaseDate = new DateTime(1973, 3, 1), ArtistId = artistIds[0], Price = 20, AlbumImageUrl = "https://i.discogs.com/1fwskTLM6cfxbdNmBDJ8expl6wab0tEgxvuloLIqKh8/rs:fit/g:sm/q:90/h:596/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTkyODc4/MDktMTQ3OTc1MzIz/Ni05NjE3LmpwZWc.jpeg" },
                    new Album { Id = albumIds[1], Title = "Wish You Were Here", ReleaseDate = new DateTime(1975, 9, 12), ArtistId = artistIds[0], Price = 22, AlbumImageUrl = "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg" },    
                    new Album { Id = albumIds[2], Title = "Abbey Road", ReleaseDate = new DateTime(1969, 9, 26), ArtistId = artistIds[1], Price = 25, AlbumImageUrl = "https://i.discogs.com/goWfjpqUBW8Y0xrqJG_GFz3fCTHPSWeKLZAX1alAAzk/rs:fit/g:sm/q:90/h:600/w:592/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MTg2/NDQxLTE1Njk0ODcx/NjEtNzMxNC5qcGVn.jpeg" },   
                    new Album { Id = albumIds[3], Title = "Let It Be", ReleaseDate = new DateTime(1970, 5, 8), ArtistId = artistIds[1], Price = 23, AlbumImageUrl = "https://i.discogs.com/HWA3uoT2xu7zj_kM-f18f02CCQNKk2W8YzUL-D_l2ZM/rs:fit/g:sm/q:90/h:581/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwODgx/MjYtMTI1Njk1MDk3/OS5qcGVn.jpeg" }, 
                    new Album { Id = albumIds[4], Title = "Led Zeppelin IV", ReleaseDate = new DateTime(1971, 11, 8), ArtistId = artistIds[2], Price = 24, AlbumImageUrl = "https://i.discogs.com/yFq3X0xZMxIVHIFgmbrsPvJHXLJCfVLWs60AL4XS4bs/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg2/Ny0yNzg1LmpwZWc.jpeg" },
                    new Album { Id = albumIds[5], Title = "Houses of the Holy", ReleaseDate = new DateTime(1973, 3, 28), ArtistId = artistIds[2], Price = 26, AlbumImageUrl = "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg" },
                    new Album { Id = albumIds[6], Title = "A Night at the Opera", ReleaseDate = new DateTime(1975, 11, 21), ArtistId = artistIds[3], Price = 21, AlbumImageUrl = "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
                    new Album { Id = albumIds[7], Title = "The Works", ReleaseDate = new DateTime(1984, 2, 27), ArtistId = artistIds[3], Price = 19, AlbumImageUrl = "https://i.discogs.com/p2o5GGONaTq4jK398iU0X3KjuMfnK10_TEC_bdnKA6k/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTMzMjg5/ODItMTM1NzgxOTE3/NS05NTU3LmpwZWc.jpeg" },
                    new Album { Id = albumIds[8], Title = "Nevermind", ReleaseDate = new DateTime(1991, 9, 24), ArtistId = artistIds[4], Price = 18, AlbumImageUrl = "https://i.discogs.com/XoAXkLe03Vk0Kt-oQqw7V9uW5nBzQdNvZd0zar5mOiQ/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2NzA4/NC0xMjYzMDk1NTUz/LmpwZWc.jpeg" },
                    new Album { Id = albumIds[9], Title = "In Utero", ReleaseDate = new DateTime(1993, 9, 21), ArtistId = artistIds[4], Price = 20, AlbumImageUrl = "https://i.discogs.com/ijIUNhH--0OKzKuKv-aLpgFkb7lr6OQVb5FcAF_aW0U/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NTk3/OS0xNDkxNzAwMzQ3/LTcyNjMuanBlZw.jpeg" }
                    );

            }); 

            // Order Configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasOne(o => o.Owner)
                    .WithMany()
                    .HasForeignKey(o => o.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(o => o.BoughtItems)
                    .WithOne(t => t.Order)
                    .HasForeignKey(t => t.OrderId)
                    .OnDelete(DeleteBehavior.SetNull);
          
            });

            // ShoppingCart Configuration
            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(sc => sc.Id);

                entity.HasOne(sc => sc.Owner)
                    .WithMany()
                    .HasForeignKey(sc => sc.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(sc => sc.Items)
                    .WithOne(tisc => tisc.shoppingCart)
                    .HasForeignKey(tisc => tisc.ShoppingCartId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Title)
                     .IsRequired()
                     .HasMaxLength(255);
                
                
                entity.HasOne(t => t.Album)
                .WithMany(a => a.Tracks)
                .HasForeignKey(t => t.AlbumId)
                .OnDelete(DeleteBehavior.Cascade); // Tracks are deleted when their Album is deleted

                entity.HasOne(t => t.Artist) // New relationship configuration
                     .WithMany(a => a.Tracks)
                     .HasForeignKey(t => t.ArtistId)
                     .OnDelete(DeleteBehavior.Restrict); // Tracks are deleted when their Artist is deleted

            entity.HasData(
                new Track { Id = Guid.NewGuid(), Title = "Speak to Me", Duration = TimeSpan.FromMinutes(1), AlbumId = albumIds[0], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/E9E7stvIt5YKUfK_CnrpIgxchviC7Q4WCeyQuuICAjo/rs:fit/g:sm/q:90/h:397/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDYw/MC5qcGVn.jpeg" },
                new Track { Id = Guid.NewGuid(), Title = "Breathe in the air", Duration = TimeSpan.FromMinutes(2), AlbumId = albumIds[0], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/mfba8kz9-PIwZGE5g70Z5i6JpITmeRfaXLsWClcxj8g/rs:fit/g:sm/q:90/h:500/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI4NzAw/MjYwLTE2OTgyMzg5/MDItNDY5NS5qcGVn.jpeg" },
                new Track { Id = Guid.NewGuid(), Title = "On the Run", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[0], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/t4BbENT4ugUFTY-pgCqTcEHhlfwlrJeJuyTOTzqxKfM/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTcyNzc2NDky/OS03ODUzLmpwZWc.jpeg" },
                new Track { Id = Guid.NewGuid(), Title = "Time", Duration = TimeSpan.FromMinutes(6), AlbumId = albumIds[0], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/rCpj_7gUWtxKDPQQpoVwbrud6zN2wwyQRVFR-ZaNtFI/rs:fit/g:sm/q:90/h:380/w:577/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTI0OTMwMDU4/MS5qcGVn.jpeg" },


        // Wish You Were Here
        new Track { Id = Guid.NewGuid(), Title = "Shine On You Crazy Diamond (Part I-V)", Duration = TimeSpan.FromMinutes(13), AlbumId = albumIds[1], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/pZnTKUeiKsxSyvX_87YMgccx0bq5sjqThFH9iSNAtAY/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTctOTI4MC5qcGVn.jpeg" },
        new Track { Id = Guid.NewGuid(), Title = "Welcome to the Machine", Duration = TimeSpan.FromMinutes(7), AlbumId = albumIds[1], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/a36kcqXYhsvwN7S1cyq8_CGqqyWi78u3CLtxuE86-Go/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYw/OTYtMTc3Mi5qcGVn.jpeg" },
        new Track { Id = Guid.NewGuid(), Title = "Have a Cigar", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[1], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/frk8i23GN3Epw5RaA-um7KwmBw0NTQiEHUYtirXaqdg/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MDgtMTIxMi5qcGVn.jpeg" },
        new Track { Id = Guid.NewGuid(), Title = "Wish You Were Here", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[1], ArtistId = artistIds[0], Price = 129, TrackImageUrl = "https://i.discogs.com/hJBh2v_V6Ow6_hyPu791g1d_Pqj6_aoKB6fm_JUKUPA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE2MjEx/ODEyLTE2MzczMzYx/MjgtNDE1My5qcGVn.jpeg" },


        // Abbey Road
        new Track { Id = Guid.NewGuid(), Title = "Come Together", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[2], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Something", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[2], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Octopus's Garden", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[2], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/M2yc5OJZPdVoDm2_UlRRXuDlDguamLLSdnbziNmZoQI/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI2MDc0/MjQtMTYzMDYwMTA4/Ny0xMTk5LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Here Comes the Sun", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[2], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/qsJyhu9LR8BERwbo5DRIYdNJzZFyuxQMr3RJcnOSEkw/rs:fit/g:sm/q:90/h:597/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgxMzcz/NTUtMTQ1NTgzODU3/My0zNDk0LmpwZWc.jpeg" },

        // Let It Be
        new Track { Id = Guid.NewGuid(), Title = "Let It Be", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[3], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/hAdrrjfnT2klIYc1V_oKX5HjpJ3xElwd7FDaDydTFGo/rs:fit/g:sm/q:90/h:600/w:566/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ0NTE5Njg4/LTU0MzkuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Across the Universe", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[3], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/KFfU_VOBY43WsttSMHMp0uUvaQ8Sk63qAoCDeTeENpE/rs:fit/g:sm/q:90/h:598/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzQ1NjcxNjIy/LTM1ODYuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "The Long and Winding Road", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[3], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/3C94Ivdig0n1Jyb8d_0jKoIvj54r56hYW6kb6kiM8cY/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzMw/LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Get Back", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[3], ArtistId = artistIds[1], Price = 129, TrackImageUrl = "https://i.discogs.com/yZ8hA52tgMGcdxfY182_OqxJIjUuzu1NvwVKxNM_Ztg/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3NzU1/NC0xMzI2NzA0NzIw/LmpwZWc.jpeg" },

        // Led Zeppelin IV
        new Track { Id = Guid.NewGuid(), Title = "Black Dog", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[4], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/Ok43Qrm9pIMNTCCCR5oXwL9XU_0_WxXdRl6RKeXfxBg/rs:fit/g:sm/q:90/h:600/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/My00NDI0LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Rock and Roll", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[4], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/aFc_fainrAcSiX2MbERPPWWlvjeYKc0D4yf53WD4rzM/rs:fit/g:sm/q:90/h:592/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTU5Mjc0NzQ3/NC00ODYwLmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Stairway to Heaven", Duration = TimeSpan.FromMinutes(8), AlbumId = albumIds[4], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/AO-PmjrMZa3JNJ8NBErUUcDOJ2Yna2jCNLbwmZ0n9aE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc1Nzg1/NC0xNTE1ODU0Mjcx/LTM3NDUuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Going to California", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[4], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/kOYbkKoJqpZfHNMg38TaBrOQmJWYO8UoRWV_BOgR6MA/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEwMTU0/NjUtMTM2NjMxMTg4/My02MDE1LmpwZWc.jpeg" },

       // Houses of the Holy
       new Track { Id = Guid.NewGuid(), Title = "The Song Remains the Same", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[5], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/PGoolvGRHExppmuvEDxPETmRJAFIlpoSAZ41ws86GLw/rs:fit/g:sm/q:90/h:577/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMzA2/LTU4MzMuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "The Rain Song", Duration = TimeSpan.FromMinutes(7), AlbumId = albumIds[5], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/8wnDvfzEjV9Wc1BBxbaIIUeBhIxQ7WeFsKjdwt9hoWc/rs:fit/g:sm/q:90/h:574/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMzkxNTIyMjY2/LTY4MzkuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Over the Hills and Far Away", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[5], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/QVRkVVBO1gFfafoFfNzNps67VKs1DsGRcHQ474zEDf0/rs:fit/g:sm/q:90/h:224/w:452/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xMTcxOTI0MzQz/LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "No Quarter", Duration = TimeSpan.FromMinutes(7), AlbumId = albumIds[5], ArtistId = artistIds[2], Price = 129, TrackImageUrl = "https://i.discogs.com/BLWVi0t0llSqJvIybHrSvPql-RfORCmZU1klNfV0si8/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1NTA3/Ny0xNTg4ODgwNzg4/LTIyMjYuanBlZw.jpeg" },

        // A Night at the Opera
        new Track { Id = Guid.NewGuid(), Title = "Death on Two Legs", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[6], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/exLiE9TUHd1Osv4-SBjJsO8zScHQQ2s5XTA7QzvHmjk/rs:fit/g:sm/q:90/h:591/w:595/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQy/LTU2OTMuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "You're My Best Friend", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[6], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Love of My Life", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[6], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/2GXnNYolz0ciUnj8-ycSwQ8Uuy0Qu7LCfiZivZ0p_bo/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYxMjc4/MC0xNTQxMzY3MTQ1/LTIxMjcuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Bohemian Rhapsody", Duration = TimeSpan.FromMinutes(6), AlbumId = albumIds[6], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/_RN78C49qgCxMX3CnRdxDggOCSI5P7uYaUGJ_Pl_CGM/rs:fit/g:sm/q:90/h:567/w:574/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM2OTg5/MC0xMzkzMjg2NDQz/LTU3NTUuanBlZw.jpeg" },

        // The Works
        new Track { Id = Guid.NewGuid(), Title = "Radio Ga Ga", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[7], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/b20JvPlll2B74GR7tMh3oSukHbeTjq3cyTBpdKk25fA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1MTU5/MTEtMTU5OTIzODcx/MS05NjI1LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Tear It Up", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[7], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/TNq6BKsREuTvVL0QtgziQ0ACcLNhKq9AjP-NYI7yo14/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ3NTU5/Ni0xNDU0NzA3NDYw/LTIxNzkuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "It's a Hard Life", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[7], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/gdK1Z8e8y1qZybHe6WF_NXUstJzEhHSId63nx0GS_Yo/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1OTU3/NTktMTIzMTA1Njkw/MS5qcGVn.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "I Want to Break Free", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[7], ArtistId = artistIds[3], Price = 129, TrackImageUrl = "https://i.discogs.com/GZW57VCYRIgmdlkLRQwj_ZejpTs1lW3TiH-m5zJzvKg/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE1NDU5/MDAtMTIyNzQzNTEx/NS5qcGVn.jpeg" },


      // Nevermind
      new Track { Id = Guid.NewGuid(), Title = "Smells Like Teen Spirit", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[8], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/MsIpIcpdbgg0r3CYB39OlwwuT81PuQ0psUcDvRLTdUU/rs:fit/g:sm/q:90/h:528/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MzI3/OC0xMzQwMTcwNjI1/LTMwNzguanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "In Bloom", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[8], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/6fsdEUC3-9WQy2tB4PmRvGcYrKPtggYbUSgD5QyZQQ4/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEzNDgz/ODctMTY4MDY3ODQ1/My05NTcwLmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Come as You Are", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[8], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/gIQVfX1uZI857sBz7NntFRdTCLO3eQT0o4qCiCIHnfE/rs:fit/g:sm/q:90/h:486/w:543/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTc4MzIx/Ni0xNDE2ODkwNjQx/LTc3OTQuanBlZw.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Lithium", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[8], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/hjHzpqaFqgJXi12l082Z4iIDAqkooFWzQOss9XzW6LU/rs:fit/g:sm/q:90/h:600/w:590/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyOTg2/OTQtMTU4NDk2NTg5/OS03MTUyLmpwZWc.jpeg" },

        // In Utero
        new Track { Id = Guid.NewGuid(), Title = "Serve the Servants", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[9], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/mFtdd9bDwACrDsS9nQyxKcWlBY_WKlcIib_5iq0NspE/rs:fit/g:sm/q:90/h:522/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTEyMjc5/MzMwLTE1MzIwMzE2/OTMtOTE3OC5qcGVn.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Heart-Shaped Box", Duration = TimeSpan.FromMinutes(5), AlbumId = albumIds[9], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/jvt57zTP4f1brU4p_ABs9ylQ8K6B6a0El-CFqmHRyPU/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM5MzA2/NS0xMTgyNjg0ODgz/LmpwZWc.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Frances Farmer Will Have Her Revenge On Seattle", Duration = TimeSpan.FromMinutes(3), AlbumId = albumIds[9], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/FeGBBtykttDrTxPvdjPufzgY4HuxmQ_Yw-4F0ooQdCw/rs:fit/g:sm/q:90/h:600/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE0MDE4/ODMyLTE1NjY3NjM4/MTctMzc3OS5qcGVn.jpeg" },
new Track { Id = Guid.NewGuid(), Title = "Pennyroyal Tea", Duration = TimeSpan.FromMinutes(4), AlbumId = albumIds[9], ArtistId = artistIds[4], Price = 129, TrackImageUrl = "https://i.discogs.com/7W0cV6lsC_kWMo0sbFf1pd73ROkSNo6cpWEUHGrgdas/rs:fit/g:sm/q:90/h:462/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTgyOTcz/My0xMTY1MTQ0MjEy/LmpwZWc.jpeg" }
    );
            });

            // UserPlaylist Configuration
            modelBuilder.Entity<UserPlaylist>(entity =>
            {
                entity.HasKey(up => up.Id);

                entity.Property(up => up.Name)
                    .HasMaxLength(255);

                entity.HasOne(up => up.User)
                    .WithMany()
                    .HasForeignKey(up => up.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(up => up.Tracks)
                    .WithMany(t => t.Playlists);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
