using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using MusicStoreAdminApp.Models;
using Newtonsoft.Json;
using System.Text;

namespace MusicStoreAdminApp.Controllers
{
    public class PlaylistController : Controller
    {

        public PlaylistController() {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();

            string url = "https://localhost:44383/Api/Admin/GetPlaylist";

            HttpResponseMessage response = client.GetAsync(url).Result;
            var data = response.Content.ReadAsAsync<List<UserPlaylist>>().Result;

            return View(data);
        }

        public IActionResult Details(Guid id)
        {
            HttpClient client = new HttpClient();
            
            string URL = "https://localhost:44383/Api/Admin/PlaylistDetails";
            var model = new
            {
                Id = id
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(URL, content).Result;

            var result = response.Content.ReadAsAsync<UserPlaylist>().Result;


            return View(result);
        }

        public FileContentResult CreateInvoice(Guid id)
        {
            try
            {
                HttpClient client = new HttpClient();
                string URL = "https://localhost:44383/Api/Admin/PlaylistDetails"; // Use your playlist details endpoint

                var model = new { id = id };
                HttpContent content = new StringContent(
                    JsonConvert.SerializeObject(model),
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = client.PostAsync(URL, content).Result;
                var playlist = response.Content.ReadAsAsync<UserPlaylist>().Result;

                // Load the template
                var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "MUSIC STORE PLAYLIST INVOICE.docx");
                var document = DocumentModel.Load(templatePath);

                // Replace basic information
                document.Content.Replace("{{PlaylistId}}", playlist.Id.ToString());
                document.Content.Replace("{{PlaylistName}}", playlist.Name);
                document.Content.Replace("{{UserId}}", playlist.UserId);

                // Build tracks list
                StringBuilder sb = new StringBuilder();
                if (playlist.Tracks != null && playlist.Tracks.Any())
                {
                    foreach (var track in playlist.Tracks)
                    {
                        sb.AppendLine($"Track: {track.Title} - Artist: {track.Artist} - Duration: {track.Duration}");
                    }
                }
                document.Content.Replace("{{Tracks}}", sb.ToString());

                // Generate PDF
                var stream = new MemoryStream();
                document.Save(stream, new PdfSaveOptions());

                return File(
                    stream.ToArray(),
                    new PdfSaveOptions().ContentType,
                    $"Playlist_{playlist.Name}_{DateTime.Now:yyyyMMdd}.pdf"
                );
            }
            catch (Exception ex)
            {
                // Handle error appropriately
                Console.WriteLine($"Error creating invoice: {ex.Message}");
                throw;
            }
        }


    }
}
